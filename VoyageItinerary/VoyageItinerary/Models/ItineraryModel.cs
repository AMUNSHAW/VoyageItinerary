using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VoyageItinerary.Models
{
    public class ItineraryModel
    {
        [Display(Name = "Place")]
        [DataType(DataType.Text)]
        public string PlaceName { get; set; }
        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }

        [Display(Name = "To Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }
        public int Budget { get; set; }
        [Display(Name = "No. of People")]
        public int NoOfPeople { get; set; }
    }
}