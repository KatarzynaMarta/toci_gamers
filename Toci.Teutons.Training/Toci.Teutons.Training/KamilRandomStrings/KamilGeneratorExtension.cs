using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.RandomStrings
{
    public class KamilGeneratorExtension : KamilGeneratorBase
    {
        public override void GetRandomString(int minLength, int maxLength)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Random random = new Random();

            int size = random.Next(minLength, maxLength);

            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }

           // return new string(chars);
        }

        public virtual string GetRandomBase(int minLength, int maxLength)
        {
            Random random = new Random();

            int size = random.Next(minLength, maxLength);

            char[] chars = new char[size];

            // GetRandomPassword(ref size, ref chars, ref random);
            GetStrongRandomPassword(ref size, ref chars, ref random);
            return new string(chars);
        }

        public override void GetRandomPassword(ref int size, ref char[] chars, ref Random random)
        {
            for (int i = 0; i < size; i++)
            {
                chars[i] = random.Next(1, 3) == 1 ? (char)random.Next(65, 91) : (char)random.Next(97, 123);
            }
        }
        public override void GetStrongRandomPassword(ref int size, ref char[] chars, ref Random random)
        {
            for (int i = 0; i < size; i++)
            {
                chars[i] = (char)random.Next(33, 126);
            }
        }
    }
}
