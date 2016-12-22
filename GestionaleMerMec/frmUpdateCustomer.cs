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
    public partial class frmUpdateCustomer : Form
    {
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSetCustomers.CustomersClasses'. È possibile spostarla o rimuoverla se necessario.
            this.customersClassesTableAdapter.Fill(this.dataSetCustomers.CustomersClasses);
            // TODO: questa riga di codice carica i dati nella tabella 'dataSetCustomers.Customers'. È possibile spostarla o rimuoverla se necessario.
            this.customersTableAdapter.Fill(this.dataSetCustomers.Customers);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNameFilter.Text != "" && comboBoxCategoryFilter.SelectedIndex != -1)
            {
                DataSetCustomersTableAdapters.CustomersTableAdapter adapter = new DataSetCustomersTableAdapters.CustomersTableAdapter();
                DataSetCustomers.CustomersDataTable table = new DataSetCustomers.CustomersDataTable();
                adapter.FillByNameAndCategory(table, txtNameFilter.Text, int.Parse(comboBoxCategoryFilter.SelectedValue.ToString()));
                dataGridView1.DataSource = table;
            }
        }

        private void comboBoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoryFilter.SelectedIndex != -1)
            {
                DataSetCustomersTableAdapters.CustomersTableAdapter adapter = new DataSetCustomersTableAdapters.CustomersTableAdapter();
                DataSetCustomers.CustomersDataTable table = new DataSetCustomers.CustomersDataTable();
                adapter.FillByCategory(table, int.Parse(comboBoxCategoryFilter.SelectedValue.ToString()));
                dataGridView1.DataSource = table;
            }
        }

        private void txtNameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtNameFilter.Text != "")
            {
                DataSetCustomersTableAdapters.CustomersTableAdapter adapter = new DataSetCustomersTableAdapters.CustomersTableAdapter();
                DataSetCustomers.CustomersDataTable table = new DataSetCustomers.CustomersDataTable();
                adapter.FillByName(table, txtNameFilter.Text);
                dataGridView1.DataSource = table;
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                GestioneCliente cliente = new GestioneCliente(
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), //name
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),//surname
                    dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),//fiscalcode
                    dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),//email
                    dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),//number
                    DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()),//date
                    decimal.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()),//balance
                    int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()));//category
                cliente.id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());


                frmNuovoCliente frmNuovoCliente = new frmNuovoCliente();

                frmNuovoCliente.cliente = cliente;

                frmNuovoCliente.Show();

            }

            
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataSetCustomersTableAdapters.CustomersTableAdapter adapter = new DataSetCustomersTableAdapters.CustomersTableAdapter();
                adapter.Delete(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            }

        }
    }
}
