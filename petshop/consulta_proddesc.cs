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
    public partial class consulta_proddesc : Form
    {
        public consulta_proddesc()
        {
            InitializeComponent();
        }

        private void consulta_proddesc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.petshopDataSet.produtos);

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            produtosBindingSource.Filter = "descricao like '%" + txtdesc.Text + "%'";
        }
    }
}
