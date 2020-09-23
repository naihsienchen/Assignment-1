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
        ///thought process: 
        /// 1) id/14=decimal number round down
        ///2) 1)*1.13 = Total
        ///3) Output 3 strings
        ///Q: are 1) 2) 3) three get methods? could they be put into one controller?
        
        ///Code research for rounding a decimal number down to a whole number:
        ///public static decimal Floor(decimal d)
        ///int interval = (int)Math.Floor(difference / increment);

        public int Get(id)

        {
            //Math.Floor(id / 14) * 5.50 ==>int #1 ()
            //int #1 * 0.13 ==>int #2 (tax)
            return new int[] { int #1 + int #2 };
        }
        ///Q: could a series of calculation be done in a single method, like I tried to do above?
        
        pulic IEnumerable<string> Get(???)
        {
                return new string[] { "id / 14" + "fortnights at $5.50/FN =" + "int #1",
                                  "HST 13% =" +"$" + "int #2" +" CAD",
                                  "Total = $" + "new int" + " CAD"};
        }
    }
}

        



    }
}
