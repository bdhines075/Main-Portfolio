using System;
using System.Data;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class EditOrderForm : Form
    {
        private DataRow orderRow;

        public EditOrderForm(DataRow selectedRow)
        {
            InitializeComponent();
            orderRow = selectedRow;

            // Pre-fill the form fields with the order's existing data
            txtCustomerId.Text = orderRow["customer_id"].ToString();
            cboOrderStatus.Text = orderRow["order_status"].ToString();
            dtpOrderDate.Value = DateTime.Parse(orderRow["order_date"].ToString());
            dtpRequiredDate.Value = DateTime.Parse(orderRow["required_date"].ToString());
            dtpShippedDate.Value = DateTime.Parse(orderRow["shipped_date"].ToString());
            txtStoreId.Text = orderRow["store_id"].ToString();
            txtStaffId.Text = orderRow["staff_id"].ToString();

            // Disable all fields initially
            txtCustomerId.Enabled = false;
            cboOrderStatus.Enabled = false;
            dtpOrderDate.Enabled = false;
            dtpRequiredDate.Enabled = false;
            dtpShippedDate.Enabled = false;
            txtStoreId.Enabled = false;
            txtStaffId.Enabled = false;

            // Attach events for checkboxes
            chkCustomerId.CheckedChanged += (s, e) => txtCustomerId.Enabled = chkCustomerId.Checked;// Enable the text box if the checkbox is checked
            chkOrderStatus.CheckedChanged += (s, e) => cboOrderStatus.Enabled = chkOrderStatus.Checked;
            chkOrderDate.CheckedChanged += (s, e) => dtpOrderDate.Enabled = chkOrderDate.Checked;
            chkRequiredDate.CheckedChanged += (s, e) => dtpRequiredDate.Enabled = chkRequiredDate.Checked;
            chkShippedDate.CheckedChanged += (s, e) => dtpShippedDate.Enabled = chkShippedDate.Checked;
            chkStoreId.CheckedChanged += (s, e) => txtStoreId.Enabled = chkStoreId.Checked;
            chkStaffId.CheckedChanged += (s, e) => txtStaffId.Enabled = chkStaffId.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the order row with the new values
            if (chkCustomerId.Checked) orderRow["customer_id"] = txtCustomerId.Text;// Update the row if the checkbox is checked
            if (chkOrderStatus.Checked) orderRow["order_status"] = cboOrderStatus.Text;
            if (chkOrderDate.Checked) orderRow["order_date"] = dtpOrderDate.Value;
            if (chkRequiredDate.Checked) orderRow["required_date"] = dtpRequiredDate.Value;
            if (chkShippedDate.Checked) orderRow["shipped_date"] = dtpShippedDate.Value;
            if (chkStoreId.Checked) orderRow["store_id"] = txtStoreId.Text;
            if (chkStaffId.Checked) orderRow["staff_id"] = txtStaffId.Text;

            MessageBox.Show("Order details successfully updated.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
