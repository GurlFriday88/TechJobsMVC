using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //this initalizes a new dictionary object and adds the search and list options it
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
            //passes the action choices to the view
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
