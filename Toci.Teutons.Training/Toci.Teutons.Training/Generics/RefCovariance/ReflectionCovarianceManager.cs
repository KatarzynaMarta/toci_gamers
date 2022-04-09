using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Generics.RefCovariance
{
    public class ReflectionCovarianceManager // ??
    {
        public virtual Dictionary<string, object> GetInstances(Type baseClass, List<Type> derivingTypes) //??
        {
            Dictionary<string, object> result = new Dictionary<string, object>();          

            foreach (Type item in derivingTypes)
            {
                // ?? new baseclass<item>
                Type tGen = baseClass.MakeGenericType(item);
                //object el = Activator.CreateInstance(item);
                result.Add(item.Name, Activator.CreateInstance(item));
            }

            return result;
        }
    }
}
