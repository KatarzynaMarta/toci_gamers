using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Pesel
{
    public abstract class PeselValidatorBase
    {
        public abstract bool IsPeselValid(string peselCandidate);
    }
}
