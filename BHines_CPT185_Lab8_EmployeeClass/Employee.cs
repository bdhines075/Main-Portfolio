using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHines_CPT185_Lab8_EmployeeClass
{
    public class Employee
    {
        //declaration of variables
        public string Name { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        // Constructor with default/empty values
        public Employee(string name = "", int id = 0, string department = "", string position = "")
        {
            Name = name;
            ID = id;
            Department = department;
            Position = position;
        }
    }

}
