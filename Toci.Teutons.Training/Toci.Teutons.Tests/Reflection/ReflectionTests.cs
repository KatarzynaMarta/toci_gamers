using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Toci.Teutons.Training.Generics.RefCovariance;

namespace Toci.Teutons.Tests.Reflection
{
    public interface ITest { }

    [TestClass]
    public class ReflectionTests : ITest
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

    public class ReflectionFunEntity : ZabawaDoKwadratu
    {
        private int IWantToBeInvisible;
        private int IAlsoWantToBeInvisible;

    }

    [TestClass]
    public class ExClass : ZabawaDoKwadratu
    {
        public string IAmGenericMethod<T>(T instance)
        {
            return instance.ToString();
        }

        [TestMethod]
        public void dupa()
        {
            //Type t = this.GetType();

            //IAmGenericMethod<>();

            MethodInfo mIn = this.GetType().GetMethod("IAmGenericMethod");

            Dictionary<Type, object> TypesToInject = new Dictionary<Type, object>()
            {
                { this.GetType(), this },
                { "dupa".GetType(), "dupa" }
            };

            foreach (KeyValuePair<Type, object> t in TypesToInject)
            {
                MethodInfo genMIn = mIn.MakeGenericMethod(t.Key);

                object result = genMIn.Invoke(this, new[] { t.Value });
            }
        }

        public override string ToString()
        {
            return "komedia";
        }
    }

    [TestClass]
    public class ZabawaDoKwadratu
    {
        [TestMethod]
        public void ToDopiero()
        {
            ReflectionCovarianceManager test = new ReflectionCovarianceManager();

            Dictionary<string, object> result = test.GetInstances(typeof(List<>), new List<Type>() { "".GetType(), 2.GetType() });
        }

        private string IAmPrivate()
        {
            return "He's a private !";
        }
    }

    [TestClass]
    public class ReflectionRevisited : ZabawaDoKwadratu
    {
        [TestMethod]
        public void Test()
        {
            ZabawaDoKwadratu zabawa = new ZabawaDoKwadratu();

            MethodInfo mIn = zabawa.GetType().GetMethod("IAmPrivate", BindingFlags.Instance | BindingFlags.NonPublic);

           object result =  mIn.Invoke(zabawa, null);
        }

        [TestMethod]
        public void DerivingTypes()
        {
            //ZabawaDoKwadratu
            List<Type> types = typeof(ZabawaDoKwadratu).Assembly.GetTypes().ToList();

            List<Type> derivingTypes  = types.Where(t => t.IsSubclassOf(typeof(ZabawaDoKwadratu))).ToList();
            List<Type> IderivingTypes = types.Where(t => typeof(ITest).IsAssignableFrom(t)).ToList();


            ReflectionCovarianceManager test = new ReflectionCovarianceManager();

                Dictionary<string, object> result = test.GetInstances(typeof(List<>), derivingTypes);
            
        }


    }
}
