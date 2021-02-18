using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
            
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis ducimus fugiat, laborum error aspernatur nisi natus molestiae incidunt maiores quam sapiente quaerat dignissimos nulla temporibus tempore reiciendis! Velit, quidem veniam.";
        
            return View("Index",message);
        }
        //-----------------------------------------------------------------

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] number = new int[]
                {
                    1,2,3,4,5
                };
            return View(number);
        }

        //----------------------------------------------------------------
        //this has to be a list...
        [HttpGet("users")]
        public IActionResult Users()
        {
            string[] allUsers = new string[]
            {
                "Moose Philips",
                "Sarah",
                "Jerry",
                "Rene Ricky",
                "Ricky Bobby",
            };
            Console.WriteLine("All users are added in ===========");
        return View(allUsers);
        }

        //-----------------------------------------------------------

        [HttpGet("user")]
        public IActionResult UserOne()
        {
            var user = new ViewModel[]
            {
            new ViewModel
                {
                    FirstName = "Ricky",
                    LastName = "Bobby",
                }
            };
        return View(user);
        }
        
        
    }
}
