using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Pesel
{
    public class BartekPeselValidator : PeselValidatorBase
    {
        public override bool IsPeselValid(string peselCandidate)
        {
            return true;
        }
    }
}
