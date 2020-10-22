using DisMu_Base.Models;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisMu_Service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PlaystateController : Controller
    {
        public ActionResult<bool> isUpdateNeeded(DateTime _datetime)
        {
            return false;
        }

        public ActionResult<Playstate> getPlaystate()
        {
            return null;
        }

        public ActionResult<bool> setPlaystate(Playstate _playstate)
        {
            return null;
        }
    }
}
