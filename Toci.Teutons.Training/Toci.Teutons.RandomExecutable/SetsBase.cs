using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomExecutable
{
    public abstract class SetsBase
    {
        public virtual int[] CalculateSet(int[] first, int[] second)
        {
            int resultLength = first.Length > second.Length ? first.Length : second.Length; // ??

            int[] result = new int[resultLength];

            int resultCount = 0;

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    Calculate(first[i], second[j], ref resultCount, ref result);
                }
            }

            return result;
        }

        protected abstract void Calculate(int itemFirst, int itemSecond, ref int resultCount, ref int[] result);
    }
}
