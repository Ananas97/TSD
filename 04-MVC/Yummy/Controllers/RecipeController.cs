using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yummy.Controllers
{
    public class RecipeController : Controller
    {
        //
        // GET: /Recipe/list
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "This is the Index action method...";
        }

        // 
        // GET: /Recipe/add

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
