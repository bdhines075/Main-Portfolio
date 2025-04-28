using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace BrandonHines_Lab3_StateDatabase
{
    public partial class Form1 : Form
    {
        private DataMngr dataManager;// Create a data manager object

        public Form1()
        {
            InitializeComponent();
            dataManager = new DataMngr();// Initialize the data manager object
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStates(); // Populate ComboBox
        }

        private void LoadStates()
        {
            comboxStates.Items.Clear(); // Ensure ComboBox starts empty

            var states = dataManager.GetAllStates(); // Fetch states from the database

            if (states == null || states.Count == 0)
            {
                MessageBox.Show("No states found in the database. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder stateList = new StringBuilder(); // To store state names for MessageBox

            foreach (var state in states)
            {
                comboxStates.Items.Add(state.Name);
                stateList.AppendLine(state.Name); // Add each state name to the list
            }

            MessageBox.Show($"Loaded {states.Count} states:\n{stateList}", "State Load Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboxStates_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedState = comboxStates.SelectedItem.ToString(); // Get the selected state

            // Open the state details form and pass the selected state
            StateDetailsForm detailsForm = new StateDetailsForm(selectedState);
            detailsForm.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Check if a state is selected
            if (comboxStates.SelectedItem == null)
            {
                MessageBox.Show("Please select a state.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedState = comboxStates.SelectedItem.ToString(); // Get selected state

            // Open StateDetailsForm and pass the selected state name
            StateDetailsForm detailsForm = new StateDetailsForm(selectedState);
            detailsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the entire application
        }

        private void btnViewAllStates_Click(object sender, EventArgs e)
        {
            StateTableForm tableForm = new StateTableForm();
            tableForm.Show(); // Opens the StateTableForm to view all states
        }
    }
}
