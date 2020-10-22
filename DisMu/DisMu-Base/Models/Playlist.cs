using System;
using System.Collections.Generic;

namespace DisMu_Base.Models
{
    public class Playlist
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Dictionary<int, Track> tracks { get; set; }
    }
}
