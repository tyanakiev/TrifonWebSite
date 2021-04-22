using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace TrifonYanakiev.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("error/{code:int}")]
        public IActionResult Error(int code)
        {
            return View("Error");
        }
    }
}