using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.RandomStrings
{
    public abstract class GeneratorBase
    {
        protected abstract string GetRandomString(int minLength, int maxLength);

        protected abstract string GetRandomPassword(); // edascx86A

        protected abstract string GetStrongRandomPassword(); // F_we23@azWEc^&8

        // ascii
    }
}
