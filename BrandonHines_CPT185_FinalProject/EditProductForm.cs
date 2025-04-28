using System;
using System.Data;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class EditProductForm : Form
    {
        private DataRow productRow;

        public EditProductForm(DataRow selectedRow)
        {
            InitializeComponent();
            productRow = selectedRow;

            // Pre-fill the form fields with the product's existing data
            txtProductName.Text = productRow["product_name"].ToString();// Convert the product_name to a string
            txtBrandId.Text = productRow["brand_id"].ToString();
            txtCategoryId.Text = productRow["category_id"].ToString();
            txtModelYear.Text = productRow["model_year"].ToString();
            txtListPrice.Text = productRow["list_price"].ToString();

            // Disable all fields initially
            txtProductName.Enabled = false;// Disable the product name
            txtBrandId.Enabled = false;
            txtCategoryId.Enabled = false;
            txtModelYear.Enabled = false;
            txtListPrice.Enabled = false;

            // Attach events for checkboxes
            chkProductName.CheckedChanged += (s, e) => txtProductName.Enabled = chkProductName.Checked;// Enable the product name
            chkBrandId.CheckedChanged += (s, e) => txtBrandId.Enabled = chkBrandId.Checked;
            chkCategoryId.CheckedChanged += (s, e) => txtCategoryId.Enabled = chkCategoryId.Checked;
            chkModelYear.CheckedChanged += (s, e) => txtModelYear.Enabled = chkModelYear.Checked;
            chkListPrice.CheckedChanged += (s, e) => txtListPrice.Enabled = chkListPrice.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and update fields only if their corresponding checkboxes are checked
                if (chkProductName.Checked)
                {
                    // Check if the Product Name is empty
                    if (string.IsNullOrWhiteSpace(txtProductName.Text))
                        throw new Exception("Product Name cannot be empty.");
                    productRow["product_name"] = txtProductName.Text;
                }

                // Check if the Brand ID is a valid number
                if (chkBrandId.Checked)
                {
                    
                    if (!int.TryParse(txtBrandId.Text, out int brandId))
                        throw new Exception("Brand ID must be a valid number.");
                    productRow["brand_id"] = brandId;
                }

                // Check if the Category ID is a valid number
                if (chkCategoryId.Checked)
                {
                    if (!int.TryParse(txtCategoryId.Text, out int categoryId))
                        throw new Exception("Category ID must be a valid number.");
                    productRow["category_id"] = categoryId;
                }

                // Check if the Model Year is a valid number
                if (chkModelYear.Checked)
                {
                    if (!int.TryParse(txtModelYear.Text, out int modelYear))
                        throw new Exception("Model Year must be a valid number.");
                    productRow["model_year"] = modelYear;
                }

                // Check if the List Price is a valid decimal number
                if (chkListPrice.Checked)
                {
                    if (!decimal.TryParse(txtListPrice.Text, out decimal listPrice))
                        throw new Exception("List Price must be a valid decimal number.");
                    productRow["list_price"] = listPrice;
                }

                // Update the database via the TableAdapter
                MessageBox.Show("Product details successfully updated.");
                this.Close();
            }
            // Catch any exceptions and display an error message
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Edit Product Error");
            }
        }

        // Close the form without making changes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
