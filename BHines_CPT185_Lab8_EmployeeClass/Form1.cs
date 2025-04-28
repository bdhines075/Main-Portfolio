using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHines_CPT185_Lab8_EmployeeClass
{

    /**
     * Brandon Hines*
     * CPT185*
     * Lab8*
     * Employee Class*
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
           

            //Constructs employees per info given
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

            //preemptively clears output incase of multiple clicks
            string output = string.Empty;

            //display with some formatting for specific info, will not be dynamic for other info but looks fine for this input
            output += "Name,                        ID,          Department,               Position" + Environment.NewLine;
            output += "-------------------------------------------------------------------------------" + Environment.NewLine;
            output += employee1.Name + ",     " + employee1.ID + ",     " + employee1.Department + ",     " + employee1.Position + Environment.NewLine;
            output += employee2.Name + ",     " + employee2.ID + ",                  " + employee2.Department + ",              " + employee2.Position + Environment.NewLine;
            output += employee3.Name + ",     " + employee3.ID + ",     " + employee3.Department + ",     " + employee3.Position;
            
            txtOutput.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;  //Clears          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//Exits
        }
    }
}




