using System;

namespace Toci.Teutons.Training
{
    public class Benchmark
    {
        // beatka -> ("beatka", 2, 3)
        public virtual string Substring(string candidate, int position, int length)
        {
            //

            string result = string.Empty;

            for (int i = position; i < position + length; i++)
            {
                //                // 2 -> a, 3 -> t ...
                result += candidate[i];
            }

            return result;
        }

        //Substring("beatka", 2, 6);
    }
}
