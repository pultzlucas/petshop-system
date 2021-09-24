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
    public partial class consulta_prodcod : Form
    {
        public consulta_prodcod()
        {
            InitializeComponent();
        }

        private void consulta_prodcod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.petshopDataSet.produtos);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.Filter = "codigo=" + txtcodigo.Text;
        }
    }
}
