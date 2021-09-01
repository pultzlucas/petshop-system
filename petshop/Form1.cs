using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                frmlogin frm = new frmlogin();
                frm.Show();
                this.Visible = false;
                return;
            }

            progressBar1.Value++;
        }
    }
}
