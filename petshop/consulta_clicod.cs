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
    public partial class consulta_clicod : Form
    {
        public consulta_clicod()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void consulta_clicod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "codigo=" + txtcodigo.Text;
        }
    }
}
