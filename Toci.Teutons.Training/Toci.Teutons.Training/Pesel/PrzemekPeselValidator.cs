using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Pesel
{
    public class PrzemekPeselValidator : PeselValidatorBase
    {


        public override bool IsPeselValid(string peselCandidate)
        {
            int[] multipliers = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int counter = 0;
            int number;

            int peselLastNumber = (int)Char.GetNumericValue(peselCandidate[peselCandidate.Length - 1]);

            for(int i= 0; i < peselCandidate.Length-1; i++)
            {
                number = (int)Char.GetNumericValue(peselCandidate[i]);
                counter += number * multipliers[i];
            }

            int result = 10 - (counter % 10);

            if (result == peselLastNumber) return true;
            else return false;
        }
    }
}
