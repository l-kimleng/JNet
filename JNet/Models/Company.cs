using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JNet.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        public string Name { get; set; }

        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}