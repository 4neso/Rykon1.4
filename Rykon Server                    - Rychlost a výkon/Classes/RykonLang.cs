using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RykonServer.Classes
{
    public class RykonLang
    {
        public string LangName = "";
        public string CompilerPath = "";
        public string LangVersion = "";
        public string ProcessArgs = "";
        public List<string> FileExts = new List<string>();

        public static char Langs_Separator = '̥';
        public static char Langs_ATTR_Separator = '»';
        public static char Langs_VAL_Separator = '¦';
        public static char Langs_Extn_Separator = '¸';


        public string CompilePage(string pageFilePath, string GetVars = "", string PostVars = "")
        {
            try
            {


                string temp = System.IO.Path.GetTempFileName() + "." + AppHelper.LastPeice(pageFilePath, ".");

                if (this.DecodeDataBeforeEnvironment)
                    GetVars = WebServer.DecodeUrlChars(GetVars);

                if (GetVars.StartsWith("?"))
                    GetVars = GetVars.Substring(1);

                string prepend = XCompiler.PrependCode(this.LangName, (PostVars != "") ? "POST" : "GET");
              
                if (PostVars != "")
                    prepend = prepend.Replace("GET", "POST");

                AppHelper.writeToFile(temp, prepend + " \r\n\r\n" + AppHelper.ReadFileText(pageFilePath));
                pageFilePath = temp;

                Process proc = new Process();
                proc.StartInfo.FileName = CompilerPath;
                proc.StartInfo.Arguments = this.ProcessArgs.Replace("$page$", pageFilePath) + " " + GetVars + " " + PostVars;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.Start();

                string res = proc.StandardOutput.ReadToEnd();
                if (string.IsNullOrEmpty(res))
                {
                    res = proc.StandardError.ReadToEnd();
                    res = "<h2 style=\"color:red;\">Error!</h2><hr/> <h4>Error Details :</h4> <pre>" + res + "</pre>";
                    proc.StandardError.Close();
                }
                if (res.StartsWith("\n Parse error: syntax error"))
                    res = "<h2 style=\"color:red;\">Error!</h2><hr/> <h4>Error Details :</h4> <pre>" + res + "</pre>";

                proc.StandardOutput.Close();
                proc.Close();

                AppHelper.deleteFile(temp);
                return res;

            }
            catch (Exception s) { return s.Message; }
        }


        public string GetFileExtsString(string sep)
        {
            try
            {
                string res = "";
                foreach (string s in FileExts)
                    res += (s + sep);

                return res.Substring(0, res.Length - sep.Length);
            }
            catch { return ""; }
        }
        public RykonLang()
        {

        }


        internal static RykonLang Build(string lang)
        {
            // name=php AttSeparator path=c:\php AttSeparator version=3 AttSeparator arg=d
            RykonLang r = new RykonLang();

            if (lang.Contains(RykonLang.Langs_ATTR_Separator.ToString()))
            {
                string[] attrs = lang.Split(Langs_ATTR_Separator);//new string[] { AttSeparator }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string x in attrs)
                {
                    string name = "", val = "";

                    if (x.Contains(RykonLang.Langs_VAL_Separator.ToString()))
                    {
                        string[] pcs = x.Split(RykonLang.Langs_VAL_Separator);
                        name = pcs[0].Trim();
                        val = pcs[1].Trim();

                    }
                    r.SetATrrAndVal(name, val);



                }
            }

            return r;
        }
        public override string ToString()
        {
            string x = "";

            x += ("\r\nname                          " + Langs_VAL_Separator + "    " + this.LangName + RykonLang.Langs_ATTR_Separator);
            x += ("\r\npath                          " + Langs_VAL_Separator + "    " + this.CompilerPath + Langs_ATTR_Separator);
            x += ("\r\nversion                       " + Langs_VAL_Separator + "    " + this.LangVersion + Langs_ATTR_Separator);
            x += ("\r\narguments                     " + Langs_VAL_Separator + "    " + this.ProcessArgs + Langs_ATTR_Separator);
            x += ("\r\nexts                          " + Langs_VAL_Separator + "    " + FileExtsString() + Langs_ATTR_Separator);
            x += ("\r\nenabled                       " + RykonLang.Langs_VAL_Separator + "    " + (this.Enabled ? "yes" : "no"));
            x += ("\r\ndecodedatabeforeenvironment   " + RykonLang.Langs_VAL_Separator + "    " + (this.DecodeDataBeforeEnvironment ? "yes" : "no"));
            
            
            return x + "\r\n\r\n";

        }

        private string FileExtsString()
        {
            string p = "";
            foreach (string e in FileExts)
                p += e + RykonLang.Langs_Extn_Separator;

            if (p.Length > 1)
                return p.Substring(0, p.Length - 1);
            return p;
        }
        private void SetATrrAndVal(string name, string val)
        {
            name = name.ToLower().Trim();

            if (name == "name")
                this.LangName = val;

            else if (name == "version")
                this.LangVersion = val;

            else if (name == "path")
                this.CompilerPath = val;

            else if (name == "arguments")
                this.ProcessArgs = val;


            else if (name == "enabled")
                this.Enabled = val != "no";

            else if (name == "exts")
                this.SetExtsFromString(val);

            else if (name == "DecodeDataBeforeEnvironment".ToLower())
                this.DecodeDataBeforeEnvironment=(AppHelper.BoolTruefalseUnkown(val)==1);


        }

        private void SetExtsFromString(string val)
        {
            if (val.Contains(RykonLang.Langs_Extn_Separator.ToString()))
            {
                string[] pcs = val.Split(RykonLang.Langs_Extn_Separator);
                foreach (string p in pcs)
                    AddAllowedExt(p);
            }
            else
                AddAllowedExt(val);
        }

        public void AddAllowedExt(string ex)
        {
            ex = ex.Trim().ToLower();
            ex = AppHelper.Trim(ex, '.');
            if (this.FileExts.Contains(ex))
                return;
            this.FileExts.Add(ex);
        }
        public void InitExts(string[] exs)
        {
            this.FileExts.Clear();
            foreach (string ex in exs)
            {
                string i = ex.ToLower().Trim();
                if (!this.FileExts.Contains(i))
                    this.FileExts.Add(i);
            }
        }
        internal bool CanCompile(string p)
        {
            if (p.Contains("."))
            {
                string[] seps = p.Split('.');
                string ex = seps[seps.Length - 1].ToLower();
                foreach (string ext in this.FileExts)
                    if (ex == ext)
                        return true;
            }
            return false;
        }
        

        private bool IsCompilerAvailable()
        {
            return (System.IO.File.Exists(this.CompilerPath));
        }

        internal bool IsMatch(RykonLang r)
        {
            return (this.CompilerPath.Trim() == r.CompilerPath.Trim());
        }

        internal void Update(RykonLang r)
        {
            this.CompilerPath = r.CompilerPath;
            this.Enabled = r.Enabled;
            this.FileExts = r.FileExts;
            this.LangName = r.LangName;
            this.LangVersion = r.LangVersion;
            this.ProcessArgs = r.ProcessArgs;
            this.DecodeDataBeforeEnvironment = r.DecodeDataBeforeEnvironment;

        }

        internal void InitExts(System.Windows.Forms.ListBox.ObjectCollection objectCollection)
        {
            this.FileExts.Clear();
            foreach (string ss in objectCollection)
            {
                string s = ss.Trim();
                if (this.FileExts.Contains(s))
                    continue;
                else
                    this.FileExts.Add(s);
            }
        }

        internal bool validLang()
        {
            try
            {
                if (!AppHelper.IsFileExist(this.CompilerPath))
                    return false;

                if (this.FileExts.Count < 1)
                    return false;

                if (this.ProcessArgs.Length < 2)
                    return false;


                return true;
            }
            catch { return false; }


        }

        public bool Enabled = true;




        public bool DecodeDataBeforeEnvironment = false;
    }
  public enum _Mode_ { on, off, Middle }
}
