using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisabledConfidentWebsite.Models
{
    public class Employer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Postcode { get; set; }
        public string DCLevel { get; set; }
        public string Sector { get; set; }
    }
}
