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
    public partial class BigMessageBox : Form
    {
        private int Tiks=0;
        public BigMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setText(string p)
        {
            richTextBox1.Text = p;
        }

        private void BigMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Tiks++;
            if (Tiks == 5)
            {
                timer1.Start();
                this.Close();
            }
        }
    }
}
