using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training
{
    public class KamilDateAnalyzer
    {
        protected Dictionary<int, int> monthDaysMap = new Dictionary<int, int>()
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 },

        };

        public virtual bool IsDateValid(string date)
        {
            //string day = 
            string month = date.Substring(2, 2);
            string day = date.Substring(4, 2);
            string year = date.Substring(0, 2);

            int parsedMonth = 0;
            int parsedDay = 0;
            int parsedYear = 0;

            int.TryParse(year, out parsedYear);
            int.TryParse(month, out parsedMonth);
            int.TryParse(day, out parsedDay);

            if (monthDaysMap.ContainsKey(parsedMonth) && monthDaysMap[parsedMonth] > 0 && monthDaysMap[parsedMonth] >= parsedDay) // tutaj trzeba bylo zmienic <= na >= bo testy nie przechodzily 
            {
                return true;
            }

            if (parsedMonth == 2 && parsedYear % 4 == 0 && parsedDay <= 29)
            {
                return true;
            }

            return false;
        }
    }
}
