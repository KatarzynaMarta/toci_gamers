using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Teutons.Training;
using Toci.Teutons.Training.RandomStrings;

namespace Toci.Teutons.Tests
{
       [TestClass]
       public class KamilDateTest : SubstringTests
       {
              class RandomProperty
              {
                     public int MinLenght { get; set; }
                     public int MaxLenght { get; set; }
                     public string Result { get; set; }
              }
              class DateProperty
              {
                     public string Date { get; set; }
                     public bool ResultIsValid { get; set; }
              }

              class NumberProperty
              {
                     public string Number { get; set; }
                     public string Result { get; set; }
              }

              [TestMethod]
              public void RandomTest()
              {
                     KamilGenerator kamilGenerator = new KamilGenerator();

                     Random random = new Random();
                     
                     List<RandomProperty> testCase = new List<RandomProperty>()
                     {
                            new RandomProperty() {MinLenght = 4, MaxLenght = 10, Result = "asdasd"}
                     };
                     foreach (RandomProperty randomProperty in testCase)
                     {
                            //Assert.AreEqual(randomProperty.Result, kamilGenerator.GetRandomBase(4,9));
                     }

              }

              [TestMethod]
              public void DateTest2()
              {
                     //
                     DateAnalyzer dateAnalyzer = new DateAnalyzer();

                     List<DateProperty> testCase = new List<DateProperty>()
                     {
                            new DateProperty() {Date = "240229", ResultIsValid = true}
                     };

                     foreach (DateProperty dateProperty in testCase)
                     {
                            Assert.AreEqual(dateProperty.ResultIsValid ,dateAnalyzer.IsDateValid(dateProperty.Date));
                     }
              }

              [TestMethod]
              public void NumberToWordsTest()
              {
                     KamilBenchmark ben = new KamilBenchmark();
                     List<NumberProperty> testCase = new List<NumberProperty>()
                     {
                            new NumberProperty() {Number = "542", Result = "piećset czterdzieści dwa"},
                            new NumberProperty() {Number = "54", Result = "piećdziesiąt cztery"},
                            new NumberProperty() {Number = "15", Result = "piętnaście"},
                            new NumberProperty() {Number = "1", Result = "jeden"}
                     };

                     foreach (NumberProperty numberProperty in testCase)
                     {
                            Assert.AreEqual(numberProperty.Result, ben.ConvertNumericToWord(numberProperty.Number));
                     }


              }
       }
}
