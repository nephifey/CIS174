﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Game Page";

            return View();
        }
    }
}
