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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtusu.Text == "admim" && txtsenha.Text == "123")
            {
                frmmenu frm = new frmmenu();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
