using System;

namespace AnimalApp
{
    public class Bird : Animal
    {

        public void fly()
        {
            Console.WriteLine(@"{0} is flying", name);
        }
    }
}
