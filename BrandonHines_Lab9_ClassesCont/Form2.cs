using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonHines_Lab9_ClassesCont
{
    public partial class Form2 : Form
    {
        //constructor for form 2
        public Form2(int totalCost,int dormCost,int mealCost)
        {
            InitializeComponent();

            //output the total cost of the dorm and meal plan
            lblOutput.Text = $"Dorm: ${dormCost}\nMeal Plan: ${mealCost}\n\nTotal Charges: ${totalCost}\nThank you for choosing us to help you achieve your dreams.\n\n #Chase it, Dream it, Live it!!";
        }

        //button to close form 2
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();//closes form two, while leaving form 1 as if it was "going back"
        }

        //button to exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
