using System;
using System.Collections.Generic;
using System.Text;

namespace RykonServer 
{
    class SettingsEditor
    {
        public static void SetDonotViewIntro(bool p, bool Save = true)
        {
            global::RykonServer.Properties.Settings.Default.ShowIntro=p;
            if(Save)
            global::RykonServer.Properties.Settings.Default.Save();

        }


        public static bool GetDonotViewIntro()
        {
            bool x = global::RykonServer.Properties.Settings.Default.ShowIntro;
            return x;
        }
        public static void SetseparatedBrowser(bool p, bool Save = true)
        {
            global::RykonServer.Properties.Settings.Default.separatedBrowser = p;
            if (Save)
                global::RykonServer.Properties.Settings.Default.Save();

        }


        public static bool GetseparatedBrowser()
        {
            bool x = global::RykonServer.Properties.Settings.Default.separatedBrowser;
            return x;
        }
        public static string GetRootDirectory(string alter = "")
        {
            string d =  global::RykonServer.Properties.Settings.Default.RootDir;

            if (d == "\\RootDir\\" && AppHelper.ExistedDir(alter))
                d = alter + ((!alter.EndsWith("\\RootDir\\"))?"\\RootDir\\":"");

            if (AppHelper.ExistedDir(d) == false)
            {
                d = alter+"\\RootDir\\";
                AppHelper.RepairPath(d, true);
            }
            return d;
        }
        public static void setRootDirectory(string p, bool Save = true)
        { 
              global::RykonServer.Properties.Settings.Default.RootDir=p;
            if(Save)
              global::RykonServer.Properties.Settings.Default.Save();

        }

        public static void Save()
        {
            global::RykonServer.Properties.Settings.Default.Save();

        }

        public static void SetPort(decimal port, bool save = true)
        {
            //global::RykonServer.Properties.Settings.Default.Port = (int)port;

            //if (save)
            //    global::RykonServer.Properties.Settings.Default.Save();

        }
        public static decimal GetPort()
        {
         //return  global::RykonServer.Properties.Settings.Default.Port;
            return 9090;
        }


        public static string GetFavPrefix()
        {
            return global::RykonServer.Properties.Settings.Default.FavPrefix;
        }
        public static void SetFavPrefix(string nP,bool save=true)
        {
              global::RykonServer.Properties.Settings.Default.FavPrefix=nP;
            if(save)
                global::RykonServer.Properties.Settings.Default.Save();

        }

        internal static string GetPHPPath()
        {
            return global::RykonServer.Properties.Settings.Default.PhpPath;

        }

        internal static string GetRingPath()
        {
            return global::RykonServer.Properties.Settings.Default.RingPath;

        }

        internal static string GetPythonPath()
        {
            return global::RykonServer.Properties.Settings.Default.PythonPath;

        }

        internal static string GetRubyPath()
        {
            return global::RykonServer.Properties.Settings.Default.RubyPath;
        }

        internal static string GetLanguages()
        {
            return global::RykonServer.Properties.Settings.Default.ProLangs;
        }

        
        public static string Languages_Separator = "_RykonLangSep_\r\n\r\n";

        public static string Languages_AttributeSeparator ="_RykonLangAtrrSep_\r\n";

        public static string Languages_ValueSeparator = "_RykonLangAtrrValSep_";

        internal static void SetLanguages(string par,bool _save=false)
        {
            global::RykonServer.Properties.Settings.Default.ProLangs=par;
            if (_save)
                Save();

        }

        public static string exts_Separator = ",";
    }
}
