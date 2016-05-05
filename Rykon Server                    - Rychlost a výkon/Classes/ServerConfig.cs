using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RykonServer
{
    public class ServerConfig
    {
        public string FilePath ="";

        public bool ShowDateTime = true;
        public bool ShowMessageError = true;
        public bool ShowDirIcon = false;
        public bool ShowHostAndPort = true;
        public bool ShowPoweredByEnd = true;

        public string ServerAutPass = "2016";
        public string ServerAuthId = "admin";
        public string ControlPassword = "12123";
        public string VideoPassword = "12123"; 
        public string ListenPassword = "12123"; 
        public string StreamPassword = "12123"; 
        public string UploadPassword = "12123"; 

        public bool EnableControler = false;
        public bool EnableVideo = true;
        public bool EnableUpload = true;
        public bool EnableListen = true;
        public bool EnableStream = false;

        public bool IsPublicServer = true;
        public bool SecureVideo = false;
        public bool SecureStream = true;
        public bool SecureControl = true;
        public bool SecureListen = false;
        public bool SecureUpload = true; 

        public string     currentHost = "";   
        public bool       ShowFullPaths = false;
        public string     RootDirectory = "";
        public bool HasNewData = false;
        public bool saved = false;
        public bool AutoStartListening = false;
        public int ScreenShotEvery = 500;
        public string PoweredByEnd = "4Neso  ";
        public bool ValidConfigFile = false;
        
        public ServerConfig(string file)
        {
            this.FilePath = file;
            if (!AppHelper.IsFileExist(file))
                return;
           string[] data = new string[] { };
            try
            {
                data = System.IO.File.ReadAllLines(file);
            }
            catch { ValidConfigFile = false; return; }
            if (data.Length < 1)
            { ValidConfigFile = false; return; }

            Create(data);


        }
        private void Create(string[] data)
        {
            if (data.Length < 1)
                return;
            foreach (string s in data)
            {
                if (s.Contains('=') == false || s.StartsWith("#"))
                    continue;
                string[] pcs = s.Split('=');
                string id = pcs[0].Trim().ToLower();
                string Value = pcs[1];

                switch (id)
                {
                    case "ShowDateTime"      :case "showdatetime"       : this.Initiate(Value, ref this.ShowDateTime); break;
                    case "ShowMessageError"  :case "showmessageerror"   : this.Initiate(Value, ref this.ShowMessageError); break;
                    case "ShowDirIco"        :case "showdirico"         :  case "ShowDirIcon":                    case "showdiricon": this.Initiate(Value, ref this.ShowDirIcon); break;
                    case "ShowHostAndPort"   :case "showhostandport"    : this.Initiate(Value, ref this.ShowHostAndPort); break;
                    case "showpoweredbyEnd"  :case "ShowPoweredByEnd"   : this.Initiate(Value, ref this.ShowPoweredByEnd); break;
                   
                    case "EnableStream"      :case "enablestream"       : this.Initiate(Value, ref this.EnableStream); break;
                    case "enablecontroller"  :case "enablecontroler"    :                    case "enablecontrol":                    case "EnableControl": this.Initiate(Value, ref this.EnableControler); break;
                    case "EnableListen"      :case "enablelisten"       : this.Initiate(Value, ref this.EnableListen); break;
                    case "EnableVideo"       :case "enablevideo"        : this.Initiate(Value, ref this.EnableVideo); break;
                    case "enableupload"      :case "EnableUpload"       : this.Initiate(Value, ref this.EnableUpload); break;
                   
                    case "ControlPassword"   :case "controlpassword"    : this.Initiate(Value, ref this.ControlPassword); break;
                    case "PublicServer"      :case "IsPublicServer"     :case "publicserver": this.Initiate(Value, ref this.IsPublicServer); break;
                    case "ServerAuthId"      :case "serverauthid"       :case "AuthId":   case "AuthID":                    case "authid": this.Initiate(Value, ref this.ServerAuthId); break;
                    case "serverautpass"     :case "ServerAuthPass"     :  case "serverauthpass":  case "AuthPass": case "authpass":case "AuthPassWord": case "ServerAutPass": this.Initiate(Value, ref this.ServerAutPass); break;
                    case "SecuredControl"    :case "securedcntrol": this.Initiate(Value, ref this.SecureControl); break;
                    case "RootDirectory"     :case "rootdirectory": this.Initiate(Value, ref this.RootDirectory); break;
                    case "ShowFullPaths"     :case "showfullpaths": this.Initiate(Value, ref this.ShowFullPaths); break;
                    case "poweredbyend"      :case "PoweredByEnd": this.Initiate(Value, ref this.PoweredByEnd); break;
                    case "autostartlistening":case "AutoStartListening": this.Initiate(Value, ref this.AutoStartListening); break;
                    case "Port"              :case "port": this.Initiate(Value, ref this.Port); break;
                    case "ScreenShotEvery"   :case "screenshotevery"   : this.Initiate(Value, ref this.ScreenShotEvery); break;
                    case "SecureStream"      :case "securestream": this.Initiate(Value, ref this.SecureStream); break;
                    case "SecureControl"     :case "securecontrol"     : this.Initiate(Value, ref this.SecureControl); break;
                    case "SecureListen"      :
                    case "securelisten"      : this.Initiate(Value, ref this.SecureListen); break;
                    case "securevideo"       :
                    case "SecureVideo"       : this.Initiate(Value, ref this.SecureVideo); break;
                    case "SecureUpload"      :
                    case "secureupload"      : this.Initiate(Value, ref this.SecureUpload); break;

 
                }
            }
        }
        public int Port = 9090;
        private void Initiate(string Value, ref string p)
        {
            p = Value.Trim();
        }
        private void Initiate(string Value, ref int p)
        {
            try
            {
                p = int.Parse(Value.Trim());
            }
            catch { p = 9090; }
        }
        private void Initiate(string Value, ref bool p)
        {
            int i = AppHelper.BoolTruefalseUnkown(Value);
            if (i == 1)
                p = true;
            else if (i == 0)
                p = false;
        }
        public bool SaveChanges()
        {
            string data = "#Rykon Server configuration file v1.0 be carefull !!";
           
            data += "\r\nShowDateTime=" + Val(ShowDateTime);
            data += "\r\nShowMessageError=" + Val(ShowMessageError);
            data += "\r\nShowDirIcon=" + Val(ShowDirIcon);
            data += "\r\nShowHostAndPort=" + Val(ShowHostAndPort);
            data += "\r\nShowPoweredByEnd=" + Val(ShowPoweredByEnd);
           
            data += "\r\nPoweredByEnd=" + (PoweredByEnd);
            data += "\r\nAutoStartListening=" + Val(AutoStartListening);
            data += "\r\nPort=" + (Port);
            data += "\r\nScreenShotEvery=" + (ScreenShotEvery);
            data += "\r\nPublicServer=" + Val(IsPublicServer);            
            data += "\r\nRootDirectory=" + (RootDirectory);
            data += "\r\nShowFullPaths=" + Val(ShowFullPaths);

            data += "\r\nEnableListen=" + Val(EnableVideo);
            data += "\r\nEnableListen=" + Val(EnableListen);
            data += "\r\nEnableControler=" + Val(EnableControler);
            data += "\r\nEnableStream=" + (EnableStream);

            data += "\r\nServerAuthId=" + (ServerAuthId);
            data += "\r\nServerAuthPass=" + (ServerAutPass);
            data += "\r\nVideoPassword=" + (VideoPassword);
            data += "\r\nControlPassword=" + (ControlPassword);
            data += "\r\nListenPassword=" + (ListenPassword);
            data += "\r\nStreamPassword=" + (StreamPassword);
            data += "\r\nUploadPassword=" + (UploadPassword);

            data += "\r\nSecureVideo=" + (SecureVideo);
            data += "\r\nSecureStream=" + (SecureStream);
            data += "\r\nSecureControl=" + (SecureControl);
            data += "\r\nSecureListen=" + (SecureListen);
            data += "\r\nSecureUpload=" + (SecureUpload);

            try
            {
                AppHelper.RepairPath(FilePath);
                System.IO.File.WriteAllText(this.FilePath, data);
                saved = true;
            }
            catch { saved = false; }
            return saved;
        }

        private static string Val(bool a)
        {
            if (a)
                return "Yes";
            else
                return "No";
        }



        
    }
}
