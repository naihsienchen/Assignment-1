using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns id square integer when receiving a get request with an id.
        /// <example>GET api/square/{id}</example>
        /// </summary>
        /// <returns>[ id * id ]</returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }



    }
}
