using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Models
{
    public class Track
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public int duration { get; set; } // in seconds
    }
}
