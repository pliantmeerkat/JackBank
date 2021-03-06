﻿using JackBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JackBank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new UserContext())
            {
                var users = context.Users.ToArray();
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}