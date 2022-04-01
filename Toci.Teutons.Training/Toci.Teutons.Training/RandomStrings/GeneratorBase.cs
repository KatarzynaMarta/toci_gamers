using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.RandomStrings
{
    public abstract class GeneratorBase
    {
        public abstract string GetRandomString(int minLength, int maxLength);

        public abstract string GetRandomPassword(); // edascx86A

        public abstract string GetStrongRandomPassword(); // F_we23@azWEc^&8

        // ascii
    }
}
