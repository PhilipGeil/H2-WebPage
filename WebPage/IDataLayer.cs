using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage
{
    /// <summary>
    /// Interface which makes sure that all data layers implements the GetData method.
    /// </summary>
    interface IDataLayer
    {
        string GetData(string path);
    }
}
