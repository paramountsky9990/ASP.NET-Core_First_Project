using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my test action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
