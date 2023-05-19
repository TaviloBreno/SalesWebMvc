using Microsoft.AspNetCore.Mvc;
using System;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
