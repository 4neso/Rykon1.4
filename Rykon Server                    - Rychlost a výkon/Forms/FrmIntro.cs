using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RykonServer.Forms
{
    public partial class FrmIntro : Form
    {
        int fiveSeconds = 10;
        public FrmIntro()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        
             
        }

        private void checkBoxAccept_CheckedChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            if (fiveSeconds <=1)
                btnClose.Enabled = checkBoxAccept.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            fiveSeconds--;

            if (fiveSeconds <=1)
            {
                timer1.Stop();
                btnClose.Text = "Ok";
                checkBoxAccept_CheckedChanged(null, null);
                return;
            }
            btnClose.Text = "Ok (" + fiveSeconds + ")";


        }

        private void checkBoxDonotStartagain_CheckedChanged(object sender, EventArgs e)
        {
            bool DoNotViewINTRONextTime = checkBoxDonotStartagain.Checked;
            SettingsEditor.SetDonotViewIntro(DoNotViewINTRONextTime);
        }

        private void pictureBoxFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com/rykonServer");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/4neso/rykonServer");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {

        }
    }
}
