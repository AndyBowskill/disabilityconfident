using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisabledConfidentWebsite.Models
{
    public class Employer
    {
        public string Name { get; }
        public string Place { get; }
        public string DCLevel { get; }
        public string Sector { get; set; }
    }
}
