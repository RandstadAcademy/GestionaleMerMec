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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiscalCode = new System.Windows.Forms.TextBox();
            this.lblFiscalCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFido = new System.Windows.Forms.MaskedTextBox();
            this.lblFido = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.dataSetCustomers = new GestionaleMerMec.DataSetCustomers();
            this.customersClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersClassesTableAdapter = new GestionaleMerMec.DataSetCustomersTableAdapters.CustomersClassesTableAdapter();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersClassesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiscalCode);
            this.groupBox1.Controls.Add(this.lblFiscalCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFido);
            this.groupBox1.Controls.Add(this.lblFido);
            this.groupBox1.Controls.Add(this.txtCognome);
            this.groupBox1.Controls.Add(this.lblCognome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dati Anagrafici";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customersClassesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "CustomerClassId";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*Email:";
            // 
            // txtFiscalCode
            // 
            this.txtFiscalCode.Location = new System.Drawing.Point(103, 145);
            this.txtFiscalCode.MaxLength = 16;
            this.txtFiscalCode.Name = "txtFiscalCode";
            this.txtFiscalCode.Size = new System.Drawing.Size(154, 20);
            this.txtFiscalCode.TabIndex = 12;
            // 
            // lblFiscalCode
            // 
            this.lblFiscalCode.AutoSize = true;
            this.lblFiscalCode.Location = new System.Drawing.Point(14, 148);
            this.lblFiscalCode.Name = "lblFiscalCode";
            this.lblFiscalCode.Size = new System.Drawing.Size(83, 13);
            this.lblFiscalCode.TabIndex = 11;
            this.lblFiscalCode.Text = "*Codice Fiscale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Categoria :";
            // 
            // txtFido
            // 
            this.txtFido.Location = new System.Drawing.Point(78, 109);
            this.txtFido.Mask = "9999,99";
            this.txtFido.Name = "txtFido";
            this.txtFido.Size = new System.Drawing.Size(154, 20);
            this.txtFido.TabIndex = 8;
            // 
            // lblFido
            // 
            this.lblFido.AutoSize = true;
            this.lblFido.Location = new System.Drawing.Point(35, 111);
            this.lblFido.Name = "lblFido";
            this.lblFido.Size = new System.Drawing.Size(37, 13);
            this.lblFido.TabIndex = 6;
            this.lblFido.Text = "*Fido :";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(316, 32);
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIndietro);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSalva);
            this.groupBox2.Location = new System.Drawing.Point(12, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operazioni";
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(193, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 46);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
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
            // dataSetCustomers
            // 
            this.dataSetCustomers.DataSetName = "DataSetCustomers";
            this.dataSetCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersClassesBindingSource
            // 
            this.customersClassesBindingSource.DataMember = "CustomersClasses";
            this.customersClassesBindingSource.DataSource = this.dataSetCustomers;
            // 
            // customersClassesTableAdapter
            // 
            this.customersClassesTableAdapter.ClearBeforeFill = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(89, 71);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.txtPhoneNumber.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "*Telefono:";
            // 
            // frmNuovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNuovoCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nuovo Cliente";
            this.Load += new System.EventHandler(this.frmNuovoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersClassesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFido;
        private System.Windows.Forms.Label lblFido;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtFiscalCode;
        private System.Windows.Forms.Label lblFiscalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSetCustomers dataSetCustomers;
        private System.Windows.Forms.BindingSource customersClassesBindingSource;
        private DataSetCustomersTableAdapters.CustomersClassesTableAdapter customersClassesTableAdapter;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
    }
}