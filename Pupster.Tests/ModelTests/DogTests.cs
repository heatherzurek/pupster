using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pupster.Models;
using System.Collections.Generic;
using System;

namespace Pupster.Tests
{
  [TestClass]
  public class DogTest : IDisposable
  {
    public void Dispose()
    {
      Dog.ClearAll();
    }

    public DogTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=pupster_tests;";
    }

    [TestMethod]
    public void DogConstructor_CreatesInstanceOfDog_Dog()
    {
      Dog newDog = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "string");

      Assert.AreEqual(typeof(Dog), newDog.GetType());
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfNamesAreTheSame_Dog()
    {
      Dog firstDog = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "Description");
      Dog secondDog = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "Description");

      Assert.AreEqual(firstDog, secondDog);
    }

    [TestMethod]
    public void GetAll_ReturnsAllDogObjects_DogList()
    {
      //Arrange
      Dog newDog1 = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "Description");
      newDog1.Save();
      Dog newDog2 = new Dog("Floof", "Photo", "M", "Big", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "Description");
      newDog2.Save();
      List<Dog> newList = new List<Dog> { newDog1, newDog2 };

      //Act
      List<Dog> result = Dog.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Save_SavesToDatabase_DogList()
    {
      //Arrange
      Dog testDog = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, "Description");

      //Act
      testDog.Save();
      List<Dog> result = Dog.GetAll();
      List<Dog> testList = new List<Dog>{testDog};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }



  }
}
