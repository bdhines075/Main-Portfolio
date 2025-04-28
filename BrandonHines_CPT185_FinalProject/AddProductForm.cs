using System;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class AddProductForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;
        private BrandonHines_FinalProjDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;

        public AddProductForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet; // Assign the dataset
            inventoryTableAdapter = new BrandonHines_FinalProjDataSetTableAdapters.InventoryTableAdapter(); // Initialize the TableAdapter
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
         string.IsNullOrWhiteSpace(txtBrandId.Text) ||
         string.IsNullOrWhiteSpace(txtCategoryId.Text) ||
         string.IsNullOrWhiteSpace(txtModelYear.Text) ||
         string.IsNullOrWhiteSpace(txtListPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Create a new row in the Inventory table
                var newRow = dataSet.Inventory.NewInventoryRow();

                newRow.product_name = txtProductName.Text;
                newRow.brand_id = int.Parse(txtBrandId.Text);
                newRow.category_id = int.Parse(txtCategoryId.Text);
                newRow.model_year = int.Parse(txtModelYear.Text);
                newRow.list_price = decimal.Parse(txtListPrice.Text);

                // Add the row to the dataset
                dataSet.Inventory.AddInventoryRow(newRow);

                // Update the database via the TableAdapter
                inventoryTableAdapter.Update(dataSet.Inventory);

                MessageBox.Show("Product added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add Product Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without making changes
        }
    }
}
