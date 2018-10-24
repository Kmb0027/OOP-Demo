using System;
namespace OOPdemo
{
    //Inheritance. Below, the dog inherits the properties and methods of the Animal class because
    //all dogs are animals, but not all animals are dogs.
    public class Dog : Animal
    {
        //Polymorphism. The two methods below each have the same name and similar functionality, but
        //the second method takes an int parameter that determines the number of times the dog will speak.
        public void Speak()
        {
            Console.WriteLine("Bark!");
        }
        public void Speak(int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.Write("Bark!");
            }
        }
    }
}
