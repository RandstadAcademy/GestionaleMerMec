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
        public frmNuovoCliente()
        {
            InitializeComponent();
        }

        private void frmNuovoCliente_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'datasetCategorieCliente.CategoriaCliente'. È possibile spostarla o rimuoverla se necessario.
            this.categoriaClienteTableAdapter.Fill(this.datasetCategorieCliente.CategoriaCliente);
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtCognome.Text != "") && (txtIndirizzo.Text != "") && (txtFido.Text != "") && (comboBox1.SelectedIndex != -1))

            {
                GestioneCliente cliente = new GestioneCliente(txtNome.Text, txtCognome.Text, txtIndirizzo.Text, decimal.Parse(txtFido.Text), int.Parse(comboBox1.SelectedValue.ToString()));

                cliente.InserisciCliente_ADO();

                cliente.InserimentoCliente_DataSet();
                
            }
        }
    }
}
