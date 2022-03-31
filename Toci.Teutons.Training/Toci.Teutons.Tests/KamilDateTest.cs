﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Teutons.Training;

namespace Toci.Teutons.Tests
{
       [TestClass]
       public class KamilDateTest : SubstringTests
       {

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
                     Benchmark ben = new Benchmark();
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
