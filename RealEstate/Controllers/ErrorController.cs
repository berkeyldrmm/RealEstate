﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ErrorPage(int code)
        {
            if (code == 404)
            {
                return View("NotFound");
            }
            return View(code);
        }
    }
}
