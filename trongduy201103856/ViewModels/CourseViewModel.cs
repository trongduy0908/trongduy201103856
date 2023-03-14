using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trongduy201103856.Models;

namespace trongduy201103856.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public int Time { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }
    }
}