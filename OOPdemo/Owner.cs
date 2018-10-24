using System;
using System.Collections.Generic;
namespace OOPdemo
{
    public class Owner
    {
        public Owner(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        //Encapsulation. The private list below is protected from rest of the program, but it is still accessible with the public Adopt method.
        private List<Animal> Pets = new List<Animal>();

        public void Adopt(Animal pet)
        {
            Console.WriteLine($"I want {pet.Name} to come home with me.");
            Pets.Add(pet);
        }
    }
}
