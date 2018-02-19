using MvcMovie.Mockers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public ActionResult MyCustomView()
        {
            var meowList = new MeowList();
            ViewBag.MeowList = meowList.GetMockup();
            //meowList.DoSomething();

            return View();
        }

        //
        //GET: /HelloWorld/Welcome/
        /*  
        public string Welcome()
        {
           return "This is the Welcome action method...";
        }
        
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is: " + numTimes);

        }*/
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }

}