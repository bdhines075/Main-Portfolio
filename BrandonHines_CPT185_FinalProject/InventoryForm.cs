using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class InventoryForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet; // Holds the dataset passed to this form

        public InventoryForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet; // Assign the passed dataset to the private field
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BrandonHines_CPT185_FinalProject.Properties.Settings.BrandonHines_CPT244_FinalProjConnectionString"].ConnectionString;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Query the maximum product_id from the Inventory table
                    OleDbCommand command = new OleDbCommand("SELECT MAX(product_id) FROM Inventory", connection);
                    object result = command.ExecuteScalar();
                    int maxProductId = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Set the AutoIncrementSeed and Step
                    dataSet.Inventory.product_idColumn.AutoIncrementSeed = maxProductId + 1;
                    dataSet.Inventory.product_idColumn.AutoIncrementStep = 1;

                    // Use the table adapter to fill the Inventory table
                    inventoryTableAdapter.Fill(dataSet.Inventory);

                    if (dataSet.Inventory.Rows.Count > 0)
                    {
                        dgvInventory.DataSource = dataSet.Inventory;
                    }
                    else
                    {
                        MessageBox.Show("No inventory data available in the database.", "Inventory");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load inventory data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Open AddProductForm
            AddProductForm addProductForm = new AddProductForm(dataSet);
            addProductForm.ShowDialog();

            // Refresh the DataGridView after adding a product
            RefreshInventoryGrid();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                var selectedRow = (BrandonHines_FinalProjDataSet.InventoryRow)
                                  ((DataRowView)dgvInventory.SelectedRows[0].DataBoundItem).Row;

                // Open EditProductForm
                EditProductForm editProductForm = new EditProductForm(selectedRow);
                editProductForm.ShowDialog();

                // Refresh the DataGridView after editing
                RefreshInventoryGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while editing the product: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected row
                var selectedRow = (BrandonHines_FinalProjDataSet.InventoryRow)
                                  ((DataRowView)dgvInventory.SelectedRows[0].DataBoundItem).Row;

                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the product: {selectedRow.product_name}?",
                                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Delete the row
                    selectedRow.Delete();
                    MessageBox.Show("Product deleted successfully.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView after deleting
                    RefreshInventoryGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the product: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Refreshes the DataGridView to reflect changes in the Inventory table.
        /// </summary>
        private void RefreshInventoryGrid()
        {
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = dataSet.Inventory;
        }
    }
}
