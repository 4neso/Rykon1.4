using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykonServer.Forms
{
    public partial class FrmSelfBrowser : Form
    {
        private string p;

        public FrmSelfBrowser()
        {
            InitializeComponent();
        }

        public FrmSelfBrowser(string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();

            this.textBoxUrl.Text = p;
            navigateNow();
        }

        private void navigateNow()
        {

            webBrowser1.Navigate(textBoxUrl.Text);
        }

        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            navigateNow();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBoxUrl.Text = this.webBrowser1.Url.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        internal void SetUrl(string p)
        {
            textBoxUrl.Text = p;
        }

        private void FrmSelfBrowser_Load(object sender, EventArgs e)
        {
            if (textBoxUrl.Text.Length > 2)
                navigateNow();          
        }
    }
}
