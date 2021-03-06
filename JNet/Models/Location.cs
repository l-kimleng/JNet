﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JNet.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
    }
}