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
    public partial class consulta_animalcod : Form
    {
        public consulta_animalcod()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void consulta_animalcod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.Filter = "codigo=" + txtcodigo.Text;
        }
    }
}
