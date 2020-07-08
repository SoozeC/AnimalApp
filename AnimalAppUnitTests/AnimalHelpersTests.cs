using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalApp;
using System.Collections.Generic;
using System.Linq;

namespace AnimalAppUnitTests
{
    [TestClass]
    public class AnimalHelpersTests
    {
        private AnimalHelpers _sut;


        [TestInitialize]
        public void TestInitialize()
        {
           _sut = new AnimalHelpers();
        }

        [TestMethod]
        public void SortAnimals_AnimalsOrderedCorrectly()
        {
            // Arrange
            var animalList = createAnimalList();

            // Act
            var result = _sut.SortAnimals(animalList);

            // Assert
            CollectionAssert.AreEqual(animalList.OrderBy(a => a.Name).ToList(), result.ToList());
        }

        private List<IAnimal> createAnimalList()
        {
            return new List<IAnimal>() { new Eagle("Fred"), new Robin("Sidney"), new Cat("Tiddles"), new Dog("Fonzie") };
        }
    }
}
