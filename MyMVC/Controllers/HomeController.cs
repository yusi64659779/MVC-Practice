﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Homepage");
        }

        [HttpGet]
        public ViewResult StudentLoginForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StudentLoginForm(StudentLogin students)
        {
            Repository.AddStudent(students);
            return View("Welcomepage", students);
        }

        

        /*
       public IActionResult About()
       {
           ViewData["Message"] = "Your application description page.";

           return View();
       }

       public IActionResult Contact()
       {
           ViewData["Message"] = "Your contact page.";

           return View();
       }

       public IActionResult Privacy()
       {
           return View();
       }

       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
       public IActionResult Error()
       {
           return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       }
       */
    }
}