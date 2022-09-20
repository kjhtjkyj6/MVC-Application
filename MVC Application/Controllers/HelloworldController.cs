﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
namespace MVC_Application.Controllers
{
    public class HelloworldController : Controller
    {
        /*        public IActionResult Index()
                {
                    return View();
                }*/

        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }


    }
}
