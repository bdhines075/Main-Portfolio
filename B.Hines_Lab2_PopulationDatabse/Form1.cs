using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B.Hines_Lab2_PopulationDatabse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Load the data into the form
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        // Add a new city to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();  
                this.cityBindingSource.EndEdit();  
                this.cityTableAdapter.Update(this.cityDBDataSet.City);  
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //calculate population info into one button
        private void btnCalcPop_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

            // Calculate the total, average, highest, and lowest population
            int totalPopulation = this.cityDBDataSet.City.Sum(row => row.Population);
            double averagePopulation = this.cityDBDataSet.City.Average(row => row.Population);
            int highestPopulation = this.cityDBDataSet.City.Max(row => row.Population);
            int lowestPopulation = this.cityDBDataSet.City.Min(row => row.Population);

            // Display the results
            lblPopOutput.Text = $"Total Population: {totalPopulation}\n" +
                     $"Average Population: {averagePopulation:F2}\n" +
                     $"Highest Population: {highestPopulation}\n" +
                     $"Lowest Population: {lowestPopulation}";

        }

        //sort buttons
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            cityBindingSource.Sort = "Population ASC";// Sort the data in ascending order
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            cityBindingSource.Sort = "Population DESC";// Sort the data in descending order
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            cityBindingSource.Sort = "City ASC";// Sort the data by city name
        }
    }
}
