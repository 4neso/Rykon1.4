namespace RykonServer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Designer");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dynamic");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Langs");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Security");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Server", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Control");
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerWriter = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TpgMain = new System.Windows.Forms.TabPage();
            this.panelServer = new System.Windows.Forms.Panel();
            this.pcbxLoader = new System.Windows.Forms.PictureBox();
            this.gpxStreamer = new System.Windows.Forms.GroupBox();
            this.lnk_copyStreamUrl = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTestStreamer = new System.Windows.Forms.Button();
            this.textBoxUrlStreamer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBoxDir = new System.Windows.Forms.GroupBox();
            this.linkLabelOpenRootDir = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxRootDir = new System.Windows.Forms.TextBox();
            this.GpxHead = new System.Windows.Forms.GroupBox();
            this.lnk_copyUrl = new System.Windows.Forms.LinkLabel();
            this.buttonTestSelfBrowser = new System.Windows.Forms.Button();
            this.txbx_serverUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Prefixs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPort = new System.Windows.Forms.NumericUpDown();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelLogs = new System.Windows.Forms.Panel();
            this.lnkcloseLogs = new System.Windows.Forms.LinkLabel();
            this.txbxLogs = new System.Windows.Forms.RichTextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TbControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage_set_general = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.cbTestInSeparated = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_run_atstartup = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tbpage_set_Designer = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lnklnl_edit = new System.Windows.Forms.LinkLabel();
            this.rtxbx_Designer_404_index = new System.Windows.Forms.RichTextBox();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.label38 = new System.Windows.Forms.Label();
            this.tbpg_set_Server = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbpg_set_dynamic = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cb_allowdynamic = new System.Windows.Forms.CheckBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnNewLang = new System.Windows.Forms.Button();
            this.lnk_langPath_Browse = new System.Windows.Forms.LinkLabel();
            this.panel_lang_controls = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.TxbxAddExtn = new System.Windows.Forms.TextBox();
            this.lnk_ClearExtns = new System.Windows.Forms.LinkLabel();
            this.lnk_removeExtn = new System.Windows.Forms.LinkLabel();
            this.lnk_add_newExt = new System.Windows.Forms.LinkLabel();
            this.btnEditLangs = new System.Windows.Forms.Button();
            this.lstbxExts = new System.Windows.Forms.ListBox();
            this.cb_langEnabled = new System.Windows.Forms.CheckBox();
            this.txbxLangArgs = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txbxLangPath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbxLangVer = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txbxLangName = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbxLangs = new System.Windows.Forms.ComboBox();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cbSecureControl = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbxControlPasswd = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.tbpgSecurity = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cb_secure_upload = new System.Windows.Forms.CheckBox();
            this.cb_secure_stream = new System.Windows.Forms.CheckBox();
            this.cb_secure_control = new System.Windows.Forms.CheckBox();
            this.cb_secure_listen = new System.Windows.Forms.CheckBox();
            this.cb_secure_video = new System.Windows.Forms.CheckBox();
            this.txbx_pass_Upload = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txbx_pass_Stream = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txbx_pass_Control = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txbx_pass_Listen = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txbx_pass_video = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel_server_credit = new System.Windows.Forms.Panel();
            this.txbxServerPass = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.TxbxServerId = new System.Windows.Forms.TextBox();
            this.cp_private = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.lnk_close_settings = new System.Windows.Forms.LinkLabel();
            this.tabPage_streamer = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.strmlbl = new System.Windows.Forms.Label();
            this.cbswitch_streamerPreview = new System.Windows.Forms.CheckBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPageDesigner = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.tbpgBrowser = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelContaner = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox_BrowserUrl = new System.Windows.Forms.TextBox();
            this.buttonNavigate = new System.Windows.Forms.Button();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelStatue = new System.Windows.Forms.Label();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panelMenustrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadServerConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.privateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credintialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStream = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStreamOff = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrpBtnStreamOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewStreamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler_off = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsrtrp_controler_on = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offvideoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlistenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlistenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labela_l = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.cb_autoListen = new System.Windows.Forms.CheckBox();
            this.cb_showdatetime = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_showerrormessage = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbShowDiricon = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_r_a_s = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.cb_runatstartup = new System.Windows.Forms.CheckBox();
            this.TrayMenu_contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain.SuspendLayout();
            this.TpgMain.SuspendLayout();
            this.panelServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoader)).BeginInit();
            this.gpxStreamer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDir.SuspendLayout();
            this.GpxHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).BeginInit();
            this.tabPageLogs.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelLogs.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TbControlSettings.SuspendLayout();
            this.tabPage_set_general.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Tbpage_set_Designer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tbpg_set_Server.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tbpg_set_dynamic.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel_lang_controls.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tbpgSecurity.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel_server_credit.SuspendLayout();
            this.tabPage_streamer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.tabPageDesigner.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbpgBrowser.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelContaner.SuspendLayout();
            this.panelBrowser.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelcontainer.SuspendLayout();
            this.panelMenustrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Im Here";
            this.notifyIcon1.BalloonTipTitle = "Rykon !";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Rykon";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // timerWriter
            // 
            this.timerWriter.Enabled = true;
            this.timerWriter.Interval = 60000;
            this.timerWriter.Tick += new System.EventHandler(this.timerWriter_Tick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.TpgMain);
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPage_streamer);
            this.tabControlMain.Controls.Add(this.tabPageDesigner);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Controls.Add(this.tbpgBrowser);
            this.tabControlMain.Location = new System.Drawing.Point(2, 23);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(567, 250);
            this.tabControlMain.TabIndex = 9;
            // 
            // TpgMain
            // 
            this.TpgMain.Controls.Add(this.panelServer);
            this.TpgMain.Location = new System.Drawing.Point(4, 22);
            this.TpgMain.Name = "TpgMain";
            this.TpgMain.Padding = new System.Windows.Forms.Padding(3);
            this.TpgMain.Size = new System.Drawing.Size(559, 224);
            this.TpgMain.TabIndex = 0;
            this.TpgMain.Tag = "Main";
            this.TpgMain.Text = "__Main __";
            this.TpgMain.UseVisualStyleBackColor = true;
            // 
            // panelServer
            // 
            this.panelServer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelServer.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panelServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelServer.Controls.Add(this.pcbxLoader);
            this.panelServer.Controls.Add(this.gpxStreamer);
            this.panelServer.Controls.Add(this.label5);
            this.panelServer.Controls.Add(this.pictureBox1);
            this.panelServer.Controls.Add(this.btnSettings);
            this.panelServer.Controls.Add(this.groupBoxDir);
            this.panelServer.Controls.Add(this.GpxHead);
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServer.Location = new System.Drawing.Point(3, 3);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(553, 218);
            this.panelServer.TabIndex = 2;
            // 
            // pcbxLoader
            // 
            this.pcbxLoader.Image = global::RykonServer.Properties.Resources.ajax_loader;
            this.pcbxLoader.Location = new System.Drawing.Point(431, 44);
            this.pcbxLoader.Name = "pcbxLoader";
            this.pcbxLoader.Size = new System.Drawing.Size(16, 16);
            this.pcbxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbxLoader.TabIndex = 9;
            this.pcbxLoader.TabStop = false;
            this.pcbxLoader.Visible = false;
            // 
            // gpxStreamer
            // 
            this.gpxStreamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxStreamer.BackColor = System.Drawing.Color.Transparent;
            this.gpxStreamer.Controls.Add(this.lnk_copyStreamUrl);
            this.gpxStreamer.Controls.Add(this.label9);
            this.gpxStreamer.Controls.Add(this.btnTestStreamer);
            this.gpxStreamer.Controls.Add(this.textBoxUrlStreamer);
            this.gpxStreamer.Location = new System.Drawing.Point(6, 136);
            this.gpxStreamer.Name = "gpxStreamer";
            this.gpxStreamer.Size = new System.Drawing.Size(538, 40);
            this.gpxStreamer.TabIndex = 8;
            this.gpxStreamer.TabStop = false;
            this.gpxStreamer.Text = "Streamer";
            this.gpxStreamer.Enter += new System.EventHandler(this.gpxStreamer_Enter);
            // 
            // lnk_copyStreamUrl
            // 
            this.lnk_copyStreamUrl.AutoSize = true;
            this.lnk_copyStreamUrl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lnk_copyStreamUrl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnk_copyStreamUrl.Location = new System.Drawing.Point(421, 17);
            this.lnk_copyStreamUrl.Name = "lnk_copyStreamUrl";
            this.lnk_copyStreamUrl.Size = new System.Drawing.Size(39, 16);
            this.lnk_copyStreamUrl.TabIndex = 8;
            this.lnk_copyStreamUrl.TabStop = true;
            this.lnk_copyStreamUrl.Text = "Copy ";
            this.lnk_copyStreamUrl.Visible = false;
            this.lnk_copyStreamUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_copyStreamUrl_LinkClicked);
            this.lnk_copyStreamUrl.VisibleChanged += new System.EventHandler(this.lnk_copyStreamUrl_VisibleChanged);
            this.lnk_copyStreamUrl.Click += new System.EventHandler(this.lnk_copyStreamUrl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Streamer Url";
            // 
            // btnTestStreamer
            // 
            this.btnTestStreamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestStreamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(9)))));
            this.btnTestStreamer.Enabled = false;
            this.btnTestStreamer.Location = new System.Drawing.Point(424, 14);
            this.btnTestStreamer.Name = "btnTestStreamer";
            this.btnTestStreamer.Size = new System.Drawing.Size(94, 23);
            this.btnTestStreamer.TabIndex = 15;
            this.btnTestStreamer.Text = "Test";
            this.btnTestStreamer.UseVisualStyleBackColor = false;
            this.btnTestStreamer.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.btnTestStreamer.Click += new System.EventHandler(this.btnTestStreamer_Click);
            // 
            // textBoxUrlStreamer
            // 
            this.textBoxUrlStreamer.Enabled = false;
            this.textBoxUrlStreamer.Location = new System.Drawing.Point(94, 14);
            this.textBoxUrlStreamer.Name = "textBoxUrlStreamer";
            this.textBoxUrlStreamer.ReadOnly = true;
            this.textBoxUrlStreamer.Size = new System.Drawing.Size(321, 20);
            this.textBoxUrlStreamer.TabIndex = 13;
            this.textBoxUrlStreamer.TextChanged += new System.EventHandler(this.textBoxUrlStreamer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 36.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 56);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rykon Server";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RykonServer.Properties.Resources.Img;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::RykonServer.Properties.Resources.SettingsImg;
            this.btnSettings.Location = new System.Drawing.Point(424, -483);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(27, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = " ";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDir.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDir.Controls.Add(this.linkLabelOpenRootDir);
            this.groupBoxDir.Controls.Add(this.label2);
            this.groupBoxDir.Controls.Add(this.txbxRootDir);
            this.groupBoxDir.Location = new System.Drawing.Point(6, 179);
            this.groupBoxDir.Name = "groupBoxDir";
            this.groupBoxDir.Size = new System.Drawing.Size(538, 37);
            this.groupBoxDir.TabIndex = 4;
            this.groupBoxDir.TabStop = false;
            this.groupBoxDir.Text = "Directory";
            // 
            // linkLabelOpenRootDir
            // 
            this.linkLabelOpenRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelOpenRootDir.AutoSize = true;
            this.linkLabelOpenRootDir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelOpenRootDir.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelOpenRootDir.Location = new System.Drawing.Point(421, 15);
            this.linkLabelOpenRootDir.Name = "linkLabelOpenRootDir";
            this.linkLabelOpenRootDir.Size = new System.Drawing.Size(95, 16);
            this.linkLabelOpenRootDir.TabIndex = 7;
            this.linkLabelOpenRootDir.TabStop = true;
            this.linkLabelOpenRootDir.Text = "Open in explorer";
            this.linkLabelOpenRootDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenRootDir_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Main";
            // 
            // txbxRootDir
            // 
            this.txbxRootDir.Location = new System.Drawing.Point(95, 11);
            this.txbxRootDir.Name = "txbxRootDir";
            this.txbxRootDir.ReadOnly = true;
            this.txbxRootDir.Size = new System.Drawing.Size(320, 20);
            this.txbxRootDir.TabIndex = 4;
            this.txbxRootDir.TextChanged += new System.EventHandler(this.txbxRootDir_TextChanged_1);
            // 
            // GpxHead
            // 
            this.GpxHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpxHead.BackColor = System.Drawing.Color.Transparent;
            this.GpxHead.Controls.Add(this.lnk_copyUrl);
            this.GpxHead.Controls.Add(this.buttonTestSelfBrowser);
            this.GpxHead.Controls.Add(this.txbx_serverUrl);
            this.GpxHead.Controls.Add(this.label4);
            this.GpxHead.Controls.Add(this.cb_Prefixs);
            this.GpxHead.Controls.Add(this.label3);
            this.GpxHead.Controls.Add(this.label1);
            this.GpxHead.Controls.Add(this.NumPort);
            this.GpxHead.Controls.Add(this.btnSwitch);
            this.GpxHead.Location = new System.Drawing.Point(6, 66);
            this.GpxHead.Name = "GpxHead";
            this.GpxHead.Size = new System.Drawing.Size(538, 70);
            this.GpxHead.TabIndex = 2;
            this.GpxHead.TabStop = false;
            this.GpxHead.Text = "Server Control";
            // 
            // lnk_copyUrl
            // 
            this.lnk_copyUrl.AutoSize = true;
            this.lnk_copyUrl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_copyUrl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnk_copyUrl.Location = new System.Drawing.Point(421, 43);
            this.lnk_copyUrl.Name = "lnk_copyUrl";
            this.lnk_copyUrl.Size = new System.Drawing.Size(36, 16);
            this.lnk_copyUrl.TabIndex = 12;
            this.lnk_copyUrl.TabStop = true;
            this.lnk_copyUrl.Text = "Copy";
            this.lnk_copyUrl.Visible = false;
            this.lnk_copyUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_copyUrl_LinkClicked);
            this.lnk_copyUrl.VisibleChanged += new System.EventHandler(this.lnk_copyUrl_VisibleChanged);
            // 
            // buttonTestSelfBrowser
            // 
            this.buttonTestSelfBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestSelfBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(9)))));
            this.buttonTestSelfBrowser.Location = new System.Drawing.Point(424, 38);
            this.buttonTestSelfBrowser.Name = "buttonTestSelfBrowser";
            this.buttonTestSelfBrowser.Size = new System.Drawing.Size(94, 23);
            this.buttonTestSelfBrowser.TabIndex = 11;
            this.buttonTestSelfBrowser.Text = "Test";
            this.buttonTestSelfBrowser.UseVisualStyleBackColor = false;
            this.buttonTestSelfBrowser.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.buttonTestSelfBrowser.Click += new System.EventHandler(this.buttonTestSelfBrowser_Click);
            // 
            // txbx_serverUrl
            // 
            this.txbx_serverUrl.Enabled = false;
            this.txbx_serverUrl.Location = new System.Drawing.Point(95, 41);
            this.txbx_serverUrl.Name = "txbx_serverUrl";
            this.txbx_serverUrl.ReadOnly = true;
            this.txbx_serverUrl.Size = new System.Drawing.Size(320, 20);
            this.txbx_serverUrl.TabIndex = 9;
            this.txbx_serverUrl.TextChanged += new System.EventHandler(this.txbxUrl_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Url";
            // 
            // cb_Prefixs
            // 
            this.cb_Prefixs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prefixs.FormattingEnabled = true;
            this.cb_Prefixs.Location = new System.Drawing.Point(95, 14);
            this.cb_Prefixs.Name = "cb_Prefixs";
            this.cb_Prefixs.Size = new System.Drawing.Size(206, 21);
            this.cb_Prefixs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prefix";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // NumPort
            // 
            this.NumPort.Location = new System.Drawing.Point(339, 14);
            this.NumPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPort.Name = "NumPort";
            this.NumPort.Size = new System.Drawing.Size(76, 20);
            this.NumPort.TabIndex = 1;
            this.NumPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            this.NumPort.ValueChanged += new System.EventHandler(this.NumPort_ValueChanged);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(111)))), ((int)(((byte)(9)))));
            this.btnSwitch.Location = new System.Drawing.Point(424, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(96, 23);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Start";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.EnabledChanged += new System.EventHandler(this.btnSwitch_EnabledChanged);
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageLogs.Controls.Add(this.panel2);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(559, 224);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Tag = "Logs";
            this.tabPageLogs.Text = "Logs";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel2.Controls.Add(this.PanelLogs);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 240);
            this.panel2.TabIndex = 0;
            // 
            // PanelLogs
            // 
            this.PanelLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogs.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogs.Controls.Add(this.lnkcloseLogs);
            this.PanelLogs.Controls.Add(this.txbxLogs);
            this.PanelLogs.Location = new System.Drawing.Point(3, -1);
            this.PanelLogs.Name = "PanelLogs";
            this.PanelLogs.Size = new System.Drawing.Size(546, 238);
            this.PanelLogs.TabIndex = 4;
            this.PanelLogs.Text = "Logs";
            // 
            // lnkcloseLogs
            // 
            this.lnkcloseLogs.AutoSize = true;
            this.lnkcloseLogs.LinkColor = System.Drawing.Color.Red;
            this.lnkcloseLogs.Location = new System.Drawing.Point(527, 7);
            this.lnkcloseLogs.Name = "lnkcloseLogs";
            this.lnkcloseLogs.Size = new System.Drawing.Size(14, 13);
            this.lnkcloseLogs.TabIndex = 1;
            this.lnkcloseLogs.TabStop = true;
            this.lnkcloseLogs.Text = "X";
            this.lnkcloseLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkcloseLogs_LinkClicked);
            // 
            // txbxLogs
            // 
            this.txbxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLogs.Location = new System.Drawing.Point(4, 19);
            this.txbxLogs.Name = "txbxLogs";
            this.txbxLogs.Size = new System.Drawing.Size(536, 213);
            this.txbxLogs.TabIndex = 0;
            this.txbxLogs.Text = "";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panel1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(559, 224);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.TbControlSettings);
            this.panel1.Controls.Add(this.lnk_close_settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 218);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(0, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Tag = "0";
            treeNode1.Text = "General";
            treeNode2.Name = "Node2";
            treeNode2.Tag = "1";
            treeNode2.Text = "Designer";
            treeNode3.Name = "Node3";
            treeNode3.Tag = "3";
            treeNode3.Text = "Dynamic";
            treeNode4.Name = "Node4";
            treeNode4.Tag = "4";
            treeNode4.Text = "Langs";
            treeNode5.Name = "Node1";
            treeNode5.Tag = "6";
            treeNode5.Text = "Security";
            treeNode6.Name = "Node1";
            treeNode6.Tag = "2";
            treeNode6.Text = "Server";
            treeNode7.Name = "Node1";
            treeNode7.Tag = "5";
            treeNode7.Text = "Control";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(86, 216);
            this.treeView1.TabIndex = 12;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // TbControlSettings
            // 
            this.TbControlSettings.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TbControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbControlSettings.Controls.Add(this.tabPage_set_general);
            this.TbControlSettings.Controls.Add(this.Tbpage_set_Designer);
            this.TbControlSettings.Controls.Add(this.tbpg_set_Server);
            this.TbControlSettings.Controls.Add(this.tbpg_set_dynamic);
            this.TbControlSettings.Controls.Add(this.tabPage1);
            this.TbControlSettings.Controls.Add(this.tabPage2);
            this.TbControlSettings.Controls.Add(this.tbpgSecurity);
            this.TbControlSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TbControlSettings.Location = new System.Drawing.Point(85, 2);
            this.TbControlSettings.Multiline = true;
            this.TbControlSettings.Name = "TbControlSettings";
            this.TbControlSettings.SelectedIndex = 0;
            this.TbControlSettings.Size = new System.Drawing.Size(470, 213);
            this.TbControlSettings.TabIndex = 3;
            // 
            // tabPage_set_general
            // 
            this.tabPage_set_general.Controls.Add(this.panel7);
            this.tabPage_set_general.Location = new System.Drawing.Point(4, 4);
            this.tabPage_set_general.Name = "tabPage_set_general";
            this.tabPage_set_general.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_set_general.Size = new System.Drawing.Size(462, 187);
            this.tabPage_set_general.TabIndex = 0;
            this.tabPage_set_general.Text = "General";
            this.tabPage_set_general.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel7.Controls.Add(this.label35);
            this.panel7.Controls.Add(this.cbTestInSeparated);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.cb_run_atstartup);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 181);
            this.panel7.TabIndex = 3;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 47);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Test In Separate Form";
            // 
            // cbTestInSeparated
            // 
            this.cbTestInSeparated.AutoSize = true;
            this.cbTestInSeparated.Location = new System.Drawing.Point(130, 46);
            this.cbTestInSeparated.Name = "cbTestInSeparated";
            this.cbTestInSeparated.Size = new System.Drawing.Size(15, 14);
            this.cbTestInSeparated.TabIndex = 6;
            this.cbTestInSeparated.UseVisualStyleBackColor = true;
            this.cbTestInSeparated.CheckedChanged += new System.EventHandler(this.cbTestInSeparated_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(12, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Root Directory";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Run at start up";
            // 
            // cb_run_atstartup
            // 
            this.cb_run_atstartup.AutoSize = true;
            this.cb_run_atstartup.Location = new System.Drawing.Point(130, 3);
            this.cb_run_atstartup.Name = "cb_run_atstartup";
            this.cb_run_atstartup.Size = new System.Drawing.Size(15, 14);
            this.cb_run_atstartup.TabIndex = 1;
            this.cb_run_atstartup.UseVisualStyleBackColor = true;
            this.cb_run_atstartup.CheckedChanged += new System.EventHandler(this.cb_run_atstartup_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 0;
            // 
            // Tbpage_set_Designer
            // 
            this.Tbpage_set_Designer.Controls.Add(this.panel10);
            this.Tbpage_set_Designer.Location = new System.Drawing.Point(4, 4);
            this.Tbpage_set_Designer.Name = "Tbpage_set_Designer";
            this.Tbpage_set_Designer.Padding = new System.Windows.Forms.Padding(3);
            this.Tbpage_set_Designer.Size = new System.Drawing.Size(462, 187);
            this.Tbpage_set_Designer.TabIndex = 3;
            this.Tbpage_set_Designer.Text = "Designer";
            this.Tbpage_set_Designer.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel10.Controls.Add(this.lnklnl_edit);
            this.panel10.Controls.Add(this.rtxbx_Designer_404_index);
            this.panel10.Controls.Add(this.linkLabel9);
            this.panel10.Controls.Add(this.label38);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(456, 181);
            this.panel10.TabIndex = 3;
            // 
            // lnklnl_edit
            // 
            this.lnklnl_edit.AutoSize = true;
            this.lnklnl_edit.Location = new System.Drawing.Point(426, 81);
            this.lnklnl_edit.Name = "lnklnl_edit";
            this.lnklnl_edit.Size = new System.Drawing.Size(25, 13);
            this.lnklnl_edit.TabIndex = 4;
            this.lnklnl_edit.TabStop = true;
            this.lnklnl_edit.Text = "Edit";
            // 
            // rtxbx_Designer_404_index
            // 
            this.rtxbx_Designer_404_index.Location = new System.Drawing.Point(5, 22);
            this.rtxbx_Designer_404_index.Name = "rtxbx_Designer_404_index";
            this.rtxbx_Designer_404_index.Size = new System.Drawing.Size(443, 54);
            this.rtxbx_Designer_404_index.TabIndex = 3;
            this.rtxbx_Designer_404_index.Text = resources.GetString("rtxbx_Designer_404_index.Text");
            // 
            // linkLabel9
            // 
            this.linkLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.LinkColor = System.Drawing.Color.Red;
            this.linkLabel9.Location = new System.Drawing.Point(568, 4);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(14, 13);
            this.linkLabel9.TabIndex = 2;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "X";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(11, 6);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Not Found Index";
            // 
            // tbpg_set_Server
            // 
            this.tbpg_set_Server.Controls.Add(this.panel9);
            this.tbpg_set_Server.Location = new System.Drawing.Point(4, 4);
            this.tbpg_set_Server.Name = "tbpg_set_Server";
            this.tbpg_set_Server.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_set_Server.Size = new System.Drawing.Size(462, 187);
            this.tbpg_set_Server.TabIndex = 1;
            this.tbpg_set_Server.Text = "Server";
            this.tbpg_set_Server.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.checkBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(456, 181);
            this.panel9.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Auto Listen";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(92, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbpg_set_dynamic
            // 
            this.tbpg_set_dynamic.Controls.Add(this.panel8);
            this.tbpg_set_dynamic.Location = new System.Drawing.Point(4, 4);
            this.tbpg_set_dynamic.Name = "tbpg_set_dynamic";
            this.tbpg_set_dynamic.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_set_dynamic.Size = new System.Drawing.Size(462, 187);
            this.tbpg_set_dynamic.TabIndex = 4;
            this.tbpg_set_dynamic.Text = "Dynamic";
            this.tbpg_set_dynamic.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel8.Controls.Add(this.cb_allowdynamic);
            this.panel8.Controls.Add(this.linkLabel7);
            this.panel8.Controls.Add(this.label34);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(456, 181);
            this.panel8.TabIndex = 3;
            // 
            // cb_allowdynamic
            // 
            this.cb_allowdynamic.AutoSize = true;
            this.cb_allowdynamic.Location = new System.Drawing.Point(149, 13);
            this.cb_allowdynamic.Name = "cb_allowdynamic";
            this.cb_allowdynamic.Size = new System.Drawing.Size(15, 14);
            this.cb_allowdynamic.TabIndex = 3;
            this.cb_allowdynamic.UseVisualStyleBackColor = true;
            // 
            // linkLabel7
            // 
            this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkColor = System.Drawing.Color.Red;
            this.linkLabel7.Location = new System.Drawing.Point(439, 4);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(14, 13);
            this.linkLabel7.TabIndex = 2;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "X";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(18, 13);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Allow Dynamic Pages";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel11);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 187);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Langs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel11.Controls.Add(this.btnNewLang);
            this.panel11.Controls.Add(this.lnk_langPath_Browse);
            this.panel11.Controls.Add(this.panel_lang_controls);
            this.panel11.Controls.Add(this.btnEditLangs);
            this.panel11.Controls.Add(this.lstbxExts);
            this.panel11.Controls.Add(this.cb_langEnabled);
            this.panel11.Controls.Add(this.txbxLangArgs);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Controls.Add(this.txbxLangPath);
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.txbxLangVer);
            this.panel11.Controls.Add(this.label39);
            this.panel11.Controls.Add(this.txbxLangName);
            this.panel11.Controls.Add(this.label40);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.cmbxLangs);
            this.panel11.Controls.Add(this.linkLabel10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(456, 181);
            this.panel11.TabIndex = 3;
            // 
            // btnNewLang
            // 
            this.btnNewLang.Location = new System.Drawing.Point(394, 157);
            this.btnNewLang.Name = "btnNewLang";
            this.btnNewLang.Size = new System.Drawing.Size(56, 21);
            this.btnNewLang.TabIndex = 26;
            this.btnNewLang.Text = "New";
            this.btnNewLang.UseVisualStyleBackColor = true;
            this.btnNewLang.Click += new System.EventHandler(this.btnNewLang_Click);
            // 
            // lnk_langPath_Browse
            // 
            this.lnk_langPath_Browse.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnk_langPath_Browse.AutoSize = true;
            this.lnk_langPath_Browse.LinkColor = System.Drawing.Color.Black;
            this.lnk_langPath_Browse.Location = new System.Drawing.Point(303, 117);
            this.lnk_langPath_Browse.Name = "lnk_langPath_Browse";
            this.lnk_langPath_Browse.Size = new System.Drawing.Size(42, 13);
            this.lnk_langPath_Browse.TabIndex = 25;
            this.lnk_langPath_Browse.TabStop = true;
            this.lnk_langPath_Browse.Text = "Browse";
            this.lnk_langPath_Browse.Visible = false;
            this.lnk_langPath_Browse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_langPath_Browse_LinkClicked);
            // 
            // panel_lang_controls
            // 
            this.panel_lang_controls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_lang_controls.Controls.Add(this.label41);
            this.panel_lang_controls.Controls.Add(this.TxbxAddExtn);
            this.panel_lang_controls.Controls.Add(this.lnk_ClearExtns);
            this.panel_lang_controls.Controls.Add(this.lnk_removeExtn);
            this.panel_lang_controls.Controls.Add(this.lnk_add_newExt);
            this.panel_lang_controls.Location = new System.Drawing.Point(401, 20);
            this.panel_lang_controls.Name = "panel_lang_controls";
            this.panel_lang_controls.Size = new System.Drawing.Size(50, 133);
            this.panel_lang_controls.TabIndex = 21;
            this.panel_lang_controls.Visible = false;
            this.panel_lang_controls.VisibleChanged += new System.EventHandler(this.panel_lang_controls_VisibleChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(8, 2);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(22, 13);
            this.label41.TabIndex = 27;
            this.label41.Text = "Ext";
            // 
            // TxbxAddExtn
            // 
            this.TxbxAddExtn.BackColor = System.Drawing.Color.DarkOrange;
            this.TxbxAddExtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbxAddExtn.Location = new System.Drawing.Point(5, 20);
            this.TxbxAddExtn.Name = "TxbxAddExtn";
            this.TxbxAddExtn.Size = new System.Drawing.Size(40, 13);
            this.TxbxAddExtn.TabIndex = 22;
            this.TxbxAddExtn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lnk_ClearExtns
            // 
            this.lnk_ClearExtns.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnk_ClearExtns.AutoSize = true;
            this.lnk_ClearExtns.LinkColor = System.Drawing.Color.Black;
            this.lnk_ClearExtns.Location = new System.Drawing.Point(10, 82);
            this.lnk_ClearExtns.Name = "lnk_ClearExtns";
            this.lnk_ClearExtns.Size = new System.Drawing.Size(31, 13);
            this.lnk_ClearExtns.TabIndex = 24;
            this.lnk_ClearExtns.TabStop = true;
            this.lnk_ClearExtns.Text = "Clear";
            this.lnk_ClearExtns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ClearExtns_LinkClicked);
            // 
            // lnk_removeExtn
            // 
            this.lnk_removeExtn.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnk_removeExtn.AutoSize = true;
            this.lnk_removeExtn.LinkColor = System.Drawing.Color.Black;
            this.lnk_removeExtn.Location = new System.Drawing.Point(2, 58);
            this.lnk_removeExtn.Name = "lnk_removeExtn";
            this.lnk_removeExtn.Size = new System.Drawing.Size(47, 13);
            this.lnk_removeExtn.TabIndex = 23;
            this.lnk_removeExtn.TabStop = true;
            this.lnk_removeExtn.Text = "Remove";
            this.lnk_removeExtn.Visible = false;
            this.lnk_removeExtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_removeExtn_LinkClicked);
            // 
            // lnk_add_newExt
            // 
            this.lnk_add_newExt.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnk_add_newExt.AutoSize = true;
            this.lnk_add_newExt.LinkColor = System.Drawing.Color.Black;
            this.lnk_add_newExt.Location = new System.Drawing.Point(10, 36);
            this.lnk_add_newExt.Name = "lnk_add_newExt";
            this.lnk_add_newExt.Size = new System.Drawing.Size(26, 13);
            this.lnk_add_newExt.TabIndex = 22;
            this.lnk_add_newExt.TabStop = true;
            this.lnk_add_newExt.Text = "Add";
            this.lnk_add_newExt.Visible = false;
            this.lnk_add_newExt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_add_newExt_LinkClicked);
            // 
            // btnEditLangs
            // 
            this.btnEditLangs.Location = new System.Drawing.Point(262, 157);
            this.btnEditLangs.Name = "btnEditLangs";
            this.btnEditLangs.Size = new System.Drawing.Size(75, 20);
            this.btnEditLangs.TabIndex = 20;
            this.btnEditLangs.Text = "Edit";
            this.btnEditLangs.UseVisualStyleBackColor = true;
            this.btnEditLangs.Visible = false;
            this.btnEditLangs.Click += new System.EventHandler(this.btnEditLang_Click);
            // 
            // lstbxExts
            // 
            this.lstbxExts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxExts.FormattingEnabled = true;
            this.lstbxExts.Location = new System.Drawing.Point(350, 19);
            this.lstbxExts.Name = "lstbxExts";
            this.lstbxExts.Size = new System.Drawing.Size(46, 134);
            this.lstbxExts.TabIndex = 19;
            this.lstbxExts.SelectedIndexChanged += new System.EventHandler(this.lstbxExts_SelectedIndexChanged);
            // 
            // cb_langEnabled
            // 
            this.cb_langEnabled.AutoSize = true;
            this.cb_langEnabled.Enabled = false;
            this.cb_langEnabled.Location = new System.Drawing.Point(191, 159);
            this.cb_langEnabled.Name = "cb_langEnabled";
            this.cb_langEnabled.Size = new System.Drawing.Size(65, 17);
            this.cb_langEnabled.TabIndex = 18;
            this.cb_langEnabled.Text = "Enabled";
            this.cb_langEnabled.UseVisualStyleBackColor = true;
            this.cb_langEnabled.Visible = false;
            // 
            // txbxLangArgs
            // 
            this.txbxLangArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLangArgs.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangArgs.Location = new System.Drawing.Point(93, 140);
            this.txbxLangArgs.Name = "txbxLangArgs";
            this.txbxLangArgs.ReadOnly = true;
            this.txbxLangArgs.Size = new System.Drawing.Size(253, 13);
            this.txbxLangArgs.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Arguments";
            // 
            // txbxLangPath
            // 
            this.txbxLangPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLangPath.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangPath.Location = new System.Drawing.Point(93, 100);
            this.txbxLangPath.Name = "txbxLangPath";
            this.txbxLangPath.ReadOnly = true;
            this.txbxLangPath.Size = new System.Drawing.Size(253, 13);
            this.txbxLangPath.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Path";
            // 
            // txbxLangVer
            // 
            this.txbxLangVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLangVer.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangVer.Location = new System.Drawing.Point(93, 77);
            this.txbxLangVer.Name = "txbxLangVer";
            this.txbxLangVer.ReadOnly = true;
            this.txbxLangVer.Size = new System.Drawing.Size(253, 13);
            this.txbxLangVer.TabIndex = 13;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 13);
            this.label39.TabIndex = 12;
            this.label39.Text = "Version";
            // 
            // txbxLangName
            // 
            this.txbxLangName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLangName.BackColor = System.Drawing.Color.DarkOrange;
            this.txbxLangName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxLangName.Location = new System.Drawing.Point(93, 48);
            this.txbxLangName.Name = "txbxLangName";
            this.txbxLangName.ReadOnly = true;
            this.txbxLangName.Size = new System.Drawing.Size(253, 13);
            this.txbxLangName.TabIndex = 11;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(15, 44);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 13);
            this.label40.TabIndex = 10;
            this.label40.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Languages";
            // 
            // cmbxLangs
            // 
            this.cmbxLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLangs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxLangs.FormattingEnabled = true;
            this.cmbxLangs.Location = new System.Drawing.Point(93, 11);
            this.cmbxLangs.Name = "cmbxLangs";
            this.cmbxLangs.Size = new System.Drawing.Size(251, 21);
            this.cmbxLangs.TabIndex = 3;
            this.cmbxLangs.SelectedIndexChanged += new System.EventHandler(this.lstbxLangs_SelectedIndexChanged);
            this.cmbxLangs.SelectedValueChanged += new System.EventHandler(this.lstbxLangs_SelectedValueChanged);
            // 
            // linkLabel10
            // 
            this.linkLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.LinkColor = System.Drawing.Color.Red;
            this.linkLabel10.Location = new System.Drawing.Point(439, 4);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(14, 13);
            this.linkLabel10.TabIndex = 2;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 187);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel15.Controls.Add(this.cbSecureControl);
            this.panel15.Controls.Add(this.label14);
            this.panel15.Controls.Add(this.txbxControlPasswd);
            this.panel15.Controls.Add(this.label21);
            this.panel15.Controls.Add(this.linkLabel14);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(456, 181);
            this.panel15.TabIndex = 4;
            // 
            // cbSecureControl
            // 
            this.cbSecureControl.AutoSize = true;
            this.cbSecureControl.Location = new System.Drawing.Point(116, 14);
            this.cbSecureControl.Name = "cbSecureControl";
            this.cbSecureControl.Size = new System.Drawing.Size(15, 14);
            this.cbSecureControl.TabIndex = 9;
            this.cbSecureControl.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Password";
            // 
            // txbxControlPasswd
            // 
            this.txbxControlPasswd.Location = new System.Drawing.Point(241, 7);
            this.txbxControlPasswd.Name = "txbxControlPasswd";
            this.txbxControlPasswd.Size = new System.Drawing.Size(100, 20);
            this.txbxControlPasswd.TabIndex = 7;
            this.txbxControlPasswd.Text = "1234";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Secure Control";
            // 
            // linkLabel14
            // 
            this.linkLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.LinkColor = System.Drawing.Color.Red;
            this.linkLabel14.Location = new System.Drawing.Point(439, 4);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(14, 13);
            this.linkLabel14.TabIndex = 2;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "X";
            // 
            // tbpgSecurity
            // 
            this.tbpgSecurity.Controls.Add(this.panel16);
            this.tbpgSecurity.Location = new System.Drawing.Point(4, 4);
            this.tbpgSecurity.Name = "tbpgSecurity";
            this.tbpgSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSecurity.Size = new System.Drawing.Size(462, 187);
            this.tbpgSecurity.TabIndex = 7;
            this.tbpgSecurity.Text = "Security";
            this.tbpgSecurity.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel16.Controls.Add(this.cb_secure_upload);
            this.panel16.Controls.Add(this.cb_secure_stream);
            this.panel16.Controls.Add(this.cb_secure_control);
            this.panel16.Controls.Add(this.cb_secure_listen);
            this.panel16.Controls.Add(this.cb_secure_video);
            this.panel16.Controls.Add(this.txbx_pass_Upload);
            this.panel16.Controls.Add(this.label46);
            this.panel16.Controls.Add(this.txbx_pass_Stream);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Controls.Add(this.txbx_pass_Control);
            this.panel16.Controls.Add(this.label44);
            this.panel16.Controls.Add(this.txbx_pass_Listen);
            this.panel16.Controls.Add(this.label43);
            this.panel16.Controls.Add(this.txbx_pass_video);
            this.panel16.Controls.Add(this.label42);
            this.panel16.Controls.Add(this.panel_server_credit);
            this.panel16.Controls.Add(this.cp_private);
            this.panel16.Controls.Add(this.label27);
            this.panel16.Controls.Add(this.linkLabel15);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(456, 181);
            this.panel16.TabIndex = 4;
            // 
            // cb_secure_upload
            // 
            this.cb_secure_upload.AutoSize = true;
            this.cb_secure_upload.Location = new System.Drawing.Point(91, 152);
            this.cb_secure_upload.Name = "cb_secure_upload";
            this.cb_secure_upload.Size = new System.Drawing.Size(15, 14);
            this.cb_secure_upload.TabIndex = 28;
            this.cb_secure_upload.UseVisualStyleBackColor = true;
            this.cb_secure_upload.CheckedChanged += new System.EventHandler(this.cb_secure_upload_CheckedChanged);
            // 
            // cb_secure_stream
            // 
            this.cb_secure_stream.AutoSize = true;
            this.cb_secure_stream.Location = new System.Drawing.Point(91, 128);
            this.cb_secure_stream.Name = "cb_secure_stream";
            this.cb_secure_stream.Size = new System.Drawing.Size(15, 14);
            this.cb_secure_stream.TabIndex = 27;
            this.cb_secure_stream.UseVisualStyleBackColor = true;
            this.cb_secure_stream.CheckedChanged += new System.EventHandler(this.cb_secure_stream_CheckedChanged);
            // 
            // cb_secure_control
            // 
            this.cb_secure_control.AutoSize = true;
            this.cb_secure_control.Location = new System.Drawing.Point(91, 102);
            this.cb_secure_control.Name = "cb_secure_control";
            this.cb_secure_control.Size = new System.Drawing.Size(15, 14);
            this.cb_secure_control.TabIndex = 26;
            this.cb_secure_control.UseVisualStyleBackColor = true;
            this.cb_secure_control.CheckedChanged += new System.EventHandler(this.cb_secure_control_CheckedChanged);
            // 
            // cb_secure_listen
            // 
            this.cb_secure_listen.AutoSize = true;
            this.cb_secure_listen.Location = new System.Drawing.Point(91, 75);
            this.cb_secure_listen.Name = "cb_secure_listen";
            this.cb_secure_listen.Size = new System.Drawing.Size(15, 14);
            this.cb_secure_listen.TabIndex = 25;
            this.cb_secure_listen.UseVisualStyleBackColor = true;
            this.cb_secure_listen.CheckedChanged += new System.EventHandler(this.cb_secure_listen_CheckedChanged);
            // 
            // cb_secure_video
            // 
            this.cb_secure_video.AutoSize = true;
            this.cb_secure_video.Location = new System.Drawing.Point(91, 50);
            this.cb_secure_video.Name = "cb_secure_video";
            this.cb_secure_video.Size = new System.Drawing.Size(15, 14);
            this.cb_secure_video.TabIndex = 24;
            this.cb_secure_video.UseVisualStyleBackColor = true;
            this.cb_secure_video.CheckedChanged += new System.EventHandler(this.cb_secure_video_CheckedChanged);
            // 
            // txbx_pass_Upload
            // 
            this.txbx_pass_Upload.Enabled = false;
            this.txbx_pass_Upload.Location = new System.Drawing.Point(148, 146);
            this.txbx_pass_Upload.Name = "txbx_pass_Upload";
            this.txbx_pass_Upload.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass_Upload.TabIndex = 23;
            this.txbx_pass_Upload.TextChanged += new System.EventHandler(this.txbx_pass_Upload_TextChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(5, 154);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(78, 13);
            this.label46.TabIndex = 22;
            this.label46.Text = "Secure Upload";
            // 
            // txbx_pass_Stream
            // 
            this.txbx_pass_Stream.Enabled = false;
            this.txbx_pass_Stream.Location = new System.Drawing.Point(148, 120);
            this.txbx_pass_Stream.Name = "txbx_pass_Stream";
            this.txbx_pass_Stream.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass_Stream.TabIndex = 21;
            this.txbx_pass_Stream.TextChanged += new System.EventHandler(this.txbx_pass_Stream_TextChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(5, 128);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(77, 13);
            this.label45.TabIndex = 20;
            this.label45.Text = "Secure Stream";
            // 
            // txbx_pass_Control
            // 
            this.txbx_pass_Control.Enabled = false;
            this.txbx_pass_Control.Location = new System.Drawing.Point(148, 94);
            this.txbx_pass_Control.Name = "txbx_pass_Control";
            this.txbx_pass_Control.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass_Control.TabIndex = 19;
            this.txbx_pass_Control.TextChanged += new System.EventHandler(this.txbx_pass_Control_TextChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(5, 102);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(77, 13);
            this.label44.TabIndex = 18;
            this.label44.Text = "Secure Control";
            // 
            // txbx_pass_Listen
            // 
            this.txbx_pass_Listen.Enabled = false;
            this.txbx_pass_Listen.Location = new System.Drawing.Point(148, 68);
            this.txbx_pass_Listen.Name = "txbx_pass_Listen";
            this.txbx_pass_Listen.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass_Listen.TabIndex = 17;
            this.txbx_pass_Listen.TextChanged += new System.EventHandler(this.txbx_pass_Listen_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(5, 76);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(72, 13);
            this.label43.TabIndex = 16;
            this.label43.Text = "Secure Listen";
            // 
            // txbx_pass_video
            // 
            this.txbx_pass_video.Enabled = false;
            this.txbx_pass_video.Location = new System.Drawing.Point(148, 42);
            this.txbx_pass_video.Name = "txbx_pass_video";
            this.txbx_pass_video.Size = new System.Drawing.Size(149, 20);
            this.txbx_pass_video.TabIndex = 15;
            this.txbx_pass_video.TextChanged += new System.EventHandler(this.txbx_pass_video_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(5, 50);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 13);
            this.label42.TabIndex = 14;
            this.label42.Text = "Secure Video";
            // 
            // panel_server_credit
            // 
            this.panel_server_credit.Controls.Add(this.txbxServerPass);
            this.panel_server_credit.Controls.Add(this.label31);
            this.panel_server_credit.Controls.Add(this.label33);
            this.panel_server_credit.Controls.Add(this.TxbxServerId);
            this.panel_server_credit.Enabled = false;
            this.panel_server_credit.Location = new System.Drawing.Point(124, 6);
            this.panel_server_credit.Name = "panel_server_credit";
            this.panel_server_credit.Size = new System.Drawing.Size(328, 28);
            this.panel_server_credit.TabIndex = 13;
            // 
            // txbxServerPass
            // 
            this.txbxServerPass.Location = new System.Drawing.Point(219, 3);
            this.txbxServerPass.Name = "txbxServerPass";
            this.txbxServerPass.Size = new System.Drawing.Size(100, 20);
            this.txbxServerPass.TabIndex = 10;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Id";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(183, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Pass";
            // 
            // TxbxServerId
            // 
            this.TxbxServerId.Location = new System.Drawing.Point(25, 4);
            this.TxbxServerId.Name = "TxbxServerId";
            this.TxbxServerId.Size = new System.Drawing.Size(152, 20);
            this.TxbxServerId.TabIndex = 9;
            // 
            // cp_private
            // 
            this.cp_private.AutoSize = true;
            this.cp_private.Location = new System.Drawing.Point(91, 11);
            this.cp_private.Name = "cp_private";
            this.cp_private.Size = new System.Drawing.Size(15, 14);
            this.cp_private.TabIndex = 12;
            this.cp_private.UseVisualStyleBackColor = true;
            this.cp_private.CheckedChanged += new System.EventHandler(this.cp_private_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "Protect Access";
            // 
            // linkLabel15
            // 
            this.linkLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.LinkColor = System.Drawing.Color.Red;
            this.linkLabel15.Location = new System.Drawing.Point(439, 4);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(14, 13);
            this.linkLabel15.TabIndex = 2;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "X";
            // 
            // lnk_close_settings
            // 
            this.lnk_close_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_close_settings.AutoSize = true;
            this.lnk_close_settings.LinkColor = System.Drawing.Color.Red;
            this.lnk_close_settings.Location = new System.Drawing.Point(536, 4);
            this.lnk_close_settings.Name = "lnk_close_settings";
            this.lnk_close_settings.Size = new System.Drawing.Size(14, 13);
            this.lnk_close_settings.TabIndex = 2;
            this.lnk_close_settings.TabStop = true;
            this.lnk_close_settings.Text = "X";
            this.lnk_close_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_Tab);
            // 
            // tabPage_streamer
            // 
            this.tabPage_streamer.Controls.Add(this.panel3);
            this.tabPage_streamer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_streamer.Name = "tabPage_streamer";
            this.tabPage_streamer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_streamer.Size = new System.Drawing.Size(559, 224);
            this.tabPage_streamer.TabIndex = 3;
            this.tabPage_streamer.Text = "streamer";
            this.tabPage_streamer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel3.Controls.Add(this.strmlbl);
            this.panel3.Controls.Add(this.cbswitch_streamerPreview);
            this.panel3.Controls.Add(this.imgPreview);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 218);
            this.panel3.TabIndex = 1;
            // 
            // strmlbl
            // 
            this.strmlbl.AutoSize = true;
            this.strmlbl.Location = new System.Drawing.Point(5, 20);
            this.strmlbl.Name = "strmlbl";
            this.strmlbl.Size = new System.Drawing.Size(41, 13);
            this.strmlbl.TabIndex = 5;
            this.strmlbl.Text = "label14";
            // 
            // cbswitch_streamerPreview
            // 
            this.cbswitch_streamerPreview.AutoSize = true;
            this.cbswitch_streamerPreview.Checked = true;
            this.cbswitch_streamerPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbswitch_streamerPreview.Location = new System.Drawing.Point(456, 20);
            this.cbswitch_streamerPreview.Name = "cbswitch_streamerPreview";
            this.cbswitch_streamerPreview.Size = new System.Drawing.Size(94, 17);
            this.cbswitch_streamerPreview.TabIndex = 4;
            this.cbswitch_streamerPreview.Text = "View Streamer";
            this.cbswitch_streamerPreview.UseVisualStyleBackColor = true;
            this.cbswitch_streamerPreview.CheckedChanged += new System.EventHandler(this.cbswitch_streamerPreview_CheckedChanged);
            // 
            // imgPreview
            // 
            this.imgPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPreview.Location = new System.Drawing.Point(4, 43);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(544, 172);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(536, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_Tab);
            // 
            // tabPageDesigner
            // 
            this.tabPageDesigner.Controls.Add(this.panel5);
            this.tabPageDesigner.Location = new System.Drawing.Point(4, 22);
            this.tabPageDesigner.Name = "tabPageDesigner";
            this.tabPageDesigner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesigner.Size = new System.Drawing.Size(559, 224);
            this.tabPageDesigner.TabIndex = 5;
            this.tabPageDesigner.Text = "Design Editor";
            this.tabPageDesigner.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel5.Controls.Add(this.linkLabel3);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 218);
            this.panel5.TabIndex = 2;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(536, 4);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(14, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "X";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_Tab);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "label6";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "label6";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label24.Location = new System.Drawing.Point(81, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(310, 44);
            this.label24.TabIndex = 0;
            this.label24.Text = "Not implemented";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "label6";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "label26";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.panel6);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(559, 224);
            this.tabPageAbout.TabIndex = 6;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.linkLabel5);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.linkLabel4);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(553, 218);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RykonServer.Properties.Resources._17496578;
            this.pictureBox2.Location = new System.Drawing.Point(17, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel5.Location = new System.Drawing.Point(471, 225);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(54, 13);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Visit Page";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(132, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 163);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Location = new System.Drawing.Point(536, 4);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(14, 13);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "X";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_Tab);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label29.Location = new System.Drawing.Point(178, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(347, 44);
            this.label29.TabIndex = 0;
            this.label29.Text = "Under Construction";
            // 
            // tbpgBrowser
            // 
            this.tbpgBrowser.Controls.Add(this.panel12);
            this.tbpgBrowser.Location = new System.Drawing.Point(4, 22);
            this.tbpgBrowser.Name = "tbpgBrowser";
            this.tbpgBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgBrowser.Size = new System.Drawing.Size(559, 224);
            this.tbpgBrowser.TabIndex = 7;
            this.tbpgBrowser.Text = "Browser";
            this.tbpgBrowser.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::RykonServer.Properties.Resources.Untitled;
            this.panel12.Controls.Add(this.panelContaner);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(553, 218);
            this.panel12.TabIndex = 3;
            // 
            // panelContaner
            // 
            this.panelContaner.Controls.Add(this.buttonBack);
            this.panelContaner.Controls.Add(this.linkLabel11);
            this.panelContaner.Controls.Add(this.label36);
            this.panelContaner.Controls.Add(this.textBox_BrowserUrl);
            this.panelContaner.Controls.Add(this.buttonNavigate);
            this.panelContaner.Controls.Add(this.panelBrowser);
            this.panelContaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContaner.Location = new System.Drawing.Point(0, 0);
            this.panelContaner.Name = "panelContaner";
            this.panelContaner.Size = new System.Drawing.Size(553, 218);
            this.panelContaner.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(42, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // linkLabel11
            // 
            this.linkLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.LinkColor = System.Drawing.Color.Red;
            this.linkLabel11.Location = new System.Drawing.Point(536, 5);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(14, 13);
            this.linkLabel11.TabIndex = 2;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "X";
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_close_Tab);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(59, 5);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Url";
            // 
            // textBox_BrowserUrl
            // 
            this.textBox_BrowserUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BrowserUrl.Location = new System.Drawing.Point(85, 2);
            this.textBox_BrowserUrl.Name = "textBox_BrowserUrl";
            this.textBox_BrowserUrl.Size = new System.Drawing.Size(397, 20);
            this.textBox_BrowserUrl.TabIndex = 2;
            // 
            // buttonNavigate
            // 
            this.buttonNavigate.Location = new System.Drawing.Point(488, 0);
            this.buttonNavigate.Name = "buttonNavigate";
            this.buttonNavigate.Size = new System.Drawing.Size(42, 23);
            this.buttonNavigate.TabIndex = 3;
            this.buttonNavigate.Text = ">>";
            this.buttonNavigate.UseVisualStyleBackColor = true;
            this.buttonNavigate.Click += new System.EventHandler(this.buttonNavigate_Click);
            // 
            // panelBrowser
            // 
            this.panelBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrowser.Controls.Add(this.webBrowser1);
            this.panelBrowser.Location = new System.Drawing.Point(4, 27);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(546, 188);
            this.panelBrowser.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(546, 188);
            this.webBrowser1.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.panelBottom.Controls.Add(this.labelStatue);
            this.panelBottom.ForeColor = System.Drawing.Color.Black;
            this.panelBottom.Location = new System.Drawing.Point(2, 276);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(567, 17);
            this.panelBottom.TabIndex = 5;
            // 
            // labelStatue
            // 
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(9, 2);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(10, 13);
            this.labelStatue.TabIndex = 0;
            this.labelStatue.Text = ".";
            // 
            // panelcontainer
            // 
            this.panelcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelcontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcontainer.Controls.Add(this.panelBottom);
            this.panelcontainer.Controls.Add(this.panelMenustrip);
            this.panelcontainer.Controls.Add(this.tabControlMain);
            this.panelcontainer.Location = new System.Drawing.Point(1, 1);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(574, 297);
            this.panelcontainer.TabIndex = 10;
            // 
            // panelMenustrip
            // 
            this.panelMenustrip.Controls.Add(this.menuStrip1);
            this.panelMenustrip.Location = new System.Drawing.Point(2, -1);
            this.panelMenustrip.Name = "panelMenustrip";
            this.panelMenustrip.Size = new System.Drawing.Size(567, 22);
            this.panelMenustrip.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.designerToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serverToolStripMenuItem.BackgroundImage")));
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.reloadServerConfigurationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem,
            this.offlineToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            this.onlineToolStripMenuItem.Click += new System.EventHandler(this.onlineToolStripMenuItem_Click);
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.Checked = true;
            this.offlineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            this.offlineToolStripMenuItem.Click += new System.EventHandler(this.offlineToolStripMenuItem_Click);
            // 
            // reloadServerConfigurationToolStripMenuItem
            // 
            this.reloadServerConfigurationToolStripMenuItem.Name = "reloadServerConfigurationToolStripMenuItem";
            this.reloadServerConfigurationToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.reloadServerConfigurationToolStripMenuItem.Text = "Reload Config";
            this.reloadServerConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadServerConfigurationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateToolStripMenuItem,
            this.publicToolStripMenuItem,
            this.credintialToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem1.Text = "Access";
            // 
            // privateToolStripMenuItem
            // 
            this.privateToolStripMenuItem.Name = "privateToolStripMenuItem";
            this.privateToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.privateToolStripMenuItem.Text = "Private";
            this.privateToolStripMenuItem.Click += new System.EventHandler(this.privateToolStripMenuItem_Click);
            // 
            // publicToolStripMenuItem
            // 
            this.publicToolStripMenuItem.Checked = true;
            this.publicToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.publicToolStripMenuItem.Name = "publicToolStripMenuItem";
            this.publicToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.publicToolStripMenuItem.Text = "Public";
            this.publicToolStripMenuItem.Click += new System.EventHandler(this.publicToolStripMenuItem_Click);
            // 
            // credintialToolStripMenuItem
            // 
            this.credintialToolStripMenuItem.Name = "credintialToolStripMenuItem";
            this.credintialToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.credintialToolStripMenuItem.Text = "Credintial";
            this.credintialToolStripMenuItem.Click += new System.EventHandler(this.credintialToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            this.logsToolStripMenuItem1.Click += new System.EventHandler(this.logsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("designerToolStripMenuItem.BackgroundImage")));
            this.designerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolsToolStripMenuItem.BackgroundImage")));
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrpBtnStream,
            this.Tsrtrp_controler,
            this.videoToolStripMenuItem,
            this.listenToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // tstrpBtnStream
            // 
            this.tstrpBtnStream.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrpBtnStreamOff,
            this.tstrpBtnStreamOn,
            this.toolStripSeparator2,
            this.viewStreamerToolStripMenuItem});
            this.tstrpBtnStream.Name = "tstrpBtnStream";
            this.tstrpBtnStream.Size = new System.Drawing.Size(141, 22);
            this.tstrpBtnStream.Text = "Streamer";
            // 
            // tstrpBtnStreamOff
            // 
            this.tstrpBtnStreamOff.Name = "tstrpBtnStreamOff";
            this.tstrpBtnStreamOff.Size = new System.Drawing.Size(149, 22);
            this.tstrpBtnStreamOff.Text = "Off";
            this.tstrpBtnStreamOff.Click += new System.EventHandler(this.tstrpBtnStreamOff_Click);
            // 
            // tstrpBtnStreamOn
            // 
            this.tstrpBtnStreamOn.Name = "tstrpBtnStreamOn";
            this.tstrpBtnStreamOn.Size = new System.Drawing.Size(149, 22);
            this.tstrpBtnStreamOn.Text = "On";
            this.tstrpBtnStreamOn.Click += new System.EventHandler(this.tstrpBtnStreamOn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // viewStreamerToolStripMenuItem
            // 
            this.viewStreamerToolStripMenuItem.Name = "viewStreamerToolStripMenuItem";
            this.viewStreamerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewStreamerToolStripMenuItem.Text = "View Streamer";
            this.viewStreamerToolStripMenuItem.Click += new System.EventHandler(this.viewStreamerToolStripMenuItem_Click);
            // 
            // Tsrtrp_controler
            // 
            this.Tsrtrp_controler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsrtrp_controler_off,
            this.Tsrtrp_controler_on});
            this.Tsrtrp_controler.Name = "Tsrtrp_controler";
            this.Tsrtrp_controler.Size = new System.Drawing.Size(141, 22);
            this.Tsrtrp_controler.Text = "Controler";
            // 
            // Tsrtrp_controler_off
            // 
            this.Tsrtrp_controler_off.Name = "Tsrtrp_controler_off";
            this.Tsrtrp_controler_off.Size = new System.Drawing.Size(91, 22);
            this.Tsrtrp_controler_off.Text = "Off";
            this.Tsrtrp_controler_off.Click += new System.EventHandler(this.Tsrtrp_controler_off_Click);
            // 
            // Tsrtrp_controler_on
            // 
            this.Tsrtrp_controler_on.Name = "Tsrtrp_controler_on";
            this.Tsrtrp_controler_on.Size = new System.Drawing.Size(91, 22);
            this.Tsrtrp_controler_on.Text = "On";
            this.Tsrtrp_controler_on.Click += new System.EventHandler(this.Tsrtrp_controler_on_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoonToolStripMenuItem1,
            this.offvideoToolStripMenuItem1});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.videoToolStripMenuItem.Text = "Video player";
            // 
            // videoonToolStripMenuItem1
            // 
            this.videoonToolStripMenuItem1.Name = "videoonToolStripMenuItem1";
            this.videoonToolStripMenuItem1.Size = new System.Drawing.Size(89, 22);
            this.videoonToolStripMenuItem1.Text = "on";
            // 
            // offvideoToolStripMenuItem1
            // 
            this.offvideoToolStripMenuItem1.Name = "offvideoToolStripMenuItem1";
            this.offvideoToolStripMenuItem1.Size = new System.Drawing.Size(89, 22);
            this.offvideoToolStripMenuItem1.Text = "off";
            // 
            // listenToolStripMenuItem
            // 
            this.listenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlistenToolStripMenuItem,
            this.offlistenToolStripMenuItem});
            this.listenToolStripMenuItem.Name = "listenToolStripMenuItem";
            this.listenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.listenToolStripMenuItem.Text = "Rykon Listen";
            // 
            // onlistenToolStripMenuItem
            // 
            this.onlistenToolStripMenuItem.Name = "onlistenToolStripMenuItem";
            this.onlistenToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onlistenToolStripMenuItem.Text = "On";
            // 
            // offlistenToolStripMenuItem
            // 
            this.offlistenToolStripMenuItem.Name = "offlistenToolStripMenuItem";
            this.offlistenToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offlistenToolStripMenuItem.Text = "Off";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.saveNewSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // saveNewSettingsToolStripMenuItem
            // 
            this.saveNewSettingsToolStripMenuItem.Name = "saveNewSettingsToolStripMenuItem";
            this.saveNewSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveNewSettingsToolStripMenuItem.Text = "Save new settings";
            this.saveNewSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveNewSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.BackgroundImage")));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.closeTabsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeTabsToolStripMenuItem
            // 
            this.closeTabsToolStripMenuItem.Name = "closeTabsToolStripMenuItem";
            this.closeTabsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeTabsToolStripMenuItem.Text = "Close Tabs";
            this.closeTabsToolStripMenuItem.Click += new System.EventHandler(this.closeTabsToolStripMenuItem_Click);
            // 
            // labela_l
            // 
            this.labela_l.AutoSize = true;
            this.labela_l.Location = new System.Drawing.Point(25, 13);
            this.labela_l.Name = "labela_l";
            this.labela_l.Size = new System.Drawing.Size(60, 13);
            this.labela_l.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(25, 89);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 13);
            this.label32.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 114);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 13);
            this.label30.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 151);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 13);
            this.label28.TabIndex = 0;
            // 
            // linkLabel8
            // 
            this.linkLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.LinkColor = System.Drawing.Color.Red;
            this.linkLabel8.Location = new System.Drawing.Point(521, 4);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(14, 13);
            this.linkLabel8.TabIndex = 2;
            this.linkLabel8.TabStop = true;
            // 
            // cb_autoListen
            // 
            this.cb_autoListen.AutoSize = true;
            this.cb_autoListen.Location = new System.Drawing.Point(177, 13);
            this.cb_autoListen.Name = "cb_autoListen";
            this.cb_autoListen.Size = new System.Drawing.Size(15, 14);
            this.cb_autoListen.TabIndex = 3;
            this.cb_autoListen.UseVisualStyleBackColor = true;
            // 
            // cb_showdatetime
            // 
            this.cb_showdatetime.AutoSize = true;
            this.cb_showdatetime.Location = new System.Drawing.Point(177, 89);
            this.cb_showdatetime.Name = "cb_showdatetime";
            this.cb_showdatetime.Size = new System.Drawing.Size(15, 14);
            this.cb_showdatetime.TabIndex = 4;
            this.cb_showdatetime.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 5;
            // 
            // cb_showerrormessage
            // 
            this.cb_showerrormessage.AutoSize = true;
            this.cb_showerrormessage.Location = new System.Drawing.Point(331, 90);
            this.cb_showerrormessage.Name = "cb_showerrormessage";
            this.cb_showerrormessage.Size = new System.Drawing.Size(15, 14);
            this.cb_showerrormessage.TabIndex = 6;
            this.cb_showerrormessage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 7;
            // 
            // cbShowDiricon
            // 
            this.cbShowDiricon.AutoSize = true;
            this.cbShowDiricon.Location = new System.Drawing.Point(470, 91);
            this.cbShowDiricon.Name = "cbShowDiricon";
            this.cbShowDiricon.Size = new System.Drawing.Size(15, 14);
            this.cbShowDiricon.TabIndex = 8;
            this.cbShowDiricon.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(310, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label_r_a_s
            // 
            this.label_r_a_s.AutoSize = true;
            this.label_r_a_s.Location = new System.Drawing.Point(25, 13);
            this.label_r_a_s.Name = "label_r_a_s";
            this.label_r_a_s.Size = new System.Drawing.Size(79, 13);
            this.label_r_a_s.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkColor = System.Drawing.Color.Red;
            this.linkLabel6.Location = new System.Drawing.Point(391, 4);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(14, 13);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            // 
            // cb_runatstartup
            // 
            this.cb_runatstartup.AutoSize = true;
            this.cb_runatstartup.Location = new System.Drawing.Point(129, 8);
            this.cb_runatstartup.Name = "cb_runatstartup";
            this.cb_runatstartup.Size = new System.Drawing.Size(15, 14);
            this.cb_runatstartup.TabIndex = 3;
            this.cb_runatstartup.UseVisualStyleBackColor = true;
            // 
            // TrayMenu_contextMenuStrip1
            // 
            this.TrayMenu_contextMenuStrip1.Name = "contextMenuStrip1";
            this.TrayMenu_contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(577, 300);
            this.Controls.Add(this.panelcontainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Rykon Server    ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.TpgMain.ResumeLayout(false);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoader)).EndInit();
            this.gpxStreamer.ResumeLayout(false);
            this.gpxStreamer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.GpxHead.ResumeLayout(false);
            this.GpxHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPort)).EndInit();
            this.tabPageLogs.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelLogs.ResumeLayout(false);
            this.PanelLogs.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TbControlSettings.ResumeLayout(false);
            this.tabPage_set_general.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Tbpage_set_Designer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tbpg_set_Server.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tbpg_set_dynamic.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel_lang_controls.ResumeLayout(false);
            this.panel_lang_controls.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tbpgSecurity.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel_server_credit.ResumeLayout(false);
            this.panel_server_credit.PerformLayout();
            this.tabPage_streamer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.tabPageDesigner.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbpgBrowser.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panelContaner.ResumeLayout(false);
            this.panelContaner.PerformLayout();
            this.panelBrowser.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelcontainer.ResumeLayout(false);
            this.panelMenustrip.ResumeLayout(false);
            this.panelMenustrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerWriter;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TpgMain;
        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.GroupBox gpxStreamer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTestStreamer;
        private System.Windows.Forms.TextBox textBoxUrlStreamer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.LinkLabel linkLabelOpenRootDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxRootDir;
        private System.Windows.Forms.GroupBox GpxHead;
        private System.Windows.Forms.Button buttonTestSelfBrowser;
        private System.Windows.Forms.TextBox txbx_serverUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Prefixs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumPort;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.LinkLabel lnk_copyUrl;
        private System.Windows.Forms.LinkLabel lnk_copyStreamUrl;
        private System.Windows.Forms.Panel panelMenustrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelLogs;
        private System.Windows.Forms.RichTextBox txbxLogs;

        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_off;
        private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_on;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;


        //private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_tray;
        //private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1_tray;
        //private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_off_tray;
        //private System.Windows.Forms.ToolStripMenuItem Tsrtrp_controler_on_tray;
        //private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem_tray;
        //private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem_tray;
        //private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem_tray;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_tray;
        //private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem_tray;

        
        private System.Windows.Forms.LinkLabel lnkcloseLogs;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnk_close_settings;
        private System.Windows.Forms.TabPage tabPage_streamer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStream;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStreamOff;
        private System.Windows.Forms.ToolStripMenuItem tstrpBtnStreamOn;
        private System.Windows.Forms.ToolStripMenuItem viewStreamerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tabPageDesigner;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.ToolStripMenuItem closeTabsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.CheckBox cbswitch_streamerPreview;
        private System.Windows.Forms.ToolStripMenuItem listenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlistenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlistenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadServerConfigurationToolStripMenuItem;
        private System.Windows.Forms.TabControl TbControlSettings;
        private System.Windows.Forms.TabPage Tbpage_set_Designer;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage_set_general;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tbpg_set_Server;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label labela_l;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.CheckBox cb_autoListen;
        private System.Windows.Forms.CheckBox cb_showdatetime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_showerrormessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbShowDiricon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_r_a_s;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.CheckBox cb_runatstartup;
        private System.Windows.Forms.CheckBox cb_run_atstartup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel lnklnl_edit;
        private System.Windows.Forms.RichTextBox rtxbx_Designer_404_index;
        private System.Windows.Forms.TabPage tbpg_set_dynamic;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox cb_allowdynamic;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.PictureBox pcbxLoader;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem privateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credintialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveNewSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbTestInSeparated;
        private System.Windows.Forms.TabPage tbpgBrowser;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.Panel panelContaner;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox_BrowserUrl;
        private System.Windows.Forms.Button buttonNavigate;
        private System.Windows.Forms.Panel panelBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label strmlbl;
        private System.Windows.Forms.ContextMenuStrip TrayMenu_contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem videoonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offvideoToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.CheckBox cbSecureControl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbxControlPasswd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.TabPage tbpgSecurity;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbxLangs;
        private System.Windows.Forms.TextBox txbxLangArgs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbxLangPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbxLangVer;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txbxLangName;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckBox cb_langEnabled;
        private System.Windows.Forms.ListBox lstbxExts;
        private System.Windows.Forms.Panel panel_lang_controls;
        private System.Windows.Forms.TextBox TxbxAddExtn;
        private System.Windows.Forms.LinkLabel lnk_ClearExtns;
        private System.Windows.Forms.LinkLabel lnk_removeExtn;
        private System.Windows.Forms.LinkLabel lnk_add_newExt;
        private System.Windows.Forms.Button btnEditLangs;
        private System.Windows.Forms.LinkLabel lnk_langPath_Browse;
        private System.Windows.Forms.Button btnNewLang;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel_server_credit;
        private System.Windows.Forms.TextBox txbxServerPass;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox TxbxServerId;
        private System.Windows.Forms.CheckBox cp_private;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txbx_pass_Stream;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txbx_pass_Control;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txbx_pass_Listen;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txbx_pass_video;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txbx_pass_Upload;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.CheckBox cb_secure_upload;
        private System.Windows.Forms.CheckBox cb_secure_stream;
        private System.Windows.Forms.CheckBox cb_secure_control;
        private System.Windows.Forms.CheckBox cb_secure_listen;
        private System.Windows.Forms.CheckBox cb_secure_video;
    }
}

