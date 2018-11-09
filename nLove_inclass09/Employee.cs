using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass09
{
    class Employee : Person, IWorkable
    {
        private readonly string _employeeID;

        //have to have {} - because t's a method and needs body/ definition - even empty
        public Employee() : this("Mary", 28) { }

        public Employee(string name, int age) : base(name, age) {

            _employeeID = "E" + (numOfPersons = 100000).ToString();

        }

        public string EmployeeID {get { return _employeeID; } }

        public string Work() {

            return "I love my job!";
        }

        public override string SayFarewell()
        {
            return "Can't believe this day is over!";
        }

        //ToString - returns a string by default ("nLove_inclass09.Student") - 
        // is commonly overrriden - for some output (printInfo)
        public override string ToString()
        {// {0,25} - 0 - the position, 25- how many characters
            return String.Format("Name:{0, 25} | Age: {1,3} | Employee ID : {2, 10}.", Name, Age, EmployeeID) ;
        }
    }
}
