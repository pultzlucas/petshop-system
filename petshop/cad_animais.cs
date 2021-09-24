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

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            tipoTextBox.Enabled = true;
            nomeTextBox.Enabled = true;
            data_cadastroDateTimePicker.Enabled = true;

            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            nomeTextBox.Enabled = false;
            descricaoTextBox.Enabled = false;
            tipoTextBox.Enabled = false;
            data_cadastroDateTimePicker.Enabled = false;

            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = true;
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
            // TODO: This line of code loads data into the 'petshopDataSet1.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter1.Fill(this.petshopDataSet1.animais);
            // TODO: This line of code loads data into the 'petshopDataSet.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
            animaisBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.EndEdit();
            animaisTableAdapter.Update(petshopDataSet.animais);
            animaisTableAdapter.Fill(petshopDataSet.animais);
            desabilitar();
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
