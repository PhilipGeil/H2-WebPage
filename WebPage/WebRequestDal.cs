using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebPage
{
    class WebRequestDal : IDataLayer
    {
        public string GetData(string path)
        {
            WebRequest webRequest = WebRequest.Create(path);
            WebResponse webResponse = webRequest.GetResponse();
            Stream s = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(s);
            return streamReader.ReadToEnd();
        }
    }
}
