using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Toci.Teutons.Training;

namespace Toci.Teutons.Tests
{

    [TestClass]
    public class RafalTest
    {
        [TestMethod]
        public void TestMethod() 
        {
            
            Random radom = new Random();
            int lenghtPassowrd = radom.Next(8, 20);
            string easy = RafalBenchmark.PasswordTask(0, lenghtPassowrd);
            string medium = RafalBenchmark.PasswordTask(1, lenghtPassowrd);
            string hard = RafalBenchmark.PasswordTask(2, lenghtPassowrd);

            Assert.AreEqual(lenghtPassowrd, easy.Length);
            Assert.AreEqual(lenghtPassowrd, medium.Length);
            Assert.AreEqual(lenghtPassowrd, medium.Length);
        } 
    }
}

