using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage
{
    /// <summary>
    /// Interface for different data layers, to make sure they all implements the method GetData.
    /// </summary>
    interface IDataLayer
    {
        string GetData(string path);
    }
}
