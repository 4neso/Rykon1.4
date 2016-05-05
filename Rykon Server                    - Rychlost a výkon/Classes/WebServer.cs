using RykonServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RykonServer
{
    class WebServer
    {
        internal static bool IsDirectoryFound(string RequestFile)
        {
            return
                 System.IO.Directory.Exists(RequestFile);
        }

        internal static RykonFile[] ListDir(string RequestFile, string rootDir, string HostName, string port, bool ReplaceHost = true)
        {

            List<RykonFile> lstr = new List<RykonFile>(); 
            string[] lstar = System.IO.Directory.GetFiles(RequestFile);
            string[] lstdar = System.IO.Directory.GetDirectories(RequestFile);
            
            bool rootDirRequested = (RequestFile == rootDir);
            string host_et_port = HostName + ":" + port + "/";
            rootDir = rootDir.Replace("\\", "/");

            ///// parent
            if (!rootDirRequested)
            {
                string fx = AppHelper.GoUpAsDirectory(RequestFile);
                string fx2 = fx.Replace("\\", "/");
                string fx3 = fx2.Replace(rootDir, "");
                string fx4 = WebServer.EncodeUrlChars(fx3);
                string fx5 = "http://" + host_et_port + fx4;
                string fx6 = fx5.Replace("%2F", "/");

                RykonFile r = new RykonFile();
                r.IsDir = false;
                r.Fullpath = fx;
                r.Webpath = fx6;
                r.Name = AppHelper.LastPeice(fx6, "/");
                lstr.Add(r);

            }
            else
                lstr.Add(null);
                

            foreach (string f in lstar) //files
            {
                string f2 = f.Replace("\\", "/");
                string f3 = f2.Replace(rootDir, "");
                string f4 = WebServer.EncodeUrlChars(f3);
                string f5 = "http://" + host_et_port + f4;
                string f6 = f5.Replace("%2F", "/");
                
                RykonFile r = new RykonFile();
                r.IsDir = false;
                r.Fullpath = f;
                r.Webpath = f6;
                r.Name = AppHelper.LastPeice(f6, "/");
                lstr.Add(r);

            }
            foreach (string f in lstdar) // dirs
            {
                string f2 = f.Replace("\\", "/");
                string f3 = f2.Replace(rootDir, "");
                string f4 = WebServer.EncodeUrlChars(f3);
                string f5 = "http://" + host_et_port + f4;
                string f6 = f5.Replace("%2F", "/");
              
                RykonFile r = new RykonFile();
                r.IsDir = true;
                r.Fullpath = f;
                r.Webpath = f6+"/";
                r.Name = AppHelper.LastPeice(f6, "/");
                lstr.Add(r);

            } 
            return lstr.ToArray();
        }
        public static List<string> BinExts = new List<string>() { "ico", "png", "jpg", "jpeg", "mp3", "mp4", "flv" };
        public static List<string> MediaExts = new List<string>() { "mp3", "mp4", "ogg", "wav", "flv" };
        internal static bool IsBinFile(string RequestPage)
        {
            string ext = AppHelper.LastPeice(RequestPage, ".");
            if (WebServer.BinExts.Contains(ext))
                return true;
            return false;
        }

        internal static string GetInternalErrorException(ExceptionType _CurrentExceptionType_)
        {
            return "Not implemented sorry";
        }

        internal static string EncodeHtmlChars(string Dir)
        {

            return System.Net.WebUtility.HtmlEncode(Dir);
        }
        internal static string DecodeHtmlChars(string Dir)
        {

            return System.Net.WebUtility.HtmlDecode(Dir);
        }
        internal static string EncodeUrlChars(string Dir)
        {

            return System.Net.WebUtility.UrlEncode(Dir);
        }
        internal static string DecodeUrlChars(string Dir)
        {

            return System.Net.WebUtility.UrlDecode(Dir);
        }
        public static string Constatn_Parent_directory = "ParentDir";

        internal static bool isMediaFile(string f)
        {
            string ext = AppHelper.ReturnFileExt(f);
            return MediaExts.Contains(ext.ToLower());

        }

        internal static bool CheckBasicAuth(string vall, string id, string pass)
        {
            if(vall==null)
            return false;
            try
            {
                var auth1 = vall;// ctx.Request.Headers["Authorization"];
                auth1 = auth1.Remove(0, 6); // Remove "Basic " From The Header Value
                auth1 = Encoding.UTF8.GetString(Convert.FromBase64String(auth1));
                var auth2 = string.Format("{0}:{1}", id, pass);
                return (auth1 == auth2);
            }
            catch { }
            return false;


        }


        internal static string IsFoundStaticIndex(string RequestDir)
        {
            string x = RequestDir + "index.html";
            
            if (AppHelper.IsFileExist(x))
                return x;

            
            x = RequestDir + "index.xhtml";
            if (AppHelper.IsFileExist(x))
                return x;


            x = RequestDir + "index.htm";
            if (AppHelper.IsFileExist(x))
                return x;

            return "";
        }
    }
    public enum ExceptionType
    { OutOfMemory_, Overflow_, HttpListner_, none_, Empty_dir_And_no_Default_index, CanceledByRequestor, FailedToHandle }
 
}
