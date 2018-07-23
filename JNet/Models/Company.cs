using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JNet.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}