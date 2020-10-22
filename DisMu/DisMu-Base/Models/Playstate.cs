using System;

namespace DisMu_Base.Models
{
    public static class Playstate
    {
        public static Guid currentPlaylist { get; set; }
        public static Guid currentTrack { get; set; }
        public static DateTime startedAt { get; set; }
        public static DateTime pausedAt { get; set; }
    }
}
