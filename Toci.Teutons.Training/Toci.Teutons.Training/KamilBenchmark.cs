using System;
using System.Collections.Generic;
using System.Text;

namespace Toci.Teutons.Training
{
    public class KamilBenchmark
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

        protected Dictionary<string, string> nubersWordsMap = new Dictionary<string, string>()
        {
            { "1", "jeden"},
            { "2", "dwa" },
            { "3", "trzy" },
            { "4", "cztery" },
            { "5", "pieć"},
            { "6", "sześć" },
            { "7", "siedem" },
            { "8", "osiem" },
            { "9", "dziewieć" }
        };
        protected Dictionary<string, string> decimalWordsMap = new Dictionary<string, string>()
        {
            { "1", "dziesieć"},
            { "2", "dwadzieścia" },
            { "3", "trzydzieści" },
            { "4", "czterdzieści" },
            { "5", "piećdziesiąt"},
            { "6", "sześćdziesiąt" },
            { "7", "siedemdziesiąt" },
            { "8", "osiemdziesiąt" },
            { "9", "dziewiećdziesiąt" }
        };
        protected Dictionary<string, string> upTenWordsMap = new Dictionary<string, string>()
        {
            { "11", "jedenaście"},
            { "12", "dwanaście" },
            { "13", "trzynaście" },
            { "14", "czternaście" },
            { "15", "piętnaście"},
            { "16", "sześćnaście" },
            { "17", "siedemnaście" },
            { "18", "osiemnaście" },
            { "19", "dziewiećnaście" }
        };
        protected Dictionary<string, string> hundredsWordsMap = new Dictionary<string, string>()
        {
            { "1", "sto"},
            { "2", "dwieście" },
            { "3", "trzysta" },
            { "4", "czterysta" },
            { "5", "piećset"},
            { "6", "sześćset" },
            { "7", "siedemset" },
            { "8", "osiemset" },
            { "9", "dziewiećset" }
        };

        public virtual string ConvertNumericToWord(string number)
        {
            StringBuilder sb = new StringBuilder();

            int numberParsed = 0;
            Int32.TryParse(number, out numberParsed);
            string result = string.Empty;
            string selectedValue = string.Empty;
            string selectedValue2 = string.Empty;
            string selectedValue3 = string.Empty;
            if (numberParsed < 10)
            {
                return result = nubersWordsMap[number];
            }

            if (numberParsed < 20 && numberParsed > 10)
            {
                return result = upTenWordsMap[number];
            }

            if (numberParsed > 20 && numberParsed < 100)
            {
                string first = number.Substring(0, 1);
                string second = number.Substring(1, 1);

                selectedValue = decimalWordsMap[first];
                selectedValue2 = nubersWordsMap[second];

                sb.Append(selectedValue);
                sb.Append(' ');
                sb.Append(selectedValue2);
                result = sb.ToString();
            }

            if (numberParsed > 100 && numberParsed < 1000)
            {
                string first = number.Substring(0, 1);
                string second = number.Substring(1, 1);
                string third = number.Substring(2, 1);

                selectedValue = hundredsWordsMap[first];
                selectedValue2 = decimalWordsMap[second];
                selectedValue3 = nubersWordsMap[third];

                sb.Append(selectedValue);
                sb.Append(' ');
                sb.Append(selectedValue2);
                sb.Append(' ');
                sb.Append(selectedValue3);
                result = sb.ToString();
            }

            return result;
        }
        //532-> Piećset trzydziesty drugi

    }
}
