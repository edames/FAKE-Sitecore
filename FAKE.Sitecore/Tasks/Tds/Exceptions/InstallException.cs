using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAKE.Sitecore.Tasks.Tds.Exceptions
{
    public class InstallException : Exception
    {
        public InstallException(string message)
            : base(message)
        { }
    }
}
