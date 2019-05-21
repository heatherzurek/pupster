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
      return View();
    }


    [HttpGet("/dogs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/dogs")]
    public ActionResult Create(string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, string needsDescription, int id = 0)
    {
      Dog newDog = new Dog(name, photo, sex, breed, color, size, age, neuteredSpayed, shots, activity, goodWithDogs, goodWithCats, goodWithKids, houseTrained, goodAlone, needsDescription);
      newDog.Save();
      List<Dog> allDogs = Dog.GetAll();
        // int Id = id;
        // string Name = name;
        // string Photo = photo;
        // string Sex = sex;
        // string Breed = breed;
        // string Color = color;
        // string Size = size;
        // string Age = age;
        // bool NeuteredSpayed = neuteredSpayed;
        // bool Shots = shots;
        // string Activity = activity;
        // bool GoodWithDogs = goodWithDogs;
        // bool GoodWithCats = goodWithCats;
        // bool GoodWithKids = goodWithKids;
        // bool HouseTrained = houseTrained;
        // bool GoodAlone = goodAlone;
        // bool NeedsDescription = needsDescription;
      return View("Index", allDogs);
    }


    [HttpGet("/dogs/{id}")]
    public ActionResult Show(int id)
    {

      Dog selectedDog = Dog.Find(id);
      return View(selectedDog);
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

  }
}
