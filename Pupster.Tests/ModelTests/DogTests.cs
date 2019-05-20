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
      Dog newDog = new Dog("Name", "Photo", "Sex", "Breed", "Color", "Size", "Age", true, true, "Activity", true, true, true, true, true, true);

      Assert.AreEqual(typeof(Dog), newDog.GetType());
    }
  }
}
