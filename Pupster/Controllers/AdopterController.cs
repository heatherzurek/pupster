// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Pupster.Models;
//
// namespace Pupster.Controllers
// {
//
//
//   public class AdopterController : Controller
//   {
//
//     [HttpGet("/adopters")]
//     public ActionResult Index()
//     {
//       List<Adopter> allAdopters = Adopter.GetAll();
//       return View(allAdopters);
//     }
//
//     [HttpGet("/adopters/new")]
//     public ActionResult New()
//     {
//       return View();
//     }
//
//     // [HttpPost("/adopters")]
//     // public ActionResult Create(string adopterName)
//     // {
//     //   Adopter newAdopter = new Adopter(adopterName);
//     //   newAdopter.Save();
//     //   List<Adopter> allAdopters = Adopter.GetAll();
//     //   return View("Index", allAdopters);
//     // }
//
//   }
// }
