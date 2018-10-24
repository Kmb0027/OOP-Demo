using System;

namespace OOPdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("Mitchell");

            Dog dog = new Dog() { Name = "Snoopy", Age = 2 };
            owner.Adopt(dog);
            dog.Speak();
            dog.Speak(3);
        }
    }
}
