using OOP_Examples;

Console.WriteLine("Basic Principles OOP");

Console.WriteLine("Inheritance;");
Inheritance ınheritance = new Inheritance();
ınheritance.getInheritance();

Console.WriteLine("Polymorphism;");
Polymorphism.Square s1 = new Polymorphism.Square();
Polymorphism.Circle c1 = new Polymorphism.Circle();
s1.Draw();
c1.Draw();

Console.WriteLine("Encapsulation:");
Encapsulation encapsulation = new Encapsulation();
encapsulation.getNameAge();

Console.WriteLine("Abstract Class");
AbstractClass.Info n1 = new AbstractClass.Note();
AbstractClass.Info n2 = new AbstractClass.Data();

n1.InformationAdded();
n1.InformationDeleted();

n2.InformationAdded();
n2.InformationDeleted();
