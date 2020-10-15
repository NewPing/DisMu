using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Models
{
    public class Playlist
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Dictionary<int, Guid> tracks { get; set; }
    }
}
