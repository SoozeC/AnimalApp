using System;

namespace AnimalApp
{
    public class Dog : IMammal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating Bakers Complete");
        }

        public void Walk()
        {
            Console.WriteLine(Name + " is walking on four legs");
        }
    }
}
