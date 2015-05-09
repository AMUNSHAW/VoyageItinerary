using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoyageItinerary.Models;
using Npgsql;
using System.Configuration;
using System.Data;

namespace VoyageItinerary.Controllers
{
    public class CreateItineraryController : Controller
    {
        // GET: CreateItinerary
        public ActionResult Index()
        {
            return View("HomePage");
        }

        [HttpPost]
        public ActionResult Index(ItineraryModel ItineraryParams)
        {
            return View("CreateItinerary",ItineraryParams);
        }

        public ActionResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HomePage(ItineraryModel ItineraryParams)
        {
            if (!string.IsNullOrEmpty(ItineraryParams.PlaceName))
            {
                DataSet myDs= new DataSet();
                NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostGreSql"].ConnectionString);
                
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("select name from mumbai_india_point where tourism='attraction'",conn);

                try
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(myDs);
                }
                finally
                {
                    conn.Close();
                }
                return View("CreateItinerary", ItineraryParams);
            }
            else
            {
                return View();
            }
        }
    }
}