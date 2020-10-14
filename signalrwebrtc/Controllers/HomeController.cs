﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoChat.Models;

namespace signalrwebrtc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}
		public ActionResult Chat()
		{
			return View();
		}
		public ActionResult Login()
		{
			return View(new LoginView());
		}
		public ActionResult Login(LoginView loginView)
		{
			return RedirectToAction("Index", "Home");
		}
	}
}
