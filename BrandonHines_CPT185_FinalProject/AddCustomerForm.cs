using System;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class AddCustomerForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;
        private BrandonHines_FinalProjDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;

        public AddCustomerForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet; // Assign the dataset
            customersTableAdapter = new BrandonHines_FinalProjDataSetTableAdapters.CustomersTableAdapter(); // Initialize the TableAdapter
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
        string.IsNullOrWhiteSpace(txtLastName.Text) ||
        string.IsNullOrWhiteSpace(txtPhone.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Create a new row in the Customers table
                var newRow = dataSet.Customers.NewCustomersRow();

                newRow.first_name = txtFirstName.Text;
                newRow.last_name = txtLastName.Text;
                newRow.Phone = txtPhone.Text;
                newRow.Email = txtEmail.Text;
                newRow.street = txtStreet.Text;
                newRow.city = txtCity.Text;
                newRow.state = txtState.Text;
                newRow.zip_code = int.Parse(txtZipCode.Text);

                // Add the new row to the dataset
                dataSet.Customers.AddCustomersRow(newRow);

                // Save changes to the database
                customersTableAdapter.Update(dataSet.Customers);

                // Refresh the dataset to get the new customer_id from the database
                dataSet.Customers.Clear();
                customersTableAdapter.Fill(dataSet.Customers);

                MessageBox.Show("Customer added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add Customer Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without making changes
        }
    }
}
