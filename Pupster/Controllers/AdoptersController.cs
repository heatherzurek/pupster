using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pupster.Models;


namespace Pupster.Controllers
{
  public class AdoptersController : Controller
  {

    [HttpGet("/adopters")]
    public ActionResult Index()
    {
      return View();
    }

    // [HttpGet("/adopter/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    [HttpPost("/adopter")]
    public ActionResult QuizMatch(int adopterId, int dogId, string question1, string question2, string question3, bool question4, bool question5, bool question6, bool question7, bool question8, int id)
    {
      Result newResult = new Result(adopterId, dogId);
      newResult.Loop(question1, question2, question3, question4, question5, question6, question7, question8, id);

      return RedirectToAction("Index");
    }



        // [HttpGet("/dogs/{id}")]
        // public ActionResult Show(int id)
        // {
        //
        //   Dog selectedDog = Dog.Find(id);
        //   return View(selectedDog);
        // }
        //
        //
        // [HttpGet("/dogs/resources")]
        // public ActionResult Resources()
        // {
        //   return View();
        // }
        //
        // // [HttpPost("/dogs/{dogId}")]
        // // public ActionResult GetDogDetails(string name, string photo, string sex, string breed, string color, string size, string age, bool neuteredSpayed, bool shots, string activity, bool goodWithDogs, bool goodWithCats, bool goodWithKids, bool houseTrained, bool goodAlone, bool needsDescription, int id = 0)
        // // {
        // //   Dog foundDog = Dog.Find(dogId);
        // //   foundDog.GetDetails();
        // //   return View("Show", foundDog);
        // // }
        //
        // [HttpPost("/dogs/{dogId}/delete-dog")]
        // public ActionResult DeleteDog(int dogId)
        // {
        //   Dog selectedDog = Dog.Find(dogId);
        //   selectedDog.DeleteDog(dogId);
        //
        //   return RedirectToAction("Show", "Dogs");
        // }
        // //
        // // [HttpPost("/dogs/delete-all-dogs")]
        // // public ActionResult DeleteAllSty()
        // // {
        // //   Dog.ClearAll();
        // //   return RedirectToAction("Index", "Home");
        // // }
        //
        // [HttpPost("/dogs/search")]
        // public ActionResult SearchByName(string name)
        // {
        //   // Dog searchDog = new Dog(title);
        //   // searchDog.Save();
        //   List<Dog> matchDogs = new List<Dog>{};
        //   matchDogs.Add(Dog.Search(name));
        //   return View("Index", matchDogs);
        // }

      }
    }
