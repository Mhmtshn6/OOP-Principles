using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Encapsulation is the process of bundling data and methods that operate on that data into a single unit, or class.
//It restricts direct access to some of an object's components, protecting the data and providing controlled access.

namespace OOP_Examples
{
    internal class Encapsulation
    {
        public void getNameAge()
        {
            Informationn ınformation = new Informationn();
            ınformation.Name = "Mehmet";
            ınformation.Age = 22;

            Console.WriteLine("Name = {0}, Age = {1}", ınformation.Name, ınformation.Age);
        }
    }
    public class Informationn   // Class demonstrating encapsulation
    {
        private string name;
        private int age;
        // Private field for name and age

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
