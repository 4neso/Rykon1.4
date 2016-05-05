using RykonServer.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace RykonServer
{
    public class XCompiler
    {
        public static string RailsDownloader = "https://s3.amazonaws.com/railsinstaller/Windows/railsinstaller-3.2.0.exe";
        public static string PHPDownloader = "http://windows.php.net/downloads/releases/php-7.0.3-nts-Win32-VC14-x86.zip";
        public static string PythonDownloader = "https://www.python.org/ftp/python/2.7.10/python-2.7.10.msi";
        public static string RingDownloader = "http://netix.dl.sourceforge.net/project/ring-lang/Ring%201.0/Fayed_Ring_1.0_win32_binary_release.zip";

        public List<RykonLang> LanguageList = new List<RykonLang>();
        public static string ProcessWebAppPage(string cp, string page)
        {
            return "";
        }
        public override string ToString()
        {
            string x = "";
            foreach (RykonLang r in this.LanguageList)
            {
                x += (r.ToString()+SettingsEditor.Languages_Separator);
            }
            return x.Substring(0,x.Length-SettingsEditor.Languages_Separator.Length);

        }
        internal bool IsCompilable(string p)
        { 
            var ext = new FileInfo(p);
            foreach (RykonLang r in this.LanguageList)
                if (r.CanCompile(p))
                    return true;
            return false;
        }

        

        internal void AddLanguage(Classes.RykonLang r)
        {
            int count=-1;
            foreach (RykonLang rl in this.LanguageList)
            {
                count++;

                if (rl.IsMatch(r))
                {
                    this.LanguageList[count].Update(r);
                    return;
                }
            }
            this.LanguageList.Add(r);
        }

        internal void ClearList()
        {
            this.LanguageList.Clear();
        }

       

        

        private string CompileMe(string RequestFile)
        {
            throw new NotImplementedException();
        }

        internal bool IsFoundDefaultIndex(string RequestDir,out string x)
        {
            // d:\x\r\3
            // d:\x\r\3\
            List<string> ls = this.GetDefaultIndicesPathes(RequestDir);
            x = "";
            foreach(string l in ls )
                if (AppHelper.IsFileExist(l))
                {
                    x = l;
                    return true;
                }
              x = WebServer.IsFoundStaticIndex(RequestDir);
            return x != "";


        }

        private List<string> GetDefaultIndicesPathes(string RequestDir)
        {
            List<string> ls = new List<string>();
            
            if (RequestDir.EndsWith("\\") == false)
                RequestDir += "\\";

            while (RequestDir.Contains("\\\\"))
                RequestDir = RequestDir.Replace("\\\\", "\\");

            ls.Add(RequestDir + "index.html");
            ls.Add(RequestDir + "index.xhtml");
            ls.Add(RequestDir + "index.htm");


            foreach (RykonLang r in this.LanguageList)
            {
                foreach (string e in r.FileExts)
                {
                    string ex = RequestDir+"index."+e;
                    if (ls.Contains(ex))
                        continue;
                    ls.Add(ex);
                }
            }
            return ls;
        }

        public string phpPAth="";

        internal void Save()
        {
            string data = "";
            foreach (RykonLang r in this.LanguageList)
                if(r.validLang())
                data += r.ToString() + RykonLang.Langs_Separator.ToString();

            if (data.Length > 3)
                data = data.Substring(0, data.Length - 1);
            AppHelper.writeToFile(this.savepath, data);
        }

        public string savepath = "";

        public static string PHP_Send_GeTv_to_Compiler_pre = "<?php  \r\n parse_str(implode('&', array_slice($argv, 1)), $_GET); $_SERVER['REQUEST_METHOD']='GET'; ?>";

        internal string CompileThis(string page,string getvars,string pstv)
        {
            foreach (RykonLang l in this.LanguageList)
                if (l.CanCompile(page))
                    return l.CompilePage(page, getvars, pstv);

            return AppHelper.ReadFileText( page);
        }

        internal static string PrependCode(string p,string method )
        {


            if (p.ToLower().Trim() == "php")
            { 
                return PHP_Send_GeTv_to_Compiler_pre;
            }
            else return "";
        }
    }
    
}
