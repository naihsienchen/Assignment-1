using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        public string Post ()
        {
            return { "Hello World!" };
        }

        // GET api/Greeting/{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Hello to " + id + " people!" };
        }

    }
}
