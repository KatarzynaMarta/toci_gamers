using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    public class PrzemekGeneratorExtension : PrzemekGeneratorBase
    {
        protected int passwordLength;
        Random r = new Random();

        protected override void GetRandomString(int minLength, int maxLength, ref StringBuilder sbResult)
        {
            passwordLength = r.Next(minLength, maxLength);

            for (int i = 0; i < passwordLength; i++)
            {
                sbResult.Append(r.Next(0, 2) == 0 ? Convert.ToChar(r.Next(65, 90)) : Convert.ToChar(r.Next(97, 122)));
            }
        }

        protected override void GetRandomPassword(ref StringBuilder sbResult)
        {
            passwordLength = r.Next(8, 40);

            for (int i = 0; i < passwordLength; i++)
            {
                sbResult.Append(r.Next(0, 2) == 0 ? Convert.ToChar(r.Next(65, 90)) : Convert.ToChar(r.Next(97, 122)));
            }
        }


        protected override void GetStrongRandomPassword(ref StringBuilder sbResult)
        {
            passwordLength = r.Next(8, 40);

            for (int i = 0; i < passwordLength; i++)
            {
                sbResult.Append(Convert.ToChar(r.Next(33, 126)));
            }
        }
    }
}
