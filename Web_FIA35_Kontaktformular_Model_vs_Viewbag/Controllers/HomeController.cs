using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_FIA35_Kontaktformular_Model_vs_Viewbag.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Person());
        }

        [HttpPost]
        public IActionResult Index(string inpNameVB, string inpLieblingsfarbeVB, string inpNameModel, string inpLieblingsfarbeModel)
        {
            ViewBag.Name = inpNameVB;
            ViewBag.Lieblingsfarbe = inpLieblingsfarbeVB;
            Person person = new Person { name = inpNameModel, lieblingsFarbe = inpLieblingsfarbeModel };

            return View(person);
        }
    }
}
