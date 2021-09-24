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
    public partial class cad_produtos : Form
    {
        public cad_produtos()
        {
            InitializeComponent();
        }

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            quantidadeTextBox.Enabled = true;
            precoTextBox.Enabled = true;
            forncedorTextBox.Enabled = true;

            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            descricaoTextBox.Enabled = false;
            quantidadeTextBox.Enabled = true;
            precoTextBox.Enabled = true;
            forncedorTextBox.Enabled = true;

            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = true;
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cad_produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.petshopDataSet.produtos);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
            produtosBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(petshopDataSet.produtos);
            produtosTableAdapter.Fill(petshopDataSet.produtos);
            desabilitar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            produtosBindingSource.CancelEdit();
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(petshopDataSet.produtos);
        }
    }
}
