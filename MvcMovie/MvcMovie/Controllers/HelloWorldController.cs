using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    //return "This is the Welcome action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //public string Welcome(string name, int numTimes = 1, int ID = 1)
        //{
        //    //return "This is the Welcome action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
