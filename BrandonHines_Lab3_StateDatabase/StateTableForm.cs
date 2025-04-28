using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;

namespace BrandonHines_Lab3_StateDatabase
{
    public partial class StateTableForm : Form
    {
        private DataMngr dataManager;
        private BindingSource bindingSource; // BindingSource for sorting

        // Constructor
        public StateTableForm()
        {
            InitializeComponent();
            dataManager = new DataMngr();
            bindingSource = new BindingSource();
        }

        private void StateTableForm_Load(object sender, EventArgs e)
        {
            LoadStates(); // Load all states into the DataGridView when the form loads
        }

        // Load all states into the DataGridView
        private void LoadStates()
        {
            var states = dataManager.GetAllStates();

            if (states == null || states.Count == 0)
            {
                MessageBox.Show("No states found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bindingSource.DataSource = states;
            dgvStates.DataSource = bindingSource;

            // Enable automatic column sorting
            dgvStates.AutoGenerateColumns = true;
            dgvStates.AllowUserToAddRows = false;
            dgvStates.AllowUserToResizeColumns = true;
            dgvStates.ReadOnly = true;
            dgvStates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Enable sorting when clicking on column headers
        private void dgvStates_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvStates.Columns[e.ColumnIndex].DataPropertyName;

            // Sort in ascending or descending order
            List<State> sortedList = ((List<State>)bindingSource.DataSource)
                .OrderBy(state => state.GetType().GetProperty(columnName).GetValue(state, null))
                .ToList();

            bindingSource.DataSource = sortedList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes StateTableForm and returns to the previous form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the entire application
        }
    }
}
