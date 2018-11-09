using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass09
{
   abstract class Person
    {
        private string _name;
        private int _age;

        protected static int numOfPersons = 0;

        //this- constructor from this class and sends info into empty constructor (in case it is called)
        public Person() : this("Jeff", 62) { }
        public Person (string name, int age)
        {
            numOfPersons++;
            Name = name;
            Age = age; 

        }
        // public properties are with Capital letter
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Age {
            get { return _age; }
            set { _age = (value >= 0) ? value : 0; }

        }
        // in virtual methods we can define the body
        public virtual string Greet() {
            return String.Format("Hello! My name is {0}, and I am {1} years old.", Name, Age);

        }

        // in abstract methods (has to be in abstract class) - no definition in the parent abstract class
        public abstract string SayFarewell();

    }
}
