using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.RandomStrings
{
    public class KamilGenerator : GeneratorBase
    {
        static Random random = new Random();
        private static int size = 0;
        char[] chars = new char[size];

        protected override string GetRandomString(int minLength, int maxLength)
        {
            size = random.Next(minLength, maxLength);
            for (int i = 0; i < size; i++)
            {
                chars[i] = random.Next(1, 3) == 1 ? (char)random.Next(65, 91) : (char)random.Next(97, 123);
            }

            return new string(chars);
        }

        protected override string GetRandomPassword()
        {
            return GetRandomString(4, 9);
        }
        protected override string GetStrongRandomPassword()
        {
            size = random.Next(4, 9);
            for (int i = 0; i < size; i++)
            {
                chars[i] = (char)random.Next(33, 126);
            }
            return new string(chars);
        }
    }
}
