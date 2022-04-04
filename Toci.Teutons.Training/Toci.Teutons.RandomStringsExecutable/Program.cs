using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrzemekGeneratorExtension generator = new PrzemekGeneratorExtension();

            Console.WriteLine(generator.GenerateString());

            Console.ReadKey();
        }
    }
}
