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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_clientes frm = new cad_clientes();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_produtos frm = new cad_produtos();
            frm.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_animais frm = new cad_animais();
            frm.Show();
        }

        private void códigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta_clicod frm = new consulta_clicod();
            frm.Show();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta_clinome frm = new consulta_clinome();
            frm.Show();
        }

        private void códigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulta_prodcod frm = new consulta_prodcod();
            frm.Show();
        }

        private void descriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta_proddesc frm = new consulta_proddesc();
            frm.Show();
        }

        private void códigoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consulta_animalcod frm = new consulta_animalcod();
            frm.Show();
        }

        private void nomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulta_animalnome frm = new consulta_animalnome();
            frm.Show();
        }

        private void sobreSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreSistema frm = new SobreSistema();
            frm.Show();
        }
    }
}
