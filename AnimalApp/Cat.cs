using System;

namespace AnimalApp
{
    public class Cat : IMammal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating Whiskas");
        }

        public void Walk()
        {
            Console.WriteLine(Name + " walking on four legs");
        }
    }
}
