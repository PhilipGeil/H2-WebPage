﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebPage
{
    class FileRequestDal : IDataLayer
    {
        public string GetData(string path)
        {
            string text = File.ReadAllText(@"" + path);
            return text;
        }
    }
}
