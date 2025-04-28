using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonHines_Lab3_DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            /*Brandon Hines*
             *Lab 3*
             *CPT185*
             *Distance Converter*
             */
            


            try
            {
                //Declarations

                // User Input Dist
                double inputDistance = Convert.ToDouble(txtDist.Text);

                // List Selection
                string fromUnit = lstFrom.SelectedItem.ToString();
                string toUnit = lstTo.SelectedItem.ToString();

                // Conv TO Inch
                double distanceInInches = ConvertToInches(inputDistance, fromUnit);

                // Convert FROM Inch
                double convertedDistance = ConvertFromInches(distanceInInches, toUnit);

                // Construct the result string in the desired format
                string resultText = $"{inputDistance} {fromUnit.ToLower()} is {convertedDistance} {toUnit.ToLower()}";

                // Display the constructed sentence in the Label
                lblConvDist.Text = resultText;
            }
            catch (Exception ex)
            {
                //Error incorrect input
                MessageBox.Show("Error, " + ex.Message);
            }
        }

        // Convert TO Inch
        private double ConvertToInches(double distance, string fromUnit)
        {
            switch (fromUnit)
            {
                //Base
                case "Inches":
                    return distance;
                    // 12 In per Foot
                case "Feet":
                    return distance * 12; 
                    // 3 Feet per Yard
                case "Yards":
                    return distance * 36; 
                default:
                    throw new ArgumentException("ERROR! -Invalid- ");
            }
        }

        // Conv FROM Inch
        private double ConvertFromInches(double distanceInInches, string toUnit)
        {
            switch (toUnit)
            {
                //Base
                case "Inches":
                    return distanceInInches;
                    // 12 inches per foot
                case "Feet":
                    return distanceInInches / 12;
                    // 36 inches per yard
                case "Yards":
                    return distanceInInches / 36; // 36 Inches = 1 Yard
                default:
                    throw new ArgumentException("ERROR! -Invalid- ");
            }
        }

        // Exit btn
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close 
            this.Close();
        }
    }
}
        

