
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

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        [HttpPost]
        public IActionResult Result(string searchType, string searchTerm)
        {
            List<Dictionary<String, String>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            ViewBag.jobs = jobs;
            ViewBag.selectedSearchTerm = searchTerm;
            ViewBag.columns = ListController.columnChoices;
            return View();

            //List<Dictionary<string, string>> jobs = JobData.FindAll();
            ////when the user selects a search type ("skill") search each dictionary for that matching column
            ////for each dictionary job in the list of jobs 
            //foreach (Dictionary<string, string> job in jobs)
            //{
            //    //if the column that matches search type contains the search term add that job to a resultsList. 
            //    if (job.Keys.Equals(searchType) && job.ContainsValue(searchTerm) )
            //    {




            //    }


            //}



        }

    }
}
