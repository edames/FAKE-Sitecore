using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FAKE.Sitecore.Utilities
{
    public class WebClient : System.Net.WebClient
    {
        public int Timeout { get; set; }

        protected override System.Net.WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            request.Timeout = Timeout;
            return request;
        }
    }
}
