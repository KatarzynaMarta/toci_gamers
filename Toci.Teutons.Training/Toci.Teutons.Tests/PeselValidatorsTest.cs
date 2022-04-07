using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Teutons.Training.Pesel;

namespace Toci.Teutons.Tests
{
    [TestClass]
    public class PeselValidatorsTest
    {
        protected Dictionary<string, PeselValidatorBase> peselValidatorsMap = new Dictionary<string, PeselValidatorBase>()
        {
            { "Bartek", new BartekPeselValidator() },
        };

        [TestMethod]
        public void TestPeselsForValidators()
        {
            // open file with pesel candidates

            foreach (KeyValuePair<string, PeselValidatorBase> peselValItem in peselValidatorsMap)
            {
                Assert.AreEqual(true, peselValItem.Value.IsPeselValid(""));
            }
        }
    }
}
