using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    public class PeselValidator
    {
        protected DateValidator dateValidator = new DateValidator();

        public bool IsPeselValid(string pesel)
        {
            bool isDateValid = dateValidator.IsPeselDateValid(pesel.Substring(0, 6));



            return true;
        }
    }
}
