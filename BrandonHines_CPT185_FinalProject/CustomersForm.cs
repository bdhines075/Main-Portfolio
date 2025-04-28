using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class CustomersForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;

        public CustomersForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BrandonHines_CPT185_FinalProject.Properties.Settings.BrandonHines_CPT244_FinalProjConnectionString"].ConnectionString;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful!");
                }

                dgvCustomers.AutoGenerateColumns = true;

                // Clear the dataset and reload it to ensure it's up-to-date
                dataSet.Customers.Clear();
                customersTableAdapter.Fill(dataSet.Customers);

                if (dataSet.Customers.Rows.Count > 0)
                {
                    dgvCustomers.DataSource = dataSet.Customers;
                }
                else
                {
                    MessageBox.Show("No customer data available in the database.", "Customers");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(dataSet);
            addCustomerForm.ShowDialog();

            // Refresh the DataGridView after adding a customer
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = dataSet.Customers;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (BrandonHines_FinalProjDataSet.CustomersRow)
                              ((DataRowView)dgvCustomers.SelectedRows[0].DataBoundItem).Row;

            EditCustomerForm editCustomerForm = new EditCustomerForm(selectedRow);
            editCustomerForm.ShowDialog();

            // Refresh the DataGridView after editing
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = dataSet.Customers;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (BrandonHines_FinalProjDataSet.CustomersRow)
                              ((DataRowView)dgvCustomers.SelectedRows[0].DataBoundItem).Row;

            var confirmResult = MessageBox.Show($"Are you sure you want to delete the customer: {selectedRow.first_name} {selectedRow.last_name}?",
                                                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                selectedRow.Delete();
                MessageBox.Show("Customer deleted successfully.", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after deleting
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = dataSet.Customers;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
