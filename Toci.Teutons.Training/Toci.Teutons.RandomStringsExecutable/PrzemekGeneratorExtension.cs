using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    public class PrzemekGeneratorExtension : PrzemekGeneratorBase
    {
        StringBuilder sb = new StringBuilder();
        protected int passwordLength;
        Random r = new Random();

        protected override string GetRandomString(int minLength, int maxLength)
        {
            passwordLength = r.Next(minLength, maxLength);

            for (int i = 0; i < passwordLength; i++)
            {
                sb.Append(r.Next(0, 2) == 0 ? Convert.ToChar(r.Next(65, 90)) : Convert.ToChar(r.Next(97, 122)));
            }

            return sb.ToString();
        }

        protected override string GetRandomPassword()
        {
            passwordLength = r.Next(8, 40);

            for (int i = 0; i < passwordLength; i++)
            {
                sb.Append(r.Next(0, 2) == 0 ? Convert.ToChar(r.Next(65, 90)) : Convert.ToChar(r.Next(97, 122)));
            }

            return sb.ToString();
        }


        protected override string GetStrongRandomPassword()
        {
            passwordLength = r.Next(8, 40);

            for (int i = 0; i < passwordLength; i++)
            {
                sb.Append(Convert.ToChar(r.Next(33, 126)));
            }

            return sb.ToString();
        }
    }
}
