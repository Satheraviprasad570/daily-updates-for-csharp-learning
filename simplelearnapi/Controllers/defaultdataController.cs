using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace simplelearnapi.Controllers
{
    public class defaultdataController : ApiController
    {
        public string[] mydata = { "this is a sample string for testing web api ", "what is your name ? just tell to your neighbour" };
        public string[] getdata()
        {
            return mydata;
        }
    }
}
