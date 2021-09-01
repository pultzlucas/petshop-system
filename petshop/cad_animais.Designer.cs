
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
            this.petshopDataSet = new petshop.petshopDataSet();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new petshop.petshopDataSetTableAdapters.animaisTableAdapter();
            this.tableAdapterManager = new petshop.petshopDataSetTableAdapters.TableAdapterManager();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FotoAnimal = new System.Windows.Forms.PictureBox();
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
            codigoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(28, 42);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "codigo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(28, 68);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "descricao:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(28, 94);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "tipo:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(28, 121);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(75, 13);
            data_cadastroLabel.TabIndex = 7;
            data_cadastroLabel.Text = "data cadastro:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(484, 19);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(28, 13);
            fotoLabel.TabIndex = 9;
            fotoLabel.Text = "foto:";
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
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(109, 39);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(347, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(109, 65);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(347, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(109, 91);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(347, 20);
            this.tipoTextBox.TabIndex = 6;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animaisBindingSource, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(109, 117);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(347, 20);
            this.data_cadastroDateTimePicker.TabIndex = 8;
            // 
            // FotoAnimal
            // 
            this.FotoAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animaisBindingSource, "foto", true));
            this.FotoAnimal.Location = new System.Drawing.Point(518, 19);
            this.FotoAnimal.Name = "FotoAnimal";
            this.FotoAnimal.Size = new System.Drawing.Size(212, 122);
            this.FotoAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoAnimal.TabIndex = 10;
            this.FotoAnimal.TabStop = false;
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
            this.animaisDataGridView.Location = new System.Drawing.Point(25, 260);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.Size = new System.Drawing.Size(705, 220);
            this.animaisDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_cadastro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(394, 215);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 23);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(595, 215);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(135, 23);
            this.BtnExcluir.TabIndex = 17;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(213, 215);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(127, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(28, 215);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(134, 23);
            this.BtnNovo.TabIndex = 15;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnInserirFoto
            // 
            this.BtnInserirFoto.Location = new System.Drawing.Point(518, 159);
            this.BtnInserirFoto.Name = "BtnInserirFoto";
            this.BtnInserirFoto.Size = new System.Drawing.Size(212, 23);
            this.BtnInserirFoto.TabIndex = 19;
            this.BtnInserirFoto.Text = "Inserir Foto";
            this.BtnInserirFoto.UseVisualStyleBackColor = true;
            this.BtnInserirFoto.Click += new System.EventHandler(this.BtnInserirFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cad_animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 492);
            this.Controls.Add(this.BtnInserirFoto);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.animaisDataGridView);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cad_animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.Load += new System.EventHandler(this.cad_animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private petshopDataSetTableAdapters.animaisTableAdapter animaisTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private System.Windows.Forms.PictureBox FotoAnimal;
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

    }
}