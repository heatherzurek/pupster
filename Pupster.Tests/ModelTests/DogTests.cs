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
    [TestMethod]
    public void Get_ReturnsCategoryId_Int()
    {
      //arrange
      Dog newDog = new Dog("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription", 0);

      //act
      int result = newDog.Id;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      //arrange
      // string name1 ="Bingo";
      // string name2 = "Fido";
      Dog newDog1 = new Dog("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription");
      newDog1.Save();
      // Dog newDog2 = new Dog("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription", 0);

      //act
      Dog result = Dog.Find(newDog1.Id);

      //assert
      Assert.AreEqual(newDog1, result);
    }
    [TestMethod]
    public void Edit_UpdateDogInDatabase_String()
    {
      Dog testDog = new Dog ("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription", 1);
      testDog.Save();

      Dog compareDog = new Dog ("puppy1", "photo1", "sex1", "string breed1", "string color1", "string size1", "string age", true, true, "string activity1", true, true, true, true, true, "string needsDescription1");

      testDog.Edit("puppy1", "photo1", "sex1", "string breed1", "string color1", "string size1", "string age", true, true, "string activity1", true, true, true, true, true, "string needsDescription1");
      testDog.Save();


      Dog result = Dog.Find(testDog.Id);
      Console.WriteLine(compareDog.Name);
      Console.WriteLine(testDog.Name);

      Assert.AreEqual(compareDog, testDog);
    }
  }
}
