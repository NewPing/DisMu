using System;

namespace DisMu_Base.Models
{
    public class Track
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public int duration { get; set; } // in seconds
    }
}
