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
    public partial class cad_clientes : Form
    {
        public cad_clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cad_clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
            clientesTableAdapter.Fill(petshopDataSet.clientes);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
        }
    }
}
