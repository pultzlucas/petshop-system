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
    public partial class cad_animais : Form
    {
        public cad_animais()
        {
            InitializeComponent();
        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void animaisBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cad_animais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            animaisBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.EndEdit();
            animaisTableAdapter.Update(petshopDataSet.animais);
            animaisTableAdapter.Fill(petshopDataSet.animais);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            animaisBindingSource.CancelEdit();
            animaisBindingSource.EndEdit();
            animaisTableAdapter.Update(petshopDataSet.animais);
        }

        private void BtnInserirFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FotoAnimal.Image = System.Drawing.Bitmap.FromFile(openFileDialog1.FileName);
        }
    }
}
