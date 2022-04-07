using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.RandomStrings
{
    public class PrzemekGenerator : GeneratorBase
    {
        StringBuilder sb = new StringBuilder();
        string result = string.Empty;
        protected int passwordLength;
        Random r = new Random();

        public virtual string GenerateString(int whichMethod, int minLength = 8, int maxLength = 40)
        {


            if(minLength >= 0 && minLength <= maxLength)
            {
                switch (whichMethod)
                {
                    case 1:
                        result = GetRandomString(minLength, maxLength);

                        break;

                    case 2:
                        result = GetRandomPassword();

                        break;

                    case 3:
                        result = GetStrongRandomPassword();

                        break;

                    default:

                        return "\nInvalid number option";

                }

                Console.WriteLine("\n\nGenerated string length = " + result.Length);

                return result;
            }
            else return "\nInvalid min or max lenght input";
        }

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
