using System;

namespace AnimalApp
{
    public class Robin : IBird
    {
        public Robin(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine(Name + " is at the bird table");
        }

        public void Fly()
        {
            Console.WriteLine(Name + " fluttering away!");
        }
    }
}
