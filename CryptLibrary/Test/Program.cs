using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptLibrary;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ICryptService service = new Caesar();
            string cr = service.Crypt("Hello world", 1);
            Console.WriteLine( cr);
            string dcr = service.Decrypt(cr,1);
            Console.WriteLine(dcr);
        }
    }
}
