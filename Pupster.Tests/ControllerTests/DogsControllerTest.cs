using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Pupster.Controllers;
using Pupster.Models;

namespace Pupster.Tests
{
    [TestClass]
    public class DogsControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        DogsController controller = new DogsController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void Index_HasCorrectModelType_DogList()
      {
        //Arrange
        DogsController controller = new DogsController();
        ViewResult indexView = controller.Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Dog>));
      }
      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        DogsController controller = new DogsController();

        //Act
        IActionResult view = controller.Create("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription");

        //Assert

        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }
      // [TestMethod]
      // public void Create_RedirectsToCorrectAction_Index()
      // {
      //   //Arrange
      //   DogsController controller = new DogsController();
      //   RedirectToActionResult actionResult = controller.Create("puppy", "photo", "sex", "string breed", "string color", "string size", "string age", true, true, "string activity", true, true, true, true, true, "string needsDescription", 0) as RedirectToActionResult;
      //
      //   //Act
      //   // string result = actionResult.ActionName;
      //
      //   //Assert
      //   Assert.AreEqual(actionResult.ActionName, "Index");
      // }

    }
}
