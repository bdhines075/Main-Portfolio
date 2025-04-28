using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonHines_Lab9_ClassesCont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dorm cost method
        private int DormCost()
        {
            string dormChoice = string.Empty;//initialize string to empty

            //initialize radio buttons
            if (rbtnAllenHall.Checked) dormChoice = "Allen Hall";
            else if (rbtnPikeHall.Checked) dormChoice = "Pike Hall";
            else if (rbtnFarthingHall.Checked) dormChoice = "Farthing Hall";
            else if (rbtnUniversitySuites.Checked) dormChoice = "University Suites";
            else dormChoice = "Please Choose A Dorm";

            //switch statement to determine cost of dorm
            switch (dormChoice)
            {
                case "Allen Hall":
                    return 1500;
                case "Pike Hall":
                    return 1600;
                case "Farthing Hall":
                    return 1800;
                case "University Suites":
                    return 2500;
                default:
                    return 0;
            }
        
        }
        //meal cost method
        private int MealChoice()
        { 
            string mealChoice = string.Empty;//initialize string to empty

            //initialize radio buttons
            if (rbtn7Meals.Checked) mealChoice = "7 Meals";
            else if (rbtn14Meals.Checked) mealChoice = "14 Meals";
            else if (rbtnUnlimitedMeals.Checked) mealChoice = "Unlimited Meals";
            else mealChoice = "Please Choose A Meal Plan";

            //switch statement to determine cost of meal plan
            switch (mealChoice)
            {
                case "7 Meals":
                    return 600;
                case "14 Meals":
                    return 1200;
                case "Unlimited Meals":
                    return 1700;
                default:
                    return 0;
            }
        }

        //validate selections method
        private bool ValidateSelections()
        {
            //if statements to validate dorm selection
            if (!(rbtnAllenHall.Checked || rbtnPikeHall.Checked || rbtnFarthingHall.Checked || rbtnUniversitySuites.Checked))
            {
                MessageBox.Show("Please select a dormitory.", "Error- no selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if statements to validate meal plan selection
            if (!(rbtn7Meals.Checked || rbtn14Meals.Checked || rbtnUnlimitedMeals.Checked))
            {
                MessageBox.Show("Please select a meal plan.", "Error- no selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if both selections are made, return true
            return true;
        }
        //next button
        private void btnNext_Click(object sender, EventArgs e)
        {
            //validate selections
            if (!ValidateSelections()) return;


            //variables to hold the cost of the dorm and meal plan
            int dormCost = DormCost();
            int mealCost = MealChoice();
            int totalCost = dormCost + mealCost;

            //create a new instance of form2 and pass cost choices
            Form2 secondForm = new Form2(totalCost,dormCost,mealCost); 
            secondForm.ShowDialog();
        }

        //exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all radio button selections
            rbtnAllenHall.Checked = false;
            rbtnPikeHall.Checked = false;
            rbtnFarthingHall.Checked = false;
            rbtnUniversitySuites.Checked = false;

            rbtn7Meals.Checked = false;
            rbtn14Meals.Checked = false;
            rbtnUnlimitedMeals.Checked = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
