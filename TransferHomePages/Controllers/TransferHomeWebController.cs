using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TransferHomePages.Controllers
{
    public class TransferHomeWebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
       [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }

        [Route("Help")]
        public IActionResult Help()
        {
            return View();
        }


        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Terms")]
        public IActionResult Terms()
        {
            return View();
        }
    }
}