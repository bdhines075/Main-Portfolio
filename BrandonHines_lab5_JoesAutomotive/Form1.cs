using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Brandon Hines
 * CPT185-A01H
 * Lab5 Joes Auto 
 */
/*
 * Brandon Hines
 * CPT185-A01H
 * Lab5 Joes Auto 
 */

using System;
using System.Windows.Forms;

namespace BrandonHines_lab5_JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calc button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //try-catch parse user input
            try
            {
                if (!IsValidInput(txtParts.Text) || !IsValidInput(txtLabor.Text))
                {
                    MessageBox.Show("Please enter valid numeric values for Parts and Labor.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double serviceAndLabor = CalculateServiceAndLabor();
                double parts = ParseInput(txtParts.Text);
                double labor = ParseInput(txtLabor.Text);
                double tax = CalculateTax(parts);
                double totalFees = CalculateTotalFees(serviceAndLabor, parts, labor, tax);

                serviceAndLabor += labor; // Include labor in the Service and Labor summary
                DisplayResults(serviceAndLabor, parts, tax, totalFees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Method to validate input
        private bool IsValidInput(string input)
        {
            return double.TryParse(input, out double result) && result > 0;
        }

        //Calculate prices add to serviceandlabor
        private double CalculateServiceAndLabor()
        {
            double serviceAndLabor = 0;

            if (chkOilChange.Checked)
            {
                serviceAndLabor += 26;
            }

            if (chkLubeJob.Checked)
            {
                serviceAndLabor += 18;
            }

            if (chkRadiatorFlush.Checked)
            {
                serviceAndLabor += 30;
            }

            if (chkTransmissionFlush.Checked)
            {
                serviceAndLabor += 80;
            }

            if (chkInspection.Checked)
            {
                serviceAndLabor += 15;
            }

            if (chkReplaceMuffler.Checked)
            {
                serviceAndLabor += 100;
            }

            if (chkTireRotation.Checked)
            {
                serviceAndLabor += 20;
            }

            return serviceAndLabor;
        }

        //parse input
        private double ParseInput(string input)
        {
            return double.TryParse(input, out double result) ? result : 0;
        }

        //calc tax by 8%
        private double CalculateTax(double parts)
        {
            return parts * 0.08;
        }

        //calc total
        private double CalculateTotalFees(double serviceAndLabor, double parts, double labor, double tax)
        {
            return serviceAndLabor + parts + labor + tax;
        }

        //output results
        private void DisplayResults(double serviceAndLabor, double parts, double tax, double totalFees)
        {
            txtServiceAndLabor.Text = serviceAndLabor.ToString("C");
            txtPartsSummary.Text = parts.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotalFees.Text = totalFees.ToString("C");
        }

        //clear button as two function
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelections();
            ClearTextFields();
        }
        //clears selections
        private void ClearSelections()
        {
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        //clears text fields
        private void ClearTextFields()
        {
            txtParts.Text = string.Empty;
            txtLabor.Text = string.Empty;
            txtServiceAndLabor.Text = string.Empty;
            txtPartsSummary.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotalFees.Text = string.Empty;
        }

        //close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
