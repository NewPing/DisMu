using System;
using System.Collections.Generic;
using System.Text;
using DisMu_Base.Models;

namespace DisMu_Base
{
    public class ExampleData
    {
        public Dictionary<int,Playlist> playlists;

        public int idPool { get; set; }

        public ExampleData()
        {
            idPool = 0;
            playlists = new Dictionary<int, Playlist>();

            addPlaylist("Songpool");
        }

        public void addPlaylist(string name)
        {
            var playlist = new Playlist();
            playlist.id = Guid.NewGuid();
            playlist.name = name;
            playlist.tracks = new Dictionary<int, Track>();

            for (int i = 0; i < 10; i++)
            {
                var track = new Track();
                track.id = Guid.NewGuid();
                track.title = "Track" + i;
                track.duration = 120;

                playlist.tracks.Add(i, track);
            }
            playlists.Add(idPool++, playlist);
        }
    }
}
