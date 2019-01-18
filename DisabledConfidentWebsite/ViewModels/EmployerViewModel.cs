﻿using DisabledConfidentWebsite.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisabledConfidentWebsite.ViewModels
{
    public class EmployerViewModel
    {
        public IEnumerable<Employer> Employers { get; set; }

        public List<SelectListItem> Sectors { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Any Sector" },
            new SelectListItem { Value = "Agriculture", Text = "Agriculture" },
            new SelectListItem { Value = "Health", Text = "Health" },
        };

        public string Sector { get; set; }
    }

}
