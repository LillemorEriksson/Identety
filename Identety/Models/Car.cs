using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identety.Models
{
    public class Car
    {
        public int id { get; set; }
        public string Brand { get; set; }
        public string Name  { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}