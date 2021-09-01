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
            produtosBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(petshopDataSet.produtos);
            produtosTableAdapter.Fill(petshopDataSet.produtos);
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
