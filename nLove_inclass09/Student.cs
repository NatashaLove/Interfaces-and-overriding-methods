using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass09
{
    //class Student extends (:) Person and implements interface IWorkable
    // If only IMPLEMENT interface - class Student : IWorkable (can implement several interfaces - through comma: IWorkable, IComparable, etc)

    class Student : Person, IWorkable
    {
        // readonly- is the same as final almost
        // if value not assigned- it can be assigned in a constructor later
        private readonly string _studentID;

        //this - for the default constr to call the custom constructor with args
        public Student() : this("Jeff", 62) { }

        //base - calls the constructor with args from Person class
        public Student(string name, int age) : base(name, age) {

            //numOfPersons is accessible because it's in the same project and Person class is protected
            _studentID = "S" + (numOfPersons + 100000).ToString();
        }

        // property with a getter
        public string StudentID { get { return _studentID; } }

        public string Work() {
            return "I'm tired.";

        }

        public override string Greet()
        {// base.Greet()- takes method from Person / the previous class - immediate
            return String.Format("{0} My student ID is  {1}.", base.Greet(), StudentID);
        }

        public override string SayFarewell()
        {
            return "Good-bye";
        }


    }
}
