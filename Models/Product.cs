using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace productApp_api.Models
{
    public class Product
    {
        public int id { get; set;  }

        public string Name { get; set; }
        public string   Category { get; set; }
        public Decimal price { get; set; }

    }
}