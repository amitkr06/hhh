using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Mvc.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public string city { get; set; }

        public string address { get; set; }

        public string dept_name { get; set; }


    }
}