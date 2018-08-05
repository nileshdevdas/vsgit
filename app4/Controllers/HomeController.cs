using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace app4.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public String getMessage() {

            return "Helllo";
        }

    }
}
