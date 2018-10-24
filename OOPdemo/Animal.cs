using System;
namespace OOPdemo
{
    //Abstraction. This animal class is an abstract definition of the classes that inherit from it 
    //and contains properties and methods that are common among them.
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat(string foodType)
        {
            Console.WriteLine($"OmNom this is good {foodType}.");
        }
    }
}
