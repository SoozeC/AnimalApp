using System;

namespace AnimalApp
{
    public class Eagle : IBird
    {
        public Eagle(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine(Name + " is savaging a pigeon");
        }

        public void Fly()
        {
            Console.WriteLine(Name + "is soaring");
        }
    }
}
