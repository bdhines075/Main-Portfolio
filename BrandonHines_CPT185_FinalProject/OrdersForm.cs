using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class OrdersForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;

        public OrdersForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BrandonHines_CPT185_FinalProject.Properties.Settings.BrandonHines_CPT244_FinalProjConnectionString"].ConnectionString;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }

            dgvOrders.AutoGenerateColumns = true;

            try
            {
                // Use the table adapter to fill the Orders table
                ordersTableAdapter.Fill(dataSet.Orders);

                if (dataSet.Orders.Rows.Count > 0)
                {
                    dgvOrders.DataSource = dataSet.Orders;
                }
                else
                {
                    MessageBox.Show("No order data available in the database.", "Orders");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(dataSet);
            addOrderForm.ShowDialog();

            // Refresh the DataGridView after adding an order
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = dataSet.Orders;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to edit.", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (BrandonHines_FinalProjDataSet.OrdersRow)
                              ((DataRowView)dgvOrders.SelectedRows[0].DataBoundItem).Row;

            EditOrderForm editOrderForm = new EditOrderForm(selectedRow);
            editOrderForm.ShowDialog();

            // Refresh the DataGridView after editing
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = dataSet.Orders;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (BrandonHines_FinalProjDataSet.OrdersRow)
                              ((DataRowView)dgvOrders.SelectedRows[0].DataBoundItem).Row;

            var confirmResult = MessageBox.Show($"Are you sure you want to delete the order with ID: {selectedRow.order_id}?",
                                                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                selectedRow.Delete();
                MessageBox.Show("Order deleted successfully.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after deleting
                dgvOrders.DataSource = null;
                dgvOrders.DataSource = dataSet.Orders;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
