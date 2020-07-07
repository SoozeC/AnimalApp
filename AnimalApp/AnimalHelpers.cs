using System.Collections.Generic;
using System.Linq;

namespace AnimalApp
{
    public class AnimalHelpers
    {
        public IEnumerable<IAnimal> SortAnimals(List<IAnimal> unorderedAnimals)
        {
            return unorderedAnimals.OrderBy(a => a.Name).ToArray();
        }
        public List<Dog> SortDogs(List<Dog> unorderedDogs)
        {
            return unorderedDogs.OrderBy(d => d.Name).ToList();
        }
    }
}
