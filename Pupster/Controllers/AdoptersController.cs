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

    [HttpPost("/adopter")]
    public ActionResult QuizMatch(int adopterId, string question1, string question2, string question3, bool question4, bool question5, bool question6, bool question7, bool question8, string question9)
    {
      Adopter newAdopter = new Adopter(adopterId);
      Adopter.ClearAll();
      newAdopter.Result(question1, question2, question3, question4, question5, question6, question7, question8, question9);

      var model = Adopter.GetSortedResults();
      return View("Show", model);
    }
  }
}
