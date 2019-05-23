using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pupster.Models;


namespace Pupster.Controllers
{
  public class DogsController : Controller
  {

    [HttpGet("/dogs")]
    public ActionResult Index()
    {
      List<Dog> allDogs = Dog.GetAll();
      return View(allDogs);

    }

    [HttpGet("/dogs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/dogs")]
    public ActionResult Create(string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, string needsDescription)
    {
      Dog newDog = new Dog(name, photo, sex, breed, color, size, age, neuteredSpayed, shots, activity, goodWithDogs, goodWithCats, goodWithKids, houseTrained, goodAlone, needsDescription);
      newDog.Save();
      List<Dog> allDogs = Dog.GetAll();

      return RedirectToAction("Index");
    }

    [HttpPost("/dogs/search")]
    public ActionResult Search(string dogName)
    {
      Dog selectedDog = Dog.Search(dogName);
      if(selectedDog.Id == 0)
      {
        List<Dog> allDogs = Dog.GetAll();
        return View("Search", allDogs);
      }
      return RedirectToAction("Show", selectedDog);
    }




    [HttpGet("/dogs/{id}")]
    public ActionResult Show(int id)
    {
      Dog selectedDog = Dog.Find(id);
      return View(selectedDog);
    }


    [HttpGet("/dogs/resources")]
    public ActionResult Resources()
    {
      return View();
    }

    // [HttpPost("/dogs/{dogId}")]
    // public ActionResult GetDogDetails(string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, bool needsDescription, int id = 0)
    // {
    //   Dog foundDog = Dog.Find(dogId);
    //   foundDog.GetDetails();
    //   return View("Show", foundDog);
    // }

    [HttpPost("/dogs/{dogId}/delete-dog")]
    public ActionResult DeleteDog(int dogId)
    {
      Dog selectedDog = Dog.Find(dogId);
      selectedDog.DeleteDog(dogId);

      return RedirectToAction("Show", "Dogs");
    }
    //
    // [HttpPost("/dogs/delete-all-dogs")]
    // public ActionResult DeleteAllSty()
    // {
    //   Dog.ClearAll();
    //   return RedirectToAction("Index", "Home");
    // }
    // [HttpPost("/dogs/search")]
    // public ActionResult SearchByDog(string name)
    // {
    //   // Book searchBook = new Book(title);
    //   // searchBook.Save();
    //   List<Dog> matchDogs = new List<Dog>{};
    //   matchDogs.Add(Dog.Search(name));
    //   return View("Index", matchDogs);
    // }



  }
}
