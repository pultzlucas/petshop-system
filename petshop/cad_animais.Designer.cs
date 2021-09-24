
namespace petshop
{
    partial class cad_animais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label nomeLabel;
            this.petshopDataSet = new petshop.petshopDataSet();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new petshop.petshopDataSetTableAdapters.animaisTableAdapter();
            this.tableAdapterManager = new petshop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnInserirFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.petshopDataSet = new petshop.petshopDataSet();
            this.animaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter1 = new petshop.petshopDataSetTableAdapters.animaisTableAdapter();
            this.tableAdapterManager1 = new petshop.petshopDataSetTableAdapters.TableAdapterManager();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FotoAnimal = new System.Windows.Forms.PictureBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(57, 34);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(60, 20);
            codigoLabel.TabIndex = 19;
            codigoLabel.Text = "codigo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(57, 74);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(81, 20);
            descricaoLabel.TabIndex = 21;
            descricaoLabel.Text = "descricao:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(57, 114);
            tipoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(39, 20);
            tipoLabel.TabIndex = 23;
            tipoLabel.Text = "tipo:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(57, 155);
            data_cadastroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(111, 20);
            data_cadastroLabel.TabIndex = 25;
            data_cadastroLabel.Text = "data cadastro:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(726, 34);
            fotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(41, 20);
            fotoLabel.TabIndex = 27;
            fotoLabel.Text = "foto:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(66, 214);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 29;
            nomeLabel.Text = "nome:";
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "animais";
            this.animaisBindingSource.DataSource = this.petshopDataSet;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animaisTableAdapter = this.animaisTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = petshop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.Location = new System.Drawing.Point(38, 400);
            this.animaisDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.RowHeadersWidth = 62;
            this.animaisDataGridView.Size = new System.Drawing.Size(1058, 338);
            this.animaisDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_cadastro";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(591, 331);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(213, 35);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(892, 331);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(202, 35);
            this.BtnExcluir.TabIndex = 17;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.Location = new System.Drawing.Point(320, 331);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(190, 35);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(42, 331);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(201, 35);
            this.BtnNovo.TabIndex = 15;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnInserirFoto
            // 
            this.BtnInserirFoto.Location = new System.Drawing.Point(777, 245);
            this.BtnInserirFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInserirFoto.Name = "BtnInserirFoto";
            this.BtnInserirFoto.Size = new System.Drawing.Size(318, 35);
            this.BtnInserirFoto.TabIndex = 19;
            this.BtnInserirFoto.Text = "Inserir Foto";
            this.BtnInserirFoto.UseVisualStyleBackColor = true;
            this.BtnInserirFoto.Click += new System.EventHandler(this.BtnInserirFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource1
            // 
            this.animaisBindingSource1.DataMember = "animais";
            this.animaisBindingSource1.DataSource = this.petshopDataSet;
            // 
            // animaisTableAdapter1
            // 
            this.animaisTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.animaisTableAdapter = this.animaisTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.clientesTableAdapter = null;
            this.tableAdapterManager1.produtosTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = petshop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource1, "codigo", true));
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(178, 29);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(298, 26);
            this.codigoTextBox.TabIndex = 20;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource1, "descricao", true));
            this.descricaoTextBox.Enabled = false;
            this.descricaoTextBox.Location = new System.Drawing.Point(178, 69);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(298, 26);
            this.descricaoTextBox.TabIndex = 22;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource1, "tipo", true));
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Location = new System.Drawing.Point(178, 109);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(298, 26);
            this.tipoTextBox.TabIndex = 24;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animaisBindingSource1, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Enabled = false;
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(178, 149);
            this.data_cadastroDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.data_cadastroDateTimePicker.TabIndex = 26;
            // 
            // FotoAnimal
            // 
            this.FotoAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animaisBindingSource1, "foto", true));
            this.FotoAnimal.Location = new System.Drawing.Point(777, 34);
            this.FotoAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FotoAnimal.Name = "FotoAnimal";
            this.FotoAnimal.Size = new System.Drawing.Size(318, 175);
            this.FotoAnimal.TabIndex = 28;
            this.FotoAnimal.TabStop = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource1, "nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(178, 203);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(298, 26);
            this.nomeTextBox.TabIndex = 30;
            // 
            // cad_animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 769);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(data_cadastroLabel);
            this.Controls.Add(this.data_cadastroDateTimePicker);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.FotoAnimal);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.BtnInserirFoto);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.animaisDataGridView);
            this.Name = "cad_animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.Load += new System.EventHandler(this.cad_animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private petshopDataSetTableAdapters.animaisTableAdapter animaisTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnInserirFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource1;
        private petshopDataSetTableAdapters.animaisTableAdapter animaisTableAdapter1;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private System.Windows.Forms.PictureBox FotoAnimal;
        private System.Windows.Forms.TextBox nomeTextBox;

    }
}