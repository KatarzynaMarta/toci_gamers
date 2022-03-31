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

        public virtual bool Contains(string haystack, string needle)
        {
            // beatka eat
            // tka
            //"".con
            // like %dupa%
            bool contains;

            //if ()

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i] == needle[j])
                    {
                        if (j == needle.Length - 1)
                        {
                            return true;
                        }

                        i++;
                    }
                }
            }

            return false;
        }

        private int dupa()
        {

        }

        // 532 -> Pięćset trzydziesty drugi
        //
    }
}
