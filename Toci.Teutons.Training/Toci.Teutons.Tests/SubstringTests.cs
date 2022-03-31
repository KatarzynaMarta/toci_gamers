using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Toci.Teutons.Training;

namespace Toci.Teutons.Tests
{
    [TestClass]
    public class SubstringTests
    {
        class SubstringEntity
        {
            public string Element { get; set; }
            public int Position { get; set; }
            public int Length { get; set; }
            public string Result { get; set; }
            public bool ShouldReturn { get; set; }
        }

        [TestMethod]
        public void SubstringTest()
        {
            //
            Benchmark ben = new Benchmark();

            List<SubstringEntity> testCases = new List<SubstringEntity>()
            {
                new SubstringEntity() { Element = "beatka", Result = "ea", Position = 1, Length = 2 } // ??????
            };

            foreach (SubstringEntity item in testCases)
            {
                Assert.AreEqual(item.Result, ben.Substring(item.Element, item.Position, item.Length));
            }
        }

        [TestMethod]
        public void TestContains()
        {
            Benchmark ben = new Benchmark();

            bool result = ben.Contains("beatka", "atk");
        }

    }

}

