using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPage
{
    class Program
    {
        static void Main(string[] args)
        {

            RequestManager r = new RequestManager(new FileRequestDal());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Indtast url");
                Console.WriteLine(r.GetData(Console.ReadLine()));
                Console.ReadKey();
            }
        }
    }
}
