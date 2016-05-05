using RykonServer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using RykonServer.Forms;
using System.Threading;
using ScreenTask;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace RykonServer
{
    

 public  partial class   FormMain : Form
 {
     private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
     private const int WM_APPCOMMAND = 0x319;

    

        private List<Tuple<string, string>> _Prefixs_;

        List<Color> _StartingColors = new List<Color>() { Color.Green, Color.GreenYellow };
        List<Color> _StoppingColors = new List<Color>() { Color.Red, Color.Pink };

        int _handled = 0; 
        private _Mode_ ServerMode = _Mode_.off;
        private HttpListener _MainServer_;
        private XCompiler _MainCompiler_ = new XCompiler();


        public int _ShotEvery = 500;
        private object _mrlocker_ = new object();
        private ReaderWriterLock _rwlck_ = new ReaderWriterLock();
        private MemoryStream _imgstr_;


        private bool _Listening_;
        private bool _isPreview;
        private bool _isMouseCapture;
        public bool _isTakingScreenshots = true;
        public bool _StreamerEnabled = false;//
        private bool separatedBrowser = false;

        public string _RootDirectory { get; set; }

        public string _LogsFilePath = "\\logs.txt";
        public string _ErrorFilePath = "\\Errors.txt";

        public string _AssemblyName = "Rykon Server  v 0.1.2      ";
        public ServerConfig Servconf;
        private FrmSelfBrowser TestingForm = new FrmSelfBrowser();

        public int _Canceled = 0;
        public int _Port = 9090;

        ContextMenu TrayMenu;
        public int screened = 0;
 
        private async Task StartServer()
        {
            ServerMode = _Mode_.on;
            ViewLog("Staring server ...");
            SetStatue("Staring server ...");

            string TrimmedPrefex = this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2;
            string SelectedPrefix = txbx_serverUrl.Text = "http://" + TrimmedPrefex + ":" + NumPort.Value.ToString() + "/";

            GenerateListenPlayer();
            GenerateMediaPlayer();
            GenerateControlIndex();

            ChangeControlerS();
            _MainServer_ = new HttpListener();
            _MainServer_.Prefixes.Add(SelectedPrefix);
            _MainServer_.Prefixes.Add("http://*:" + NumPort.Value.ToString() + "/");
            _MainServer_.Start();

            string xt = "Running on " + this._Port;
            Ballooon(xt);
            ViewLog(xt);

            if (this._StreamerEnabled)
                ViewLog("streamer on " + textBoxUrlStreamer.Text);

            if (this.Servconf.EnableControler)
                ViewLog("Control from " + SelectedPrefix + "/Control/");

            if (this.Servconf.EnableVideo)
                ViewLog("Video from " + SelectedPrefix + "/Video/");

            if (this.Servconf.EnableListen)
                ViewLog("Listen from " + SelectedPrefix + "/Listen/");


            SetStatue(xt);
            notifyIcon1.Text = "Rykon Online ";

            while (_Listening_)
            {
                try
                {
                    if (_MainServer_.IsListening == false)
                        break;

                    var ctx = await _MainServer_.GetContextAsync();
                    string ad = ((!this._RootDirectory.EndsWith("\\") ? "\\" : ""));
                    RykonProcess cp = new RykonProcess();
                    // cp.SaveRequestHeaders(ctx.Request.Headers);

                    cp.UrlOriginalString = ctx.Request.Url.OriginalString;
                    cp.LocalPath = ctx.Request.Url.LocalPath;
                    cp.RequestBuiltInTool = RykonProcess.IsREquestingTool(cp.LocalPath);
                    cp.RequestPage = (this._RootDirectory + /*ad+*/ cp.LocalPath.Replace("/", "\\")).Replace("\\\\", "\\");
                    cp.Request_extn = AppHelper.LastPeice(cp.RequestPage, ".");
                    cp.Request_extn = AppHelper.removeSlashes(cp.Request_extn);
                    cp.Requestor_Host = AppHelper.FirstPieceof(ctx.Request.RemoteEndPoint.Address.ToString(), ':');
                    cp.CanConnect = (this.Servconf.IsPublicServer);
                    cp.RequestorAddress = ctx.Request.UserHostAddress;
                    cp.Url = ctx.Request.Url;
                    cp.Requesting_Host = TrimmedPrefex;
                    if (cp.RequestPage.EndsWith("\\/"))
                        cp.RequestPage = cp.RequestPage.Substring(0, cp.RequestPage.Length - 1);
                  
                    bool AllowedTocontrol = false;
                    cp.RequestPage = WebServer.DecodeUrlChars(cp.RequestPage);


                    // receiving data 
                    if (ctx.Request.HttpMethod == "POST")
                    {
                        if (ctx.Request.HasEntityBody)
                        {
                            using (System.IO.Stream body = ctx.Request.InputStream) // here we have data
                            {
                                using (System.IO.StreamReader reader = new System.IO.StreamReader(body, ctx.Request.ContentEncoding))
                                {
                                    cp.RequestPostData = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                    try
                    {
                        bool CanConnect = true;

                        if (!this.Servconf.IsPublicServer)
                            CanConnect = WebServer.CheckBasicAuth(ctx.Request.Headers["Authorization"], Servconf.ServerAuthId, Servconf.ServerAutPass);

                        if (!CanConnect) // ask credit 
                        {
                            cp.Output_document = WebDesigner.IndexofNeedAuthentication;
                            cp.Output_code = 401;
                            cp.OutPutData = ASCIIEncoding.UTF8.GetBytes(cp.Output_document);
                            ctx.Response.AddHeader("WWW-Authenticate", "Basic realm=Rykon Server : ");
                            cp.Processing_Type = ProcessingResult.AuthRequired; 
                            
                        }
                        else if (cp.LocalPath.StartsWith("/Control"))
                        {

                            if (this.Servconf.SecureControl)
                                AllowedTocontrol = cp.UrlOriginalString.Contains(this.AuthToke);
                            else
                                AllowedTocontrol = true;

                            string[] pcs = new string[] { };
                            
                            if (!AllowedTocontrol)
                            {
                                cp.Output_document = WebDesigner.ControlNotAllowedIndex();//ControlLoginPage;
                                cp.OutPutData = Encoding.UTF8.GetBytes(cp.Output_document);
                                cp.Output_code = 405;
                                cp.Processing_Type = ProcessingResult.unAuthorized;
                            }
                            else if (cp.UrlOriginalString.Contains("exec") && cp.UrlOriginalString.Contains("com="))//&& !cp.UrlOriginalString.EndsWith(this.AuthToke))
                            {
                                // sending commands 
                                //"http://192.168.1.100:9090/Control/exec?jex&com=msgbx&title=hello+It"
                                if (cp.UrlOriginalString.Contains("?"))
                                    pcs = cp.UrlOriginalString.Split('?');

                                else if (cp.UrlOriginalString.Contains("/"))
                                    pcs = cp.UrlOriginalString.Split('/');
                               
                              
                            }
                            if (pcs.Length > 0)
                            {
                                // "http://192.168.1.100:9090/Control/exec   jex&com=msgbx&title=hello+It"
                                string main = pcs[pcs.Length - 1];

                                if (main.StartsWith(this.AuthToke))
                                    main = main.Substring(this.AuthToke.Length);

                                RemoteCommandExecuter r = new RemoteCommandExecuter(main);
                                r.HandlePointer = this.Handle; 
                                r.proceeed(); 
                                cp.Output_document = (r.Result);
                                
                            }

                            else  if(AllowedTocontrol)// List Command index
                            {
                                cp.Output_document = AppHelper.ReadFileText(_RootDirectory + "/Control/index.html");
                                cp.OutPutData = Encoding.UTF8.GetBytes(cp.Output_document);
                            }

                        }
                        else if (cp.LocalPath.StartsWith("/Stream/LiveStream.jpg"))
                        {
                            var page = _RootDirectory + cp.LocalPath;
                            bool fileExist;
                            lock (_mrlocker_)
                                fileExist = File.Exists(page);
                           
                            if (fileExist)
                            {
                                _rwlck_.AcquireReaderLock(Timeout.Infinite);
                                cp.OutPutData = File.ReadAllBytes(page);
                                _rwlck_.ReleaseReaderLock();
                                ctx.Response.ContentType = "text/jpg"; // Important For Chrome Otherwise will display the HTML as plain text.
                                cp.Requesting_Binary_data = true;
                                cp.Processing_Type = ProcessingResult.Binary;
                            }

                        }

                        else if (AppHelper.IsFileExist(cp.RequestPage))                   //dynamic  static page  or bin 
                        { 
                            cp.RequestPage = AppHelper.Correctpath(cp.RequestPage);
                            if (_MainCompiler_.IsCompilable(cp.RequestPage))   //dynamic page                         {
                            {
                                cp.Output_document = _MainCompiler_.CompileThis(cp.RequestPage,cp.Url.Query.ToString(),cp.RequestPostData);
                                cp.SetData_ReadTextFile(cp.Output_document);
                            }
                            else if (WebServer.IsBinFile(cp.RequestPage))           // binary 
                            {
                                cp.Output_document = (cp.RequestPage);
                                cp.Requesting_Binary_data = true;
                                cp.SetData_ReadBinFile(cp.RequestPage);
                                cp.ContentType = "content/"+cp.Request_extn;
                                cp.Processing_Type = ProcessingResult.Binary;
                            }
                            else                                            // static  page
                            {
                                cp.Output_document = WebDesigner.ReadFile(cp.RequestPage);
                                cp.SetData_ReadTextFile(cp.Output_document);
                                ctx.Response.ContentType = "text/"+cp.Request_extn;
                                
                            }
                           
                        }

                        else if (ctx.Request.Url.LocalPath.EndsWith("/") || AppHelper.ExistedDir(cp.RequestPage))
                        //default index or browse Dir
                        {

                            string outed = "";
                            if (_MainCompiler_.IsFoundDefaultIndex(cp.RequestPage,out outed))
                                cp.Output_document = _MainCompiler_.CompileThis((outed == "") ? cp.RequestPage : outed, cp.Url.Query.ToString(),cp.RequestPostData);

                            else if (WebServer.IsDirectoryFound(cp.RequestPage))
                                 cp.Output_document = WebDesigner.ListDirectory( cp.RequestPage,WebServer.ListDir(cp.RequestPage, this._RootDirectory, cp.Requesting_Host, this._Port.ToString()), Servconf);
                             
                        }
                        else                         // not found 
                        {
                            cp.Output_document = WebDesigner.FileNotFoundTitle_Traditional(cp.Requesting_Host, this._Port.ToString());
                            cp.Output_code = 404;
                            cp.Processing_Type = ProcessingResult.NotFound;
                        }
                        
                        ctx.Response.StatusCode = cp.Output_code;
                        ctx.Response.ContentType = cp.ContentType;
                        if (cp.Requesting_Binary_data)
                        {
                            ctx.Response.Headers.Add("Accept-Ranges", "bytes");
                            ctx.Response.Headers.Add("Last-Modified", "");
                            ctx.Response.Headers.Add("Server", "Rykon");
                            ctx.Response.Headers.Add("Date", System.DateTime.Now.ToShortDateString());
                            ctx.Response.Headers.Add("Content-Type", "image/" + cp.Request_extn);
                            await ctx.Response.OutputStream.WriteAsync(cp.OutPutData, 0, cp.OutPutData.Length);
                        }
                        else
                            await ctx.Response.OutputStream.WriteAsync(ASCIIEncoding.UTF8.GetBytes(cp.Output_document), 0, cp.Output_document.Length);
                        ctx.Response.Close();

                        if (cp.Processing_Type == ProcessingResult.AuthRequired)
                            continue;


                    }
                    //catch
                    //{
                    //    cp.Output_document = WebDesigner._501InternalServerError(cp.Requesting_Host, this._Port.ToString(), this.ServerConfiguration);
                    //    cp.Output_code = 501;
                    //}
                    catch (OutOfMemoryException h)
                    {
                        cp.ErrorMessage = h.Message;
                        cp.exception = ExceptionType.OutOfMemory_;
                    }
                    catch (HttpListenerException h)
                    {
                        cp.ErrorMessage = h.Message;
                        cp.exception = ExceptionType.HttpListner_;
                    }

                    if (cp.exception != ExceptionType.none_)
                    {
                        cp.ServerErroroccured = true;
                        cp.Output_code = 501;
                        ctx.Response.StatusCode = cp.Output_code;

                        switch (cp.exception)
                        {
                            case ExceptionType.OutOfMemory_:
                                {
                                     cp.Output_document = WebServer.GetInternalErrorException(cp.exception);
                                    break;
                                }
                            
                            case ExceptionType.HttpListner_:
                                { 
                                    if (cp.ErrorMessage == "The I/O operation has been aborted because of either a thread exit or an application request" || cp.ErrorMessage== "The specified network name is no longer available")
                                    {
                                        this._Canceled++;
                                        cp.exception = ExceptionType.CanceledByRequestor;
                                        cp.Output_document = "Request Canceled by client";
                                        cp.Canceled = true;
                                    }
                                    break;
                                }

                        }

                        try // Informing client with server error
                        {
                            await ctx.Response.OutputStream.WriteAsync(ASCIIEncoding.UTF8.GetBytes(cp.Output_document), 0, cp.Output_document.Length);
                        }
                        catch (Exception h) { cp.ErrorMessage = h.Message;   cp.exception = ExceptionType.FailedToHandle;}
                         
                    }
                    
                   // ctx.Response.OutputStream.Close();
                    ctx.Response.Close();
                   
                    if (!cp.Canceled)
                        _handled++;

                    ViewLog("  ["+cp.Requesting_Host+"]   ["+cp.Url.LocalPath+WebServer.DecodeUrlChars(cp.Url.Query)+ "]    [" + WebDesigner.StatueCode(cp.Output_code)+((cp.ServerErroroccured)?("("+cp.ErrorMessage+")"):"")+"]   ["+cp.getLenght()+"]");
                    
                    ShowCounters();
                }
                catch { }

            }
            if (!_Listening_)
                stopserver();
        }

        private void GenerateMediaPlayer()
        {

            string mp = this._RootDirectory + "\\Video\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);
            string d = WebDesigner.VideoDefaultIndex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString());
            bool b = AppHelper.writeToFile(mp, d);
        }
        private void GenerateControlIndex()
        {
            string mp = this._RootDirectory + "\\Control\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);

            string d = WebDesigner.ControlCommandListindex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString(), this.AuthToke);
            bool b = AppHelper.writeToFile(mp, d);

        }
        private void GenerateListenPlayer()
        {
            string mp = this._RootDirectory + "\\Listen\\index.html";
            mp = AppHelper.RepairPathSlashes(mp);
            AppHelper.RepairPath(mp);

            string d = WebDesigner.ListenDefaultIndex(this._RootDirectory, this._Prefixs_[(cb_Prefixs.SelectedIndex)].Item2, this._Port.ToString());
            bool b = AppHelper.writeToFile(mp, d);
        }
        private void stopserver()
        {
            try
            {
                _MainServer_.Stop();
                _MainServer_.Abort();
                _MainServer_ = new HttpListener();

                string xt = "Server stopped";
                Ballooon(xt);
                ViewLog(xt);

                SetStatue(xt);
                notifyIcon1.Text = "Rykon Offline ";
            }
            catch { }
        }
        public FormMain()
        {
            InitializeComponent();
            InitializeComponent2();

            _MainServer_ = new HttpListener();
            _MainCompiler_ = new XCompiler();
            this._LogsFilePath = Application.StartupPath + "\\Logs.txt";
            this._ErrorFilePath = Application.StartupPath + "\\Errors.txt";

            LoadServerConfiguration();

            this._StreamerEnabled = Servconf.EnableStream;
            this._ControlerEnabled_ = Servconf.EnableControler;

            LoadPrefixes();
            LoadFiles();


            LoadLanguages();
            LoadSettings();


            SetStatue(""); 

        }

        private void InitializeComponent2()
        {
             
        }

        private void LoadServerConfiguration()
        {
            string ServerConfigPath = Application.StartupPath + "\\Req\\httpd.conf".Replace("\\\\", "\\");
            this.Servconf = new ServerConfig(ServerConfigPath);

            txbxControlPasswd.Text = Servconf.ControlPassword;
            cp_private.Checked = !Servconf.IsPublicServer;
            txbxServerPass.Text = Servconf.ServerAutPass;
            TxbxServerId.Text = Servconf.ServerAuthId;

            TxbxServerId.Text = Servconf.ServerAuthId;
            txbxServerPass.Text = Servconf.ServerAutPass;
            txbx_pass_Control.Text = Servconf.ControlPassword;
            txbx_pass_Listen.Text = Servconf.ListenPassword;
            txbx_pass_Stream.Text = Servconf.StreamPassword;
            txbx_pass_Upload.Text = Servconf.UploadPassword;
            txbx_pass_video.Text = Servconf.VideoPassword;

            cb_secure_control.Checked = Servconf.SecureControl;
            cb_secure_listen.Checked = Servconf.SecureListen;
            cb_secure_stream.Checked = Servconf.SecureStream;
            cb_secure_upload.Checked = Servconf.SecureUpload;
            cb_secure_video.Checked = Servconf.SecureVideo;


            videoToolStripMenuItem.Checked =videoonToolStripMenuItem1.Checked= Servconf.EnableVideo;
            offvideoToolStripMenuItem1.Checked = !Servconf.EnableVideo;

            listenToolStripMenuItem.Checked = onlistenToolStripMenuItem.Checked = Servconf.EnableListen;
            offlistenToolStripMenuItem.Checked = !Servconf.EnableListen;


            int port = this.Servconf.Port;
            if (port > 0 && port <= 65353)
                this.NumPort.Value = port;

        }
        private void FormMain_Load(object sender, EventArgs e)
        {


            //this.Size = new Size(this.Size.Width + 10, this.Size.Height + 10);
            TbControlSettings.Size = new Size(470, 236);
            TbControlSettings.Location = new Point(89, 2);
            this.MinimumSize = this.Size;

            if (Servconf.AutoStartListening)
                btnSwitch.PerformClick();
            else
                ChangeControlerS();

            CloseTabPages();

        }

        private void CloseTabPages()
        {
            while (tabControlMain.TabCount > 1)
                tabControlMain.TabPages.RemoveAt(1);
        }
        private void LoadLanguages()
        {
            this._MainCompiler_.ClearList();
            _MainCompiler_.savepath = Application.StartupPath + "\\Req\\langs.conf".Replace("\\\\", "\\");

            string languagesCollectionString = AppHelper.ReadFileText(_MainCompiler_.savepath);
            cmbxLangs.DisplayMember="LangName";
            if (languagesCollectionString.Contains(RykonLang.Langs_Separator.ToString()))
            {
                string[] langsArr = languagesCollectionString.Split( RykonLang.Langs_Separator );
                
                foreach (string _l_ in langsArr)
                {
                    RykonLang r = RykonLang.Build(_l_);
                    if (!r.validLang())
                        continue;
                    cmbxLangs.Items.Add(r.LangName);
                        _MainCompiler_.AddLanguage(r);
                }
            }
            else if (!string.IsNullOrEmpty(languagesCollectionString))
            {
                // single language
                RykonLang r = RykonLang.Build(languagesCollectionString);
                if (r.validLang())
                {
                    cmbxLangs.Items.Add(r.LangName);
                    _MainCompiler_.AddLanguage(r);

                }
            }

        } 
        private void LoadFiles()
        {
            this.logsoldData = AppHelper.ReadFileText(this._LogsFilePath, true);
            this.ErroroldData = AppHelper.ReadFileText(this._ErrorFilePath, true);

            txbxLogs.Text = logsoldData;
        }

        private void LoadPrefixes()
        {
            _Prefixs_ = DrNetwork.GetAllIPv4Addresses();
            foreach (var ip in _Prefixs_)
            {
                cb_Prefixs.Items.Add(ip.Item2 + " - " + ip.Item1);
            }

            if (!SelectIpIfFound(SettingsEditor.GetFavPrefix()))
                if (!SelectIpIfFound("192.168.1.1"))
                    cb_Prefixs.SelectedIndex = cb_Prefixs.Items.Count - 1;


        }

        //netsh http add urlacl url=http://vaidesg:8080/ user=everyone
        //httpcfg set urlacl /u http://vaidesg1:8080/ /a D:(A;;GX;;;WD)


        private Task AddFirewallRule(int port)
        {
            return Task.Run(() =>
            {

                string cmd = RunCMD("netsh advfirewall firewall show rule \"Rykon\"");
                if (cmd.StartsWith("\r\nNo rules match the specified criteria."))
                {
                    cmd = RunCMD("netsh advfirewall firewall add rule name=\"Rykon\" dir=in action=allow remoteip=localsubnet protocol=tcp localport=" + port);
                    if (cmd.Contains("Ok."))
                    {
                        //   SetLog("Rykon Rule added to your firewall");
                    }
                }
                else
                {
                    cmd = RunCMD("netsh advfirewall firewall delete rule name=\"Rykon\"");
                    cmd = RunCMD("netsh advfirewall firewall add rule name=\"Rykon\" dir=in action=allow remoteip=localsubnet protocol=tcp localport=" + port);
                    if (cmd.Contains("Ok."))
                    {
                        //  SetLog("Rykon Rule updated to your firewall");
                    }
                }
            });

        }
        private string RunCMD(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/C " + cmd;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.Start();
            string res = proc.StandardOutput.ReadToEnd();
            proc.StandardOutput.Close();

            proc.Close();
            return res;
        }

        private bool SelectIpIfFound(string p)
        {
            bool found = false;
            int i = -1;
            foreach (string s in cb_Prefixs.Items)
            {
                i++;
                if (s.Trim() == p.Trim())
                {
                    cb_Prefixs.SelectedIndex = i; found = true;
                }
            }


            return found;
        }

        private void LoadSettings()
        {
            this.separatedBrowser = cbTestInSeparated.Checked = SettingsEditor.GetseparatedBrowser();

            this._RootDirectory = txbxRootDir.Text = SettingsEditor.GetRootDirectory(Application.StartupPath);
            this.tstrpBtnStream.Checked = tstrpBtnStreamOn.Checked = _StreamerEnabled;
            this.tstrpBtnStreamOff.Checked = !_StreamerEnabled;

            this.Tsrtrp_controler.Checked = Tsrtrp_controler_on.Checked = _ControlerEnabled_;
            this.Tsrtrp_controler_off.Checked = !_ControlerEnabled_;

        }
        private async void btnSwitch_Click(object sender, EventArgs e)
        {
            RegenerateAuthCode();
            btnSwitch.Enabled = false;
            btnSwitch.Enabled = false;

            if (ServerMode == _Mode_.on)//stop 
            {
                this._Listening_ = false;
                this._isTakingScreenshots = false;
                ServerMode = _Mode_.off;
                stopserver();
            }
            else if (ServerMode == _Mode_.off)//pressed start
            {
                try
                {

                    ViewLog("initiating , Please Wait...");

                    _MainServer_.IgnoreWriteExceptions = true;
                    _isTakingScreenshots = true;
                    _Listening_ = true;

                    await AddFirewallRule((int)NumPort.Value);

                    if (_StreamerEnabled)
                        Task.Factory.StartNew(() => CaptureScreenEvery(this.ScreenTicks)).Wait();


                    await StartServer();


                }
                catch (ArgumentException ae)
                {
                    ServerMode = _Mode_.off;
                    string p = ("Starting Server exception " + ae.Message);

                    ViewLog(p);
                }

                catch (HttpListenerException ae)
                {
                    ServerMode = _Mode_.off;
                    string msg = "";
                    if (ae.Message.Contains("The process cannot access the file because it is being used by another process"))
                    {
                        msg = "Port in use ";
                        SetStatue("Can not listen on Port (" + NumPort.Value.ToString() + ") because it  is in use ");
                        if (MessageBox.Show("port is in use , Do you want to try another one?", "Error used port", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Random r = new Random(23232);
                            NumPort.Value = (decimal)r.Next(1000, 64000);
                            btnSwitch_Click(null, null);
                            return;
                        }
                        else
                            msg = ae.Message;

                        string p = ("Starting Server exception " + msg);

                        ViewLog(p);

                    }
                }
                catch (ObjectDisposedException disObj)
                {
                    _MainServer_ = new HttpListener();
                    _MainServer_.IgnoreWriteExceptions = true;
                }
                catch (Exception ae)
                {
                    ServerMode = _Mode_.off;
                    string p = ("Starting Server Error" + ae.Message);
                    // SetError(p);
                    ViewLog(p);
                }
            }
            ChangeControlerS();
        }

       

        private void RegenerateAuthCode()
        {
            return;
            this.AuthToke = now();
        }

        private void SavePrefix()
        {
            if (cb_Prefixs.SelectedIndex > -1)
                SettingsEditor.SetFavPrefix(cb_Prefixs.SelectedItem.ToString());

        }
        private void TakeScreenshot(bool captureMouse)
        {
            screened++;
            if (captureMouse)
            {
                var bmp = ScreenCapturePInvoke.CaptureFullScreen(true);
                _rwlck_.AcquireWriterLock(Timeout.Infinite);
                bmp.Save(this._RootDirectory + "/Stream/LiveStream.jpg", ImageFormat.Jpeg);
                _rwlck_.ReleaseWriterLock();
                if (_isPreview)
                {
                    _imgstr_ = new MemoryStream();
                    bmp.Save(_imgstr_, ImageFormat.Jpeg);
                    imgPreview.Image = new Bitmap(_imgstr_);
                }
                return;
            }
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                _rwlck_.AcquireWriterLock(Timeout.Infinite);
                bitmap.Save(this._RootDirectory + "/Stream/LiveStream.jpg", ImageFormat.Jpeg);
                _rwlck_.ReleaseWriterLock();
                if (_isPreview)
                {
                    _imgstr_ = new MemoryStream();
                    bitmap.Save(_imgstr_, ImageFormat.Jpeg);
                    imgPreview.Image = new Bitmap(_imgstr_);
                }


            }
        }

        private async Task CaptureScreenEvery(int msec)
        {

            while (_Listening_)
            {
                if (this._isTakingScreenshots && _StreamerEnabled)
                {
                    TakeScreenshot(_isMouseCapture);
                    msec = this.ScreenTicks;// (int)numShotEvery.Value;
                    await Task.Delay(msec);
                }
            }

        }


        private string now()
        {
            return DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
        }

        private void Ballooon(string p)
        {
            this.notifyIcon1.BalloonTipText = p;
            notifyIcon1.ShowBalloonTip(500);
        }


        private void ShowCounters()
        {
            labelStatue.Text = "Handled {" + _handled + "}  Canceled {" + _Canceled + "} ";
        }


        private void ViewLog(string p)
        {
            if (this.lastlogline == p)
                return;

            this.lastlogline = p;
            string nh = "["+(now() + "]  " + p + "\r\n");

            LogsnewData += nh;
            txbxLogs.AppendText ( nh);

            txbxLogs.SelectionStart = txbxLogs.Text.Length - 1;
            txbxLogs.ScrollToCaret();
        }

        private void ChangeControlerS()
        {
            bool starting = ServerMode == _Mode_.Middle;
            _Listening_ = _isTakingScreenshots = (ServerMode == _Mode_.on);

            pcbxLoader.Visible = _Listening_;

            btnSwitch.Enabled =  true;
            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = _Listening_;
            offlineToolStripMenuItem.Checked = !_Listening_;
            privateToolStripMenuItem.Checked = !Servconf.IsPublicServer;
            publicToolStripMenuItem.Checked = Servconf.IsPublicServer;
            privateToolStripMenuItem.Enabled = publicToolStripMenuItem.Enabled = !_Listening_;
            Servconf.EnableStream = this._StreamerEnabled;
            Servconf.EnableControler = this._ControlerEnabled_;
            
            string stat = "";
            if (_Listening_)
                stat = "Stop Server ";
            else if (starting)
                stat = "starting ..";
            else
                stat = "Start Server";

            btnSwitch.Text = stat; 
            NumPort.Enabled = cb_Prefixs.Enabled = !_Listening_;
            gpxStreamer.Enabled = _StreamerEnabled;
            txbx_serverUrl.Enabled = _Listening_;
            this.Text = this._AssemblyName + ((_Listening_) ? ("       (Running on " + NumPort.Value + ")") : (""));
            buttonTestSelfBrowser.Enabled = _Listening_;
            btnTestStreamer.Enabled = _Listening_ && _StreamerEnabled;
            if (!_Listening_)
                txbx_serverUrl.Text = "";

            tstrpBtnStream.Checked = tstrpBtnStreamOn.Checked = this._StreamerEnabled;
            tstrpBtnStreamOff.Checked = !this._StreamerEnabled;

            Tsrtrp_controler_on.Checked = Tsrtrp_controler.Checked = this._ControlerEnabled_;
            Tsrtrp_controler_off.Checked = !this._ControlerEnabled_;
            Tsrtrp_controler_on.Enabled =
            Tsrtrp_controler_off.Enabled =
            tstrpBtnStreamOff.Enabled =
            tstrpBtnStreamOn.Enabled = ServerMode == _Mode_.off;
            panelBottom.BackColor = (_Listening_) ? Color.Yellow : Color.FromArgb(202, 81, 0);
            reloadServerConfigurationToolStripMenuItem.Enabled = onlineToolStripMenuItem.Enabled = offlineToolStripMenuItem.Enabled = ServerMode!=_Mode_.on;
        }

        private void SetStatue(string p)
        {
            labelStatue.Text = p;
        }

        private void SetLog(string p)
        {
            try
            {
                ViewLog(p);
                this.LogsnewData += p + "\r\n";

            }
            catch { }
        }

        private void txbxRootDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() != DialogResult.OK)
                return;
            txbxRootDir.Text = f.SelectedPath;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //  new FrmSettings(_MainCompiler_).ShowDialog();
            LoadSettings();
        }

        private void NumPort_ValueChanged(object sender, EventArgs e)
        {
            Servconf.Port = this._Port = (int)NumPort.Value;



        }

        private void cb_Prefixs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SavePrefix();
        }


        private void btnCopyUrl_Click(object sender, EventArgs e)
        {

        }


        private void buttonTestSelfBrowser_Click(object sender, EventArgs e)
        {
            LaunchBrowser(txbx_serverUrl.Text);
        }
        private void LaunchBrowser(string url)
        {

            if (url.Length < 2)
                return;

            if (!separatedBrowser)
            {
                LookForTabPAge(tabControlMain, tbpgBrowser);
                textBox_BrowserUrl.Text = url;
                buttonNavigate.PerformClick();
                return;
            }

            TestingForm.ShowInTaskbar = true;
            if (TestingForm.IsDisposed)
                TestingForm = new FrmSelfBrowser();

            TestingForm.SetUrl(url);
            TestingForm.Show();
        }

        private void linkLabelOpenRootDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (System.IO.Directory.Exists(txbxRootDir.Text))
                AppHelper.StartProcess(txbxRootDir.Text);
        }


        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                //  notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            this.btnTestStreamer.Size = this.StreamBtnsize;
            this.btnTestStreamer.Location = this.StreamBtnLocation;


            this.buttonTestSelfBrowser.Size = this.serverBtnsize;
            this.buttonTestSelfBrowser.Location = this.serverBtnLocation;

        }


        private void cb_Streamer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Switch_cb_Streamer_()//object sender, EventArgs e)
        {
            _StreamerEnabled = tstrpBtnStream.Checked;
            gpxStreamer.Enabled = _StreamerEnabled;
            Servconf.EnableStream = _StreamerEnabled;

        }

        private void txbxUrl_TextChanged(object sender, EventArgs e)
        {
            lnk_copyUrl.Visible = txbx_serverUrl.TextLength > 1;
            textBoxUrlStreamer.Text = (txbx_serverUrl.Text.Length < 1 || !_StreamerEnabled) ? "" : (txbx_serverUrl.Text + "Stream");
        }

        private void buttonCopyStrmUrl_Click(object sender, EventArgs e)
        {

        }

        private void btnTestStreamer_Click(object sender, EventArgs e)
        { 
                LaunchBrowser(textBoxUrlStreamer.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string x = "";
            x += "mouscap = " + this._isMouseCapture + "\r";
            x += "iswork = " + this._Listening_ + "\r";
            x += "shotev = " + this._ShotEvery + "\r";
            x += "mouscap = " + this._isMouseCapture + "\r";
            x += "istakscrs =" + this._isTakingScreenshots + "\r";
            x += "screentook " + screened;
            MessageBox.Show(x);
        }


        public int ScreenTicks = 500;


        public string lastlogline = "";

        private void gpxStreamer_Enter(object sender, EventArgs e)
        {

        }

        private void lnk_copyUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbx_serverUrl.Text))
                return;
            Clipboard.SetText(txbx_serverUrl.Text);
            SetStatue("Url Copied to Clipboard");
        }

        private void lnk_copyStreamUrl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbx_serverUrl.Text))
                return;
            Clipboard.SetText(textBoxUrlStreamer.Text);
            SetStatue("Url Copied to Clipboard");
        }

        private void txbxUrl_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBoxUrlStreamer_TextChanged(object sender, EventArgs e)
        {
            lnk_copyStreamUrl.Visible = strmlbl.Visible = textBoxUrlStreamer.TextLength > 1;
            strmlbl.Text = "Streamer available on " + textBoxUrlStreamer.Text;
        }

        private void tstrpBtnStreamOn_Click(object sender, EventArgs e)
        {
            _StreamerEnabled = this.Servconf.EnableStream = true;
            ChangeControlerS();
        }

        private void tstrpBtnStreamOff_Click(object sender, EventArgs e)
        {
            _StreamerEnabled = this.Servconf.EnableStream = false;
            ChangeControlerS();
        }

        private void Tsrtrp_controler_off_Click(object sender, EventArgs e)
        {
            _ControlerEnabled_ = this.Servconf.EnableControler = true;
            ChangeControlerS();
        }

        private void Tsrtrp_controler_on_Click(object sender, EventArgs e)
        {
            this._ControlerEnabled_ = this.Servconf.EnableControler = true;
            ChangeControlerS();
        }
        public bool _ControlerEnabled_ = false;
        private void lnk_copyStreamUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.textBoxUrlStreamer.TextLength > 0)
                Clipboard.SetText(textBoxUrlStreamer.Text);
        }

        private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_Listening_)
                return;
            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = true;
            offlineToolStripMenuItem.Checked = false;

            btnSwitch.PerformClick();
        }

        private void offlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_Listening_)
                return;

            onlineToolStripMenuItem.Checked = modeToolStripMenuItem.Checked = false;
            offlineToolStripMenuItem.Checked = true;
            btnSwitch.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnk_copyUrl_VisibleChanged(object sender, EventArgs e)
        {
            int w = btnSwitch.Size.Width;
            if (!lnk_copyUrl.Visible)
            {
                buttonTestSelfBrowser.Size = new Size(w, 23);
                buttonTestSelfBrowser.Location = new Point(424, 38);
            }
            else
            {
                w = w - (lnk_copyUrl.Size.Width);

                buttonTestSelfBrowser.Size = new Size(w, 23);
                buttonTestSelfBrowser.Location = new Point(458, 38);
            }

            this.serverBtnLocation = buttonTestSelfBrowser.Location;
            this.serverBtnsize = buttonTestSelfBrowser.Size;
        }

        private void lnk_copyStreamUrl_VisibleChanged(object sender, EventArgs e)
        {
            int w = btnSwitch.Size.Width;

            if (!lnk_copyStreamUrl.Visible)
            {
                btnTestStreamer.Size = new Size(w, 23);
                btnTestStreamer.Location = new Point(424, 14);
            }
            else
            {
                w = w - (lnk_copyStreamUrl.Size.Width);
                btnTestStreamer.Size = new Size(w, 23);
                btnTestStreamer.Location = new Point(463, 14);
            }
            this.StreamBtnLocation = btnTestStreamer.Location;
            this.StreamBtnsize = btnTestStreamer.Size;

        }

        private void btnSwitch_EnabledChanged(object sender, EventArgs e)
        {
            btnTestStreamer.BackColor = (btnTestStreamer.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);
            buttonTestSelfBrowser.BackColor = (buttonTestSelfBrowser.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);
            btnSwitch.BackColor = (btnSwitch.Enabled) ? Color.FromArgb(225, 111, 9) : Color.FromArgb(250, 200, 150);


        }

        public Size StreamBtnsize = new Size(64, 23);

        public Point StreamBtnLocation = new Point(424, 14);

        public Point serverBtnLocation = new Point(463, 38);

        public System.Drawing.Size serverBtnsize = new Size(64, 23);

        private void timerWriter_Tick(object sender, EventArgs e)
        {
            saveData(); 
        }

        private void SaveLogs()
        {
            AppHelper.writeToFile(this._LogsFilePath, (this.logsoldData + "\r\n" + this.LogsnewData).Trim());
        }

        public string logsoldData = "";

        public string LogsnewData = "";



        internal void saveData()
        {
           this.Servconf.SaveChanges();
            SaveLogs();
            saveErrors();
            SettingsEditor.Save();
        }

        private void saveErrors()
        {
            AppHelper.writeToFile(this._ErrorFilePath, this.ErroroldData + "\r\n" + this.ErrorsnewData);

        }

        public string ErroroldData = "";//{ get; set; }
        public string ErrorsnewData = "";

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ServerMode == _Mode_.on)
            {
                DialogResult dg = MessageBox.Show("Server is online \r\n if you exited , it will not be able to process current connection \r\n Are you sure to exite ?", "warning server online ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                btnSwitch.PerformClick();
            }
            saveData();
            notifyIcon1.Icon = null;
            notifyIcon1.Dispose();

        }

        private void lnkcloseLogs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseCurrentTabPage();
        }

        private void CloseCurrentTabPage()
        {
            int i = tabControlMain.SelectedIndex;
            if (tabControlMain.TabPages[i].Text == tbpgBrowser.Text)
                webBrowser1.Navigate("");

            tabControlMain.TabPages.RemoveAt(i);
            tabControlMain.SelectedIndex = ((i < tabControlMain.TabCount)) ? i : tabControlMain.TabCount - 1;
        }

        private void logsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabControlMain, tabPageLogs);
            LookForTabPAge(TbControlSettings, tbpg_set_Server);
        }

        private void LookForTabPAge(TabControl x, TabPage tpg)
        {
            for (int i = 0; i < x.TabCount; i++)
                if (x.TabPages[i].Text == tpg.Text)
                {
                    x.SelectedIndex = i;
                    return;
                }
            x.TabPages.Add(tpg);
            x.SelectedIndex = x.TabCount - 1;

        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabControlMain, tabPageSettings);

        }

        private void lnk_close_Tab(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseCurrentTabPage();
        }
         

        private void viewStreamerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabControlMain, tabPage_streamer);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabControlMain, tabPageAbout);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookForTabPAge(tabControlMain, tabPageDesigner);

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Program.GithUbURl);
        }

        private void closeTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTabPages();
        }

        private void cbswitch_streamerPreview_CheckedChanged(object sender, EventArgs e)
        {
            _isPreview = cbswitch_streamerPreview.Checked;
            if (_isPreview == false)
                this.imgPreview.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;

        }

        private void reloadServerConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLanguages();
            LoadServerConfiguration();
        }


public string AuthToke=""; 

        private void txbxControlPasswd_TextChanged(object sender, EventArgs e)
        {
            this.AuthToke = txbxControlPasswd.Text;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                TbControlSettings.SelectedIndex = int.Parse(treeView1.SelectedNode.Tag.ToString());
            }
            catch { }
        }

        private void privateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            privateToolStripMenuItem.Checked = !privateToolStripMenuItem.Checked;
            publicToolStripMenuItem.Checked = !privateToolStripMenuItem.Checked;

            if (privateToolStripMenuItem.Checked)
                Servconf.IsPublicServer = true;
        }

        private void publicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publicToolStripMenuItem.Checked = !publicToolStripMenuItem.Checked;
            privateToolStripMenuItem.Checked = !publicToolStripMenuItem.Checked;

            if (publicToolStripMenuItem.Checked)
                Servconf.IsPublicServer = true;
        }

        private void credintialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LookForTabPAge(tabControlMain, tabPageSettings);
            LookForTabPAge(TbControlSettings, tbpgSecurity);


        }

        private void cp_private_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.IsPublicServer = !cp_private.Checked;
            panel_server_credit.Enabled = cp_private.Checked;
            
            publicToolStripMenuItem.Checked = Servconf.IsPublicServer = !cp_private.Checked;
            privateToolStripMenuItem.Checked = !publicToolStripMenuItem.Checked;
        
        }

        private void Txbx_ServerId_TextChanged(object sender, EventArgs e)
        {
            this.Servconf.ServerAuthId = TxbxServerId.Text;

        }

        private void txbxServerPass_TextChanged(object sender, EventArgs e)
        {
            this.Servconf.ServerAutPass = txbxServerPass.Text;
        }

        private void saveNewSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void cbTestInSeparated_CheckedChanged(object sender, EventArgs e)
        {
            SettingsEditor.SetseparatedBrowser(cbTestInSeparated.Checked); 
            this.separatedBrowser = cbTestInSeparated.Checked;
        }

        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            navigateNow();
        }
        private void navigateNow()
        {

            webBrowser1.Navigate(textBox_BrowserUrl.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        } 

        private void cb_run_atstartup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traymenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           MessageBox.Show( (string)sender);
        }

        private void viewPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewRListenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbSecureControl_CheckedChanged(object sender, EventArgs e)
        {
            this.Servconf.SecureControl = cbSecureControl.Checked;
        }


        private void lstbxExts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnk_removeExtn.Visible = lstbxExts.SelectedIndex> 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lnk_add_newExt.Visible = TxbxAddExtn.TextLength > 1;
        }

        private void lnk_add_newExt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string p = TxbxAddExtn.Text.Trim().ToLower();
            p = AppHelper.RemoveInvalidPathChars(p);
            if (!p.StartsWith("."))
                p = "." + p;
            if (lstbxExts.Items.Contains(p))
                return;
            lstbxExts.Items.Add(p);
        }

        private void lnk_ClearExtns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstbxExts.Items.Clear();
        }

        private void panel_lang_controls_VisibleChanged(object sender, EventArgs e)
        {
            lnk_langPath_Browse.Visible = panel_lang_controls.Visible;
            txbxLangArgs.ReadOnly = txbxLangName.ReadOnly = txbxLangPath.ReadOnly = txbxLangVer.ReadOnly = !panel_lang_controls.Visible;
            cb_langEnabled.Enabled = panel_lang_controls.Visible;

        }

        private void lnk_langPath_Browse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "EXE|*.exe";

            if (o.ShowDialog() == DialogResult.OK)
                this.txbxLangPath.Text = o.FileName;
        }

        private void btnEditLang_Click(object sender, EventArgs e)
        {
            panel_lang_controls.Visible = !panel_lang_controls.Visible;
            bool EditMode = panel_lang_controls.Visible;
            
            btnEditLangs.Text = EditMode ? "Save" : "Edit";
            cmbxLangs.Enabled =  btnNewLang.Visible = !EditMode;

            if (!EditMode)
                SaveLangs(); 

        }

        private bool SaveLangs()
        {
            RykonLang SelectedLanguage = new RykonLang();
            SelectedLanguage.LangName = txbxLangName.Text;

            if (SelectedLanguage.LangName.Length < 2)
            {
                SetStatue("language should has a name");
                return false;
            }

            SelectedLanguage.ProcessArgs = txbxLangArgs.Text;
            if (SelectedLanguage.LangName.Length < 2)
                 SetStatue("Be careful no args for this compiler"); 

            SelectedLanguage.CompilerPath = txbxLangPath.Text;
            if(!AppHelper.IsFileExist (SelectedLanguage.CompilerPath))
            {
                SetStatue("language should has available compiler");
                return false;
            }

            SelectedLanguage.LangVersion = txbxLangVer.Text; 
            if (SelectedLanguage.LangName.Length < 1)
            {
                SetStatue("Language version unknown , i assigned a 1 for default");
                SelectedLanguage.LangVersion = "1";
            }

            SelectedLanguage.InitExts(lstbxExts.Items);
            if (SelectedLanguage.FileExts.Count < 1)
            {
                SetStatue("language should has at least one file extension");
                return false;
            }

            txbxLangName.Text = txbxLangArgs.Text = txbxLangPath.Text = txbxLangVer.Text = "";
            lstbxExts.Items.Clear();


            this._MainCompiler_.AddLanguage(SelectedLanguage);
            txbxLangName.Text = txbxLangArgs.Text = txbxLangPath.Text = txbxLangVer.Text = "";
            lstbxExts.Items.Clear();
            SetStatue("upated");

            _MainCompiler_.Save();
            cmbxLangs.SelectedIndex = -1;cmbxLangs.SelectedIndex = cmbxLangs.Items.Count-1;
            return true;


        }

        private void lstbxLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_langEnabled.Visible = btnEditLangs.Visible = cmbxLangs.SelectedIndex > -1;


        }
        bool insertmode = false;
        
        private void btnNewLang_Click(object sender, EventArgs e)
        {
            if(insertmode)
                if(! SaveLangs())
                    return ;
            insertmode = !insertmode;
            if (insertmode)
            {
                btnNewLang.Text = "Save";

            }
            else
            {
                btnNewLang.Text = "New";

            }
            txbxLangArgs.ReadOnly = txbxLangName.ReadOnly = txbxLangPath.ReadOnly = txbxLangVer.ReadOnly = !insertmode; 
            panel_lang_controls.Visible = !txbxLangVer.ReadOnly;
           
        }

        private void lstbxLangs_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                RykonLang r = _MainCompiler_.LanguageList[cmbxLangs.SelectedIndex];
                txbxLangName.Text = r.LangName;
                txbxLangArgs.Text = r.ProcessArgs;
                txbxLangPath.Text = r.CompilerPath;
                txbxLangVer.Text = r.LangVersion;
                lstbxExts.Items.Clear();
                foreach (string c in r.FileExts)
                    lstbxExts.Items.Add(c);
                cb_langEnabled.Checked = r.Enabled;
            }
            catch { }
        }

        private void lnk_removeExtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstbxExts.SelectedIndex > -1)
                lstbxExts.Items.RemoveAt(lstbxExts.SelectedIndex);
        }

        private void txbxRootDir_TextChanged_1(object sender, EventArgs e)
        {
            Servconf.RootDirectory = txbxRootDir.Text;
        }

        private void txbx_pass_video_TextChanged(object sender, EventArgs e)
        {
            Servconf.VideoPassword = txbx_pass_video.Text;
        }

        private void txbx_pass_Listen_TextChanged(object sender, EventArgs e)
        {
            Servconf.ListenPassword = txbx_pass_Listen.Text;
        }

        private void txbx_pass_Control_TextChanged(object sender, EventArgs e)
        {
            Servconf.ControlPassword = txbx_pass_Control.Text;
        }

        private void txbx_pass_Stream_TextChanged(object sender, EventArgs e)
        {
            Servconf.StreamPassword = txbx_pass_Stream.Text;
        }

        private void txbx_pass_Upload_TextChanged(object sender, EventArgs e)
        {
            Servconf.UploadPassword=            txbx_pass_Upload.Text;
        }

        private void cb_secure_video_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.SecureVideo =txbx_pass_video.Enabled= cb_secure_video.Checked;
        }

        private void cb_secure_listen_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.SecureListen= txbx_pass_Listen.Enabled = cb_secure_listen.Checked;

        }

        private void cb_secure_control_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.SecureControl = txbx_pass_Control.Enabled = cb_secure_control.Checked;

        }

        private void cb_secure_stream_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.SecureStream = txbx_pass_Stream.Enabled = cb_secure_stream.Checked;

        }

        private void cb_secure_upload_CheckedChanged(object sender, EventArgs e)
        {
            Servconf.SecureUpload = txbx_pass_Upload.Enabled = cb_secure_upload.Checked;

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
         
         
    }
}

