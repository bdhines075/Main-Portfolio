using System;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class AddOrderForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;
        private BrandonHines_FinalProjDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;

        public AddOrderForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet; // Assign the dataset
            ordersTableAdapter = new BrandonHines_FinalProjDataSetTableAdapters.OrdersTableAdapter(); // Initialize the TableAdapter
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text) ||
         string.IsNullOrWhiteSpace(txtOrderStatus.Text) ||
         string.IsNullOrWhiteSpace(txtStoreId.Text) ||
         string.IsNullOrWhiteSpace(txtStaffId.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Create a new order row
                var newRow = dataSet.Orders.NewOrdersRow();

                newRow.customer_id = int.Parse(txtCustomerId.Text);
                newRow.order_status = int.Parse(txtOrderStatus.Text);
                newRow.order_date = dateTimePickerOrderDate.Value;
                newRow.required_date = dateTimePickerRequiredDate.Value;
                newRow.shipped_date = dateTimePickerShippedDate.Value;
                newRow.store_id = int.Parse(txtStoreId.Text);
                newRow.staff_id = int.Parse(txtStaffId.Text);

                // Add the new row to the dataset
                dataSet.Orders.AddOrdersRow(newRow);

                // Save changes to the database
                ordersTableAdapter.Update(dataSet.Orders);

                // Refresh the dataset to get the new order_id from the database
                dataSet.Orders.Clear();
                ordersTableAdapter.Fill(dataSet.Orders);

                MessageBox.Show("Order added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without making changes
        }
    }
}
