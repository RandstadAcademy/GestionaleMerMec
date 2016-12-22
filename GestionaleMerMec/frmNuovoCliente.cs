using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionaleMerMec
{
    public partial class frmNuovoCliente : Form
    {

        public GestioneCliente cliente { get; set; }

        public frmNuovoCliente()
        {
            InitializeComponent();
        }

        private void frmNuovoCliente_Load(object sender, EventArgs e)
        {

            this.customersClassesTableAdapter.Fill(this.dataSetCustomers.CustomersClasses);

            if (cliente != null)
            {
                this.Text = "Modifica cliente";
                this.btnSalva.Text = "Modifica";

                txtNome.Text = cliente.nome;
                txtCognome.Text = cliente.cognome;
                txtFiscalCode.Text = cliente.fiscalCode;
                txtEmail.Text = cliente.email;
                txtPhoneNumber.Text = cliente.phoneNumber;
                txtFido.Text = cliente.fido.ToString();
                comboBox1.SelectedValue = cliente.idcategoria;
            }

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

           

           

            if ((txtNome.Text != "") && (txtCognome.Text != "") && (txtEmail.Text != "") && (txtFido.Text != "") && (comboBox1.SelectedIndex != -1))
            {
                GestioneCliente cliente = new GestioneCliente(txtNome.Text, txtCognome.Text, txtFiscalCode.Text, txtEmail.Text, txtPhoneNumber.Text,
                   DateTime.Today.Date, decimal.Parse(txtFido.Text), int.Parse(comboBox1.SelectedValue.ToString()));
                cliente.id = this.cliente.id;


                if (cliente != null)
                {
                    cliente.ModificaCliente_DataSet();

                    this.Close();
                } 
                else
                {
                    cliente.InserisciCliente_ADO();
                    cliente.InserimentoCliente_DataSet();
                }                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
