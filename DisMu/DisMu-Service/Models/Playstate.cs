using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Models
{
    public static class Playstate
    {
        public static Guid currentPlaylist { get; set; }
        public static Guid currentTrack { get; set; }
        public static DateTime startedAt { get; set;}
        public static DateTime pausedAt { get; set; }
    }
}
