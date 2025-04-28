using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class frmMainMenu : Form
    {
        private BrandonHines_FinalProjDataSet dataSet;

        public frmMainMenu()
        {
            InitializeComponent();
            dataSet = new BrandonHines_FinalProjDataSet();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(dataSet);
            inventoryForm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm(dataSet); // Pass the dataset
            customersForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(dataSet);
            ordersForm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            LowStockReportForm lowStockReportForm = new LowStockReportForm(dataSet); // Pass the dataset
            lowStockReportForm.ShowDialog(); // Open the Low Stock Report Form
        }
    }
}


