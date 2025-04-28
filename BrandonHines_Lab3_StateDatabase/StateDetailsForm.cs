using System;
using System.Windows.Forms;
using ClassLibrary; // Ensure this namespace is correctly referenced

namespace BrandonHines_Lab3_StateDatabase
{
    public partial class StateDetailsForm : Form
    {
        private DataMngr dataManager; // Data manager instance
        private string selectedState; // Holds the selected state name

        // Constructor to accept the selected state name
        public StateDetailsForm(string stateName)
        {
            InitializeComponent();
            dataManager = new DataMngr();
            selectedState = stateName;
        }

        // Load state details when the form loads
        private void StateDetailsForm_Load(object sender, EventArgs e)
        {
            State state = dataManager.GetStateByName(selectedState); // Fetch state details

            // Display state details in the ListBox
            if (state != null)
            {
                // Clear the ListBox before adding new items
                lstStateDetails.Items.Clear();
                // Add state details to the ListBox
                lstStateDetails.Items.Add($"Name: {state.Name}");
                lstStateDetails.Items.Add($"Population: {state.Population:N0}");
                lstStateDetails.Items.Add($"Flag: {state.FlagDescription}");
                lstStateDetails.Items.Add($"Flower: {state.Flower}");
                lstStateDetails.Items.Add($"Bird: {state.Bird}");
                lstStateDetails.Items.Add($"Colors: {state.Colors}");
                lstStateDetails.Items.Add($"Largest Cities: {state.LargestCities}");
                lstStateDetails.Items.Add($"Capital: {state.Capital}");
                lstStateDetails.Items.Add($"Median Income: ${state.MedianIncome:N0}");
                lstStateDetails.Items.Add($"Computer Jobs: {state.CompJobsPercent}%");
            }
            else
            {
                MessageBox.Show("State details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes StateDetailsForm and returns to the previous form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the entire application
        }

        private void btnViewAllStates_Click(object sender, EventArgs e)
        {
            StateTableForm tableForm = new StateTableForm();
            tableForm.Show(); // Opens the StateTableForm
        }
    }
}
