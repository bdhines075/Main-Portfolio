using System;
using System.Data;
using System.Windows.Forms;

namespace BrandonHines_CPT185_FinalProject
{
    public partial class EditCustomerForm : Form
    {
        private DataRow customerRow;

        public EditCustomerForm(DataRow selectedRow)
        {
            InitializeComponent();
            customerRow = selectedRow;

            // Pre-fill the form fields with the customer's existing data
            txtFirstName.Text = customerRow["first_name"].ToString();
            txtLastName.Text = customerRow["last_name"].ToString();
            txtPhone.Text = customerRow["Phone"].ToString();
            txtEmail.Text = customerRow["Email"].ToString();
            txtStreet.Text = customerRow["street"].ToString();
            txtCity.Text = customerRow["city"].ToString();
            txtState.Text = customerRow["state"].ToString();
            txtZipCode.Text = customerRow["zip_code"].ToString();

            // Disable all fields initially
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtStreet.Enabled = false;
            txtCity.Enabled = false;
            txtState.Enabled = false;
            txtZipCode.Enabled = false;

            // Attach events for checkboxes
            chkFirstName.CheckedChanged += (s, e) => txtFirstName.Enabled = chkFirstName.Checked;
            chkLastName.CheckedChanged += (s, e) => txtLastName.Enabled = chkLastName.Checked;
            chkPhone.CheckedChanged += (s, e) => txtPhone.Enabled = chkPhone.Checked;
            chkEmail.CheckedChanged += (s, e) => txtEmail.Enabled = chkEmail.Checked;
            chkStreet.CheckedChanged += (s, e) => txtStreet.Enabled = chkStreet.Checked;
            chkCity.CheckedChanged += (s, e) => txtCity.Enabled = chkCity.Checked;
            chkState.CheckedChanged += (s, e) => txtState.Enabled = chkState.Checked;
            chkZipCode.CheckedChanged += (s, e) => txtZipCode.Enabled = chkZipCode.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkFirstName.Checked) customerRow["first_name"] = txtFirstName.Text;
            if (chkLastName.Checked) customerRow["last_name"] = txtLastName.Text;
            if (chkPhone.Checked) customerRow["Phone"] = txtPhone.Text;
            if (chkEmail.Checked) customerRow["Email"] = txtEmail.Text;
            if (chkStreet.Checked) customerRow["street"] = txtStreet.Text;
            if (chkCity.Checked) customerRow["city"] = txtCity.Text;
            if (chkState.Checked) customerRow["state"] = txtState.Text;
            if (chkZipCode.Checked) customerRow["zip_code"] = txtZipCode.Text;

            MessageBox.Show("Customer details successfully updated.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
