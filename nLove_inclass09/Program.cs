using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass09
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Natasha", 18);
            Console.WriteLine(s.Greet());
            Console.WriteLine(s.Work());
            Console.WriteLine(s.SayFarewell());

            Console.WriteLine(s.ToString());

            Employee[] e = new Employee[3];
            e[0] = new Employee("Greg", 39);
            e[1] = new Employee("Dave", 30);
            e[2] = new Employee("Mary", 40);

            //This loop lines up the rows in a neat way
            for (int i = 0; i < e.Length; i++)
            {
                //uses overriden ToString() from employee
                Console.WriteLine(e[i].ToString());
            }

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
