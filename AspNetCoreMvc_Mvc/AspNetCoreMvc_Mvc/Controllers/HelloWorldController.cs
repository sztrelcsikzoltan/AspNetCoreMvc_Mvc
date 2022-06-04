using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace AspNetCoreMvc_Mvc.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: /HelloWorld/
        public string Index() // Index() is the name of the default action for HelloWorld
        {
            return "The string Index() method returns this value as the default action, which is envoked by appending /HelloWorld/ to the base URL. \nClose this tab to return to the example page.";
        }

        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method. Note that the URL contains its name after the name of the HelloWorld controller. \nClose this tab to return to the example page.";
        }

        // GET: /HelloWorld/WelcomeByName/ 
        public string WelcomeByName(string name = "Rick", int numTimes = 5)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // GET: /HelloWorld/WelcomeByParameter/ 
        public string WelcomeByParameter(string name = "Rick", int id = 5)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, your id is: {id}");
        }

        public IActionResult WelcomeByView(string name, int numTimes = 10)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
    }
