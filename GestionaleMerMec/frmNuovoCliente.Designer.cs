namespace GestionaleMerMec
{
    partial class frmNuovoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblFido = new System.Windows.Forms.Label();
            this.txtFido = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datasetCategorieCliente = new GestionaleMerMec.DatasetCategorieCliente();
            this.categoriaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaClienteTableAdapter = new GestionaleMerMec.DatasetCategorieClienteTableAdapters.CategoriaClienteTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCategorieCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaClienteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFido);
            this.groupBox1.Controls.Add(this.lblFido);
            this.groupBox1.Controls.Add(this.txtIndirizzo);
            this.groupBox1.Controls.Add(this.lblIndirizzo);
            this.groupBox1.Controls.Add(this.txtCognome);
            this.groupBox1.Controls.Add(this.lblCognome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati Anagrafici";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "*Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(316, 28);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(154, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(248, 35);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(62, 13);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "*Cognome :";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(78, 68);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(392, 20);
            this.txtIndirizzo.TabIndex = 5;
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(17, 75);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(55, 13);
            this.lblIndirizzo.TabIndex = 4;
            this.lblIndirizzo.Text = "*Indirizzo :";
            // 
            // lblFido
            // 
            this.lblFido.AutoSize = true;
            this.lblFido.Location = new System.Drawing.Point(35, 112);
            this.lblFido.Name = "lblFido";
            this.lblFido.Size = new System.Drawing.Size(37, 13);
            this.lblFido.TabIndex = 6;
            this.lblFido.Text = "*Fido :";
            // 
            // txtFido
            // 
            this.txtFido.Location = new System.Drawing.Point(78, 105);
            this.txtFido.Mask = "9999,99";
            this.txtFido.Name = "txtFido";
            this.txtFido.Size = new System.Drawing.Size(100, 20);
            this.txtFido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Categoria :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriaClienteBindingSource;
            this.comboBox1.DisplayMember = "NomeCategoria";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "IdCategoria";
            // 
            // datasetCategorieCliente
            // 
            this.datasetCategorieCliente.DataSetName = "DatasetCategorieCliente";
            this.datasetCategorieCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaClienteBindingSource
            // 
            this.categoriaClienteBindingSource.DataMember = "CategoriaCliente";
            this.categoriaClienteBindingSource.DataSource = this.datasetCategorieCliente;
            // 
            // categoriaClienteTableAdapter
            // 
            this.categoriaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIndietro);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSalva);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operazioni";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(84, 34);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(103, 46);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(193, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 46);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(302, 34);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(103, 46);
            this.btnIndietro.TabIndex = 2;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = true;
            // 
            // frmNuovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNuovoCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nuovo Cliente";
            this.Load += new System.EventHandler(this.frmNuovoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCategorieCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaClienteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFido;
        private System.Windows.Forms.Label lblFido;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DatasetCategorieCliente datasetCategorieCliente;
        private System.Windows.Forms.BindingSource categoriaClienteBindingSource;
        private DatasetCategorieClienteTableAdapters.CategoriaClienteTableAdapter categoriaClienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalva;
    }
}