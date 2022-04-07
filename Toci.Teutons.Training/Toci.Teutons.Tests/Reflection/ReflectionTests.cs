using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Tests.Reflection
{
    [TestClass]
    public class ReflectionTests
    {
        [TestMethod]
        public void FirstTest()
        {
            ReflectionFunEntity refFun = new ReflectionFunEntity();
            //Type
            //"".GetType

            FieldInfo invField = refFun.GetType().GetField("IWantToBeInvisible", BindingFlags.NonPublic | BindingFlags.Instance);

            invField.SetValue(refFun, 8);
        }

        [TestMethod]
        public void SecondTest()
        {
            ReflectionFunEntity refFun = new ReflectionFunEntity();

            FieldInfo[] invFields = refFun.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fItem in invFields)
            {
                fItem.SetValue(refFun, fItem.Name.Length);
            }
        }
    }

    public class ReflectionFunEntity
    {
        private int IWantToBeInvisible;
        private int IAlsoWantToBeInvisible;

    }
}
