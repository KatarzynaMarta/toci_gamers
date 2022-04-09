using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Pesel
{
    public class KamilPeselValidator : PeselValidatorBase
    {
        public KamilDateAnalyzer dateAnalyzer = new KamilDateAnalyzer();
        public override bool IsPeselValid(string peselCandidate)
        {
            if (peselCandidate.Length != 11)
            {
                return false;
            }
            else
            {
                bool isDateValid = dateAnalyzer.IsDateValid(peselCandidate.Substring(0, 6));

                if (isDateValid == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
