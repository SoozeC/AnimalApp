using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat badKitty = new Cat("Bruiser");
            Cat niceKitty = new Cat("Snuggles");

            Robin robin = new Robin("Rodney");
            Eagle eagle = new Eagle("Eddie The Eagle");

            Dog badDog = new Dog();

            niceKitty.eat();
            badKitty.eat();
            robin.eat();
            eagle.eat();
            badDog.eat();

            Console.WriteLine("--------------------------");

            niceKitty.walk();
            badKitty.walk();
            robin.fly();
            eagle.fly();
            badDog.walk();
        }
    }
}
