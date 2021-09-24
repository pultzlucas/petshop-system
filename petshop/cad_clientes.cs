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

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            nomeTextBox.Enabled = true;
            foneMaskedTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            cpfMaskedTextBox.Enabled = true;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            nomeTextBox.Enabled = false;
            foneMaskedTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            cpfMaskedTextBox.Enabled = false;
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = true;
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
            habilitar();
            clientesBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
            clientesTableAdapter.Fill(petshopDataSet.clientes);
            desabilitar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            desabilitar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
        }
    }
}
