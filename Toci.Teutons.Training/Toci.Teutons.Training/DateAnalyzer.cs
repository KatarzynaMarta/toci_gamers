using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training
{
    public class DateAnalyzer
    {
        //840808 

        protected Dictionary<int, int> monthDaysMap = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 3, 31 },
            { 4, 30 }
        };

        public virtual bool IsDateValid(string date)
        {
            //string day = 
            string month = date.Substring(2, 2);
            string day = date.Substring(4, 2);

            int parsedMonth = 0;
            int parsedDay = 0;

            int.TryParse(month, out parsedMonth);
            int.TryParse(day, out parsedDay);

            if (monthDaysMap.ContainsKey(parsedMonth) && monthDaysMap[parsedMonth] > 0 && monthDaysMap[parsedMonth] <= parsedDay)
            {
                return true;
            }

            if (parsedMonth == 2)
            {
                // year i ify
            }

            return false;
        }
    }
}
