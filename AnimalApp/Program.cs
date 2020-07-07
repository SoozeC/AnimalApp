using System;
using System.Collections.Generic;

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

            Dog goodDog = new Dog("Maggie");

            AnimalHelpers suzie = new AnimalHelpers();

            List<Dog> dogList = new List<Dog> { new Dog("Fido"), new Dog("Rover"), new Dog("Bella"), new Dog("Ziggy") };

            var animalList = new List<IAnimal> { new Eagle("Fred"), new Robin("Sidney"), new Cat("Tiddles"), new Dog("Fonzie") };

            var sortedDogs = suzie.SortDogs(dogList);

            var sortedAnimals = suzie.SortAnimals(animalList);

            foreach (var item in sortedDogs) { Console.WriteLine(item.Name); } ;
            Console.WriteLine("--------------------------");

            foreach (var item in sortedAnimals) { Console.WriteLine(item.Name); };
            Console.WriteLine("--------------------------");

            niceKitty.Eat();
            badKitty.Eat();
            robin.Eat();
            eagle.Eat();
            goodDog.Eat();

            Console.WriteLine("--------------------------");

            niceKitty.Walk();
            badKitty.Walk();
            robin.Fly();
            eagle.Fly();
            goodDog.Walk();
        }
    }
}
