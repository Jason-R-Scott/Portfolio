using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioI
{

    public class HomeController : Controller
    {

        [HttpGet("")]

        public string Index ()
        {
            return "Hidey Ho neighbor";
        }

        [HttpGet("projects")]

        public string Projects ()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]

        public string Contact ()
        {
            return "Contact Info";
        }

    }

}