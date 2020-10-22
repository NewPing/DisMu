using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisMu_Base.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisMu_Service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PlaylistController : Controller
    {
        public ActionResult<Dictionary<int, Playlist>> getPlaylists()
        {
            return null;
        }

        public ActionResult<bool> updatePlaylist(Playlist _playlist)
        {
            return null;
        }

        public ActionResult<bool> addPlaylist(string _title)
        {
            return false;
        }
    }
}
