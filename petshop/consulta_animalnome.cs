﻿using System;
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
    public partial class consulta_animalnome : Form
    {
        public consulta_animalnome()
        {
            InitializeComponent();
        }

        private void consulta_animalnome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            animaisBindingSource.Filter = "nome like '%" + txtnome.Text + "%'";
        }
    }
}
