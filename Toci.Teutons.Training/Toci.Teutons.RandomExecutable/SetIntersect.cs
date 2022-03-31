using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomExecutable
{
    public class SetIntersect : SetsBase
    {
        protected override void Calculate(int itemFirst, int itemSecond, ref int resultCount, ref int[] result)
        {
            if (itemFirst == itemSecond)
            {
                result[resultCount] = itemFirst;
                resultCount++;
            }
        }
    }
}
