using Microsoft.AspNetCore.Mvc;
using Mission4WebApp.Models; //using that models folder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4WebApp.Controllers
{
    public class BlahController : Controller //class called BlahController inherits from Controller
    {
        public IActionResult Index ()
        {            
            return View();
        }

        [HttpGet] //this is the Get attribute for this method
        public IActionResult formView ()
        {
            return View(); //by not putting anyting in (), it defaults to the view specified (here it is the formView) one
        }
        [HttpPost] //here is the post attribute for this method
        public IActionResult formView (formViewModel model) //this is an overridden method; repeat; "model" is just the object name, could be whatever
        {
            return View();
        }

    }
}
