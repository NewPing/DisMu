using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisMu_UI
{
    class Playlist
    {
        private static int idPool = 0;

        public int Id { get; set; }

        public String Name { get; set; }

        public List<Title> Titles { get; set; }

        public Playlist(String name = "Playlist") {

            this.Id = idPool++;
            if (name == "Playlist") this.Name = name + this.Id;
            else this.Name = name;
            this.Titles = new List<Title>();

        }
    }
}
