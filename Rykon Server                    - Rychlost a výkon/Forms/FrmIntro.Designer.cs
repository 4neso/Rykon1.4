namespace RykonServer.Forms
{
    partial class FrmIntro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntro));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDonotStartagain = new System.Windows.Forms.CheckBox();
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxGH = new System.Windows.Forms.PictureBox();
            this.pictureBoxFb = new System.Windows.Forms.PictureBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFb)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panelHead);
            this.panelContainer.Location = new System.Drawing.Point(6, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(575, 457);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBoxDonotStartagain);
            this.panel1.Controls.Add(this.checkBoxAccept);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(6, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 36);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxDonotStartagain
            // 
            this.checkBoxDonotStartagain.AutoSize = true;
            this.checkBoxDonotStartagain.Location = new System.Drawing.Point(392, 12);
            this.checkBoxDonotStartagain.Name = "checkBoxDonotStartagain";
            this.checkBoxDonotStartagain.Size = new System.Drawing.Size(108, 17);
            this.checkBoxDonotStartagain.TabIndex = 2;
            this.checkBoxDonotStartagain.Text = "Hide on next time";
            this.checkBoxDonotStartagain.UseVisualStyleBackColor = true;
            this.checkBoxDonotStartagain.CheckedChanged += new System.EventHandler(this.checkBoxDonotStartagain_CheckedChanged);
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Checked = true;
            this.checkBoxAccept.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAccept.Location = new System.Drawing.Point(5, 11);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(65, 17);
            this.checkBoxAccept.TabIndex = 1;
            this.checkBoxAccept.Text = "I accept";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            this.checkBoxAccept.CheckedChanged += new System.EventHandler(this.checkBoxAccept_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(173, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Ok";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxGH);
            this.panel2.Controls.Add(this.pictureBoxFb);
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 83);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Follow us";
            // 
            // pictureBoxGH
            // 
            this.pictureBoxGH.Image = global::RykonServer.Properties.Resources.favicon;
            this.pictureBoxGH.Location = new System.Drawing.Point(266, 25);
            this.pictureBoxGH.Name = "pictureBoxGH";
            this.pictureBoxGH.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxGH.TabIndex = 1;
            this.pictureBoxGH.TabStop = false;
            this.pictureBoxGH.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxFb
            // 
            this.pictureBoxFb.Image = global::RykonServer.Properties.Resources.Graphics_Vibe_Simple_Rounded_Social_Facebook;
            this.pictureBoxFb.Location = new System.Drawing.Point(208, 25);
            this.pictureBoxFb.Name = "pictureBoxFb";
            this.pictureBoxFb.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxFb.TabIndex = 0;
            this.pictureBoxFb.TabStop = false;
            this.pictureBoxFb.Click += new System.EventHandler(this.pictureBoxFb_Click);
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.Controls.Add(this.richTextBox1);
            this.panelHead.Location = new System.Drawing.Point(7, 5);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(565, 318);
            this.panelHead.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 311);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 468);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIntro";
            this.Opacity = 0.98D;
            this.Text = "Rykon Server ";
            this.Load += new System.EventHandler(this.FrmIntro_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFb)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxAccept;
        private System.Windows.Forms.CheckBox checkBoxDonotStartagain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxFb;
        private System.Windows.Forms.PictureBox pictureBoxGH;
        private System.Windows.Forms.Label label1;
    }
}