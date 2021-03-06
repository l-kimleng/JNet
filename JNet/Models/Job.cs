﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JNet.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }

        [Display(Name = "Post Date")]
        public DateTime PostDate { get; set; }
        
        [Display(Name = "Applied Date")]
        public DateTime AppliedDate { get; set; }

        public string Url { get; set; }
        public bool IsExpired { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}