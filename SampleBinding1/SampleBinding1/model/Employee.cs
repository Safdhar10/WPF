using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBinding1.model
{
    class Employee
    {
         public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string AadharNumber { get; set; }
        public string Designation { get; set; }
        public string Image { get; set; }
        public Employee()
        {

        }
        public Employee(string Name,int Age,string Mobile,string AadharNumber,string Designation,string Image)
        {
            this.Name = Name;
            this.Age = Age;
            this.Mobile = Mobile;
            this.AadharNumber = AadharNumber;
            this.Designation = Designation;
            this.Image = Image;
        }
    }
}
