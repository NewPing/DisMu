using System;
using DisMu_Base.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DisMu_Service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TitleController : Controller
    {
        public ActionResult<bool> uploadTitle(string _title, byte[] _data)
        {
            return false;
        }

        public ActionResult<bool> deleteTitle(Track _track)
        {
            return false;
        }

        public ActionResult<bool> updateTitle(Track _track)
        {
            return null;
        }
    }
}
