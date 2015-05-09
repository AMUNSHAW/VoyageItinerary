using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoyageItinerary.Models;

namespace VoyageItinerary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewItinerary()
        {
            ItineraryModel ItineraryParams = new ItineraryModel();
            ItineraryParams.PlaceName = Convert.ToString(Request["inputPlace"]);
            ItineraryParams.Budget = Convert.ToInt32(Request["inputBudget"]);
            ItineraryParams.FromDate = Convert.ToDateTime(Request["inputFromDate"]).Date;
            ItineraryParams.ToDate = Convert.ToDateTime(Request["inputToDate"]).Date;
            ItineraryParams.NoOfPeople = Convert.ToInt32(Request["inputPerson"]);
            return View("CreateItinerary", ItineraryParams);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}