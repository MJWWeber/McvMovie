using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McvMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index() //original default code
        //{
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);

            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}