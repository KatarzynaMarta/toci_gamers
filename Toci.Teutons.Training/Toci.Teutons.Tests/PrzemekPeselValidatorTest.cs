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
    public class PrzemekPeselValidatorTest
    {
        class PeselEntity
        {
            public string Pesel { get; set; }
            public bool Result { get; set; }
        }

        [TestMethod]
        public void PeselTest()
        {
            
            PrzemekPeselValidator przemekPeselValidator = new PrzemekPeselValidator();

            List<PeselEntity> testCases = new List<PeselEntity>()
            {
                new PeselEntity() { Pesel = "98092102294", Result = true },
                new PeselEntity() { Pesel = "98092102293", Result = false },
            };

            foreach (PeselEntity item in testCases)
            {
                Assert.AreEqual(item.Result, przemekPeselValidator.IsPeselValid(item.Pesel));
            }
        }

    }
}


