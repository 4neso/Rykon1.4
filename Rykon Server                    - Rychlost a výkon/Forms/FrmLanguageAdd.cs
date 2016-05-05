using RykonServer.Classes;
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
    public partial class FrmLanguageAdd : Form
    {
     public   RykonLang SelectedLanguage = new RykonLang();
     private XCompiler LangList;

        public FrmLanguageAdd()
        {
            InitializeComponent();
        }
        public FrmLanguageAdd(RykonLang _lang_)
        {
            InitializeComponent();

            TxbxCompilerPath.Text = _lang_.CompilerPath;
            TxbxName.Text = _lang_.LangName;
            TxbxArgs.Text = _lang_.ProcessArgs;
            txbxVersion.Text = _lang_.LangVersion;
        }

        public FrmLanguageAdd(XCompiler LangList)
        {
            InitializeComponent();

            this.LangList = LangList;
        }

        private void FrmLanguageAdd_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = this.MaximumSize = this.ClientSize;
     //       this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
     //       MessageBox.Show(this.DialogResult.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedLanguage.CompilerPath = TxbxCompilerPath.Text;
            SelectedLanguage.LangName = TxbxName.Text;
            SelectedLanguage.ProcessArgs = TxbxArgs.Text;
            SelectedLanguage.LangVersion = txbxVersion.Text;

            SelectedLanguage.InitExts(listBoxExts.Items);
            this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            this.Close();
 
        }

        private void lnklblBrowseCompilerPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "EXE|*.exe";

            if (o.ShowDialog() == DialogResult.OK)
                this.TxbxCompilerPath.Text = o.FileName;
        }

        private void listBoxExts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = listBoxExts.SelectedIndex >= 0;
            buttonclear.Enabled = listBoxExts.Items.Count > 0;
        }

        private void textBoxNewExt_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxNewExt.Text.Trim().Length > 2;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string p = textBoxNewExt.Text.Trim().ToLower();
            p = AppHelper.RemoveInvalidPathChars(p);
            if (!p.StartsWith("."))
                p = "." + p;
            if (listBoxExts.Items.Contains(p))
                return;
            listBoxExts.Items.Add(p);
        }
    }
}
