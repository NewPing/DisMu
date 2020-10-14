using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisMu_UI
{
    sealed class DisMuManager
    {
        private DisMuManager() { }

        private static volatile DisMuManager instance = null;

        private static Object m_lock = new Object();

        public List<Playlist> Playlists = new List<Playlist>();

        public static DisMuManager getInstance()
        {
            if(instance == null) 
                lock(m_lock) { if (instance == null) instance = new DisMuManager(); }
            return instance;
        }
    }
}
