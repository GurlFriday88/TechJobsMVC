
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        
        // search request and display results

        
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dictionary<String, String>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            ViewBag.jobs = jobs;
            ViewBag.selectedSearchTerm = searchTerm;
            ViewBag.columns = ListController.columnChoices;
            return View("Index");

           
            

        }

    }
}
