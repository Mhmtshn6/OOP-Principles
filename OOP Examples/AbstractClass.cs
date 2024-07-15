using OOP_Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An abstract class is a base class from which other classes are derived. 
//Abstract classes cannot be instantiated directly and typically contain incomplete methods. 
//These methods must be implemented by derived classes.

namespace OOP_Examples
{
    internal class AbstractClass
    {
        public abstract class Info   // Abstract base class for information management
        {
            public void InformationAdded()
            {
                Console.WriteLine("Succesful");
            }

            public abstract void InformationDeleted();  // Abstract method to be implemented by derived classes
        }

        public class Note : Info
        {
            public override void InformationDeleted()
            {
                Console.WriteLine("Note is Deleted");// Implementation of InformationDeleted for notes
            }
        }

        public class Data : Info
        {
            public override void InformationDeleted()// Implementation of InformationDeleted for data
            {
                Console.WriteLine("Data is Deleted");
            }
        }
    }
}