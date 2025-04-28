using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class LowStockReportForm : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;
        private BrandonHines_FinalProjDataSetTableAdapters.StockTableAdapter stockTableAdapter;

        public LowStockReportForm(BrandonHines_FinalProjDataSet dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;

            // Initialize the StockTableAdapter
            stockTableAdapter = new BrandonHines_FinalProjDataSetTableAdapters.StockTableAdapter();
        }

        private void LowStockReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Clear the Stock table and reload it to ensure it's up-to-date
                dataSet.Stock.Clear();
                stockTableAdapter.Fill(dataSet.Stock);

                // Filter the Stock table for products with low stock quantity (e.g., less than 5)
                var lowStockItems = dataSet.Stock.AsEnumerable()
                    .Where(row => row.Field<int>("quantity") < 5);

                // Check if there are any low stock items
                if (lowStockItems.Any())
                {
                    // Bind the filtered data to the DataGridView
                    dgvLowStock.DataSource = lowStockItems.CopyToDataTable();
                }
                else
                {
                    // If no rows, clear the DataGridView and display a message
                    dgvLowStock.DataSource = null;
                    MessageBox.Show("All items have adequate stock, Good Job!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Low Stock Report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Low Stock Report form
        }
    }
}
