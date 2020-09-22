using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        ///public static decimal Floor(decimal d)
        ///int interval = (int)Math.Floor(difference / increment);
        
        public IEnumerable<int> Get(int id)
        
        {
            return new int[] { id/14 rounded down };
        }




    }
}
