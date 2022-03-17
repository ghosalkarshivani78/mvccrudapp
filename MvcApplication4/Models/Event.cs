using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Models
{
    public class Event
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string address { get; set; }

       // public List<SelectListItem> city { get; set; }
        public string city { get; set; }
        //public SelectList drop { get; set; }
        public int number { get; set; }
        //public void dropdown() 
        //{
        //    string sql="select * from "
        //}
    }
}