using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAX.Data;

namespace SAX.CSTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Startup from CS Testing");

            var sax = new SAX();
            var db =new Database();

            Console.ReadKey();
        }
    }
}
