namespace RykonServer.Forms
{
    partial class FrmLanguageAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklblBrowseCompilerPath = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxExts = new System.Windows.Forms.ListBox();
            this.TxbxArgs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbxCompilerPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.TxbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNewExt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.textBoxNewExt);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonclear);
            this.panel1.Controls.Add(this.lnklblBrowseCompilerPath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBoxExts);
            this.panel1.Controls.Add(this.TxbxArgs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbxVersion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxbxCompilerPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.TxbxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 278);
            this.panel1.TabIndex = 0;
            // 
            // lnklblBrowseCompilerPath
            // 
            this.lnklblBrowseCompilerPath.AutoSize = true;
            this.lnklblBrowseCompilerPath.Location = new System.Drawing.Point(519, 82);
            this.lnklblBrowseCompilerPath.Name = "lnklblBrowseCompilerPath";
            this.lnklblBrowseCompilerPath.Size = new System.Drawing.Size(42, 13);
            this.lnklblBrowseCompilerPath.TabIndex = 11;
            this.lnklblBrowseCompilerPath.TabStop = true;
            this.lnklblBrowseCompilerPath.Text = "Browse";
            this.lnklblBrowseCompilerPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBrowseCompilerPath_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File exts";
            // 
            // listBoxExts
            // 
            this.listBoxExts.FormattingEnabled = true;
            this.listBoxExts.Location = new System.Drawing.Point(562, 34);
            this.listBoxExts.Name = "listBoxExts";
            this.listBoxExts.Size = new System.Drawing.Size(63, 212);
            this.listBoxExts.TabIndex = 9;
            this.listBoxExts.SelectedIndexChanged += new System.EventHandler(this.listBoxExts_SelectedIndexChanged);
            // 
            // TxbxArgs
            // 
            this.TxbxArgs.Location = new System.Drawing.Point(109, 207);
            this.TxbxArgs.Name = "TxbxArgs";
            this.TxbxArgs.Size = new System.Drawing.Size(404, 20);
            this.TxbxArgs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Process arguments";
            // 
            // txbxVersion
            // 
            this.txbxVersion.Location = new System.Drawing.Point(109, 139);
            this.txbxVersion.Name = "txbxVersion";
            this.txbxVersion.Size = new System.Drawing.Size(404, 20);
            this.txbxVersion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language version";
            // 
            // TxbxCompilerPath
            // 
            this.TxbxCompilerPath.Location = new System.Drawing.Point(109, 79);
            this.TxbxCompilerPath.Name = "TxbxCompilerPath";
            this.TxbxCompilerPath.Size = new System.Drawing.Size(404, 20);
            this.TxbxCompilerPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compiler path";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxbxName
            // 
            this.TxbxName.Location = new System.Drawing.Point(109, 18);
            this.TxbxName.Name = "TxbxName";
            this.TxbxName.Size = new System.Drawing.Size(404, 20);
            this.TxbxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language Name";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(631, 223);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(56, 23);
            this.buttonclear.TabIndex = 12;
            this.buttonclear.Text = "Clear all";
            this.buttonclear.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(629, 165);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(631, 194);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(56, 23);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // textBoxNewExt
            // 
            this.textBoxNewExt.Location = new System.Drawing.Point(625, 139);
            this.textBoxNewExt.Name = "textBoxNewExt";
            this.textBoxNewExt.Size = new System.Drawing.Size(62, 20);
            this.textBoxNewExt.TabIndex = 15;
            this.textBoxNewExt.TextChanged += new System.EventHandler(this.textBoxNewExt_TextChanged);
            // 
            // FrmLanguageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 285);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLanguageAdd";
            this.Opacity = 0.96D;
            this.Text = "Language Customizer";
            this.Load += new System.EventHandler(this.FrmLanguageAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbxVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbxCompilerPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TxbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbxArgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxExts;
        private System.Windows.Forms.LinkLabel lnklblBrowseCompilerPath;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.TextBox textBoxNewExt;
    }
}