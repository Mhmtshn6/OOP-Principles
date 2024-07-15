using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Inheritance is the process by which a class (called a subclas or derived class) inherits properties,
//Behaviors (methods) from another class (called base class)
//It reduces code duplication and helps organize code more effectively.

namespace OOP_Examples
{
    public class Inheritance
    {
        public void getInheritance()
        {
            TeachersInformation teacher1 = new TeachersInformation();
            teacher1.Name = "Admin";
            teacher1.Age = 19;

            StudentInformation student1 = new StudentInformation();
            student1.Name = "Adam";
            student1.Age = 05;
            student1.StudentNumber = 6868;

            Console.WriteLine("Teacher Name = {0} , Teacher Age = {1}", teacher1.Name, teacher1.Age);
            Console.WriteLine("Student Name = {0} , Student Age = {1},Student Number = {2}", student1.Name, student1.Age, student1.StudentNumber);
        }

    }
    public class Information    // Base class for holding common information
    {
        public string Name;
        public int Age;
        // Property to store the name and age
    }
    public class TeachersInformation : Information { }

    public class StudentInformation : Information
    {
        public int StudentNumber;
    }
}



