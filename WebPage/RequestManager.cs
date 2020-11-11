using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage
{
    /// <summary>
    /// Manager class that handles all request made from the user.
    /// </summary>
    class RequestManager
    {
        IDataLayer dl;

        public RequestManager(IDataLayer dl)
        {
            this.dl = dl;
        }

        public string GetData(string path)
        {
            return dl.GetData(path);
        }
    }
}
