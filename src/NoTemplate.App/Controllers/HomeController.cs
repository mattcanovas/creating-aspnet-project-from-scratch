﻿using Microsoft.AspNetCore.Mvc;

namespace NoTemplate.App.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
