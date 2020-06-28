using System;

namespace AnimalApp
{
    public class Animal
    {
        public string name;

        public Animal(string name = "Billy no-name") 
        {
            this.name = name;
        }

        public void eat()
        {
            Console.WriteLine(@"{0} is eating", name);
        }
    }
}
