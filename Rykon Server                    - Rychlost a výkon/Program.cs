using RykonServer;
using RykonServer.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Principal;

namespace RykonServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string GithUbURl = "https://github.com/4neso/Rykon";
        /// 
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
               // MessageBox.Show("we are sorry this version is beta , has bugs , we released it to get feedbacks we would like yours send to gersy.ch2@gmail.com , Your emails are welcome ");
                Exec();
            }
            catch (Exception vb)
            {
                MessageBox.Show("Exception happened Please report to gersy.ch2@gmail.com \r \n Exception Text = " + vb.Message);
            }
            AppHelper.writeToFile(Application.StartupPath + "\\version.info", Program.Version);
        }
        public static void Exec()
        {

            FormMain main = new FormMain();
            string d = AppHelper.ReturnAllTime();
             
            bool isAcceptedLicense = true;
            d = "Last Edit at " + d;  
            try
            {
                System.IO.File.WriteAllText(Application.StartupPath + "\\lastInfo.txt", d);
            }
            catch { }

             
            if (!SettingsEditor.GetDonotViewIntro())
            {
              if (new Forms.FrmIntro().ShowDialog() != DialogResult.OK)
                    isAcceptedLicense = false;

            }
            if (isAcceptedLicense)
            {

                MessageBox.Show("this is beta version , project still under Development , \r\n we would like to get text from you \r\n >> gersy.ch2@gmail.com","must said");
                Application.Run(main);
                 
            }
        }
        public static string Version = "1.4";

    }
}
