using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalApp
{
    public class Mammal : Animal
    {
        public void walk()
        {
            Console.WriteLine(@"{0} is walking", name);
        }
    }
}
