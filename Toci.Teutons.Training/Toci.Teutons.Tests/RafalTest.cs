using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Toci.Teutons.Training;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Tests
{
    [TestClass]
    public class RafalTest : SubstringTests
    {
        class NumberText
        {
            public int number {get; set;}
            public string text {get; set;}
           
        }

        [TestMethod]
        public void NumberToText()
        {
            
            Random random = new Random();
            List<int> testNumber = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                testNumber.Add(random.Next(1000000000));
            }

            foreach (int number in testNumber)
            {
                Console.WriteLine(number + " " + Benchmark.NumberToText(number));
            }
        }
    }
}
