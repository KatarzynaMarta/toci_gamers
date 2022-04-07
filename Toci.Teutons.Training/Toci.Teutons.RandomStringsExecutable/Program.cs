using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Kasia();


            PrzemekGeneratorExtension generator = new PrzemekGeneratorExtension();

            Console.WriteLine(generator.GenerateString());

            Console.ReadKey();
        }

        static void Kasia()
        {
            Kasia k = new Kasia();

            MethodInfo mIn =  k.GetType().GetMethod("IsOk", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            object result = mIn.Invoke(k, null);
        }
    }

    public class Kasia
    {
        protected bool IsOk()
        {
            Console.WriteLine(DateTime.Now.Ticks);

            return DateTime.Now.Ticks % 2 == 1;
        }
    }
}
