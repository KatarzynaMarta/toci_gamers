using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Teutons.Training.Pesel;

namespace Toci.Teutons.Tests
{
    [TestClass]
    public class KamilPeselValidatorTest
    {
        class PeselProperty
        {
            public string Pesel { get; set; }
            public bool Result { get; set; }
        }

        [TestMethod]
        public void PeselTest()
        {
            KamilPeselValidator kamilPesel = new KamilPeselValidator();

            List<PeselProperty> testCases = new List<PeselProperty>()
            {
                new PeselProperty() { Pesel = "91031502294", Result = true },
                new PeselProperty() { Pesel = "90034052293", Result = false },
            };

            foreach (PeselProperty item in testCases)
            {
                Assert.AreEqual(item.Result, kamilPesel.IsPeselValid(item.Pesel));
            }
        }
    }
}
