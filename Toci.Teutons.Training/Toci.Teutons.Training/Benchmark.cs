using System;
using System.Text;

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

        public static string NumberToText(int value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            if (value == 0)
                return anotherNumber[0];
            else if (value == 100)
                return anotherNumber[1];
            else if (value == 1000)
                return anotherNumber[2];
            else if (value == 1000000)
                return anotherNumber[3];
            else if (value == 1000000000)
                return anotherNumber[4];

            // obliczanie 0-999

            int jed = value % 10;
            int dzie = value % 100;
            int set = (value % 1000) / 100;
            if (dzie > 10 && dzie < 20)
                stringBuilder.Insert(0, elevenPlus[jed]);
            else
            {
                stringBuilder.Insert(0, unity[jed]);
                stringBuilder.Insert(0, dozens[dzie / 10]);
            }
            stringBuilder.Insert(0, hundreds[jed]);

            // dla pozostałych liczb do miliardów

            value = value / 1000;
            int rowsNumber = 0;
            while (value > 0)
            {
                jed = value % 10;
                dzie = value % 100;
                set = (value % 1000) / 100;
                bool rowsTrue = value % 1000 != 0;
                if ((value % 1000) / 10 == 0)
                {
                    //nie ma dziesiątek i setek
                    if (jed == 1)
                        stringBuilder.Insert(0, rows[rowsNumber, 0]);
                    else if (jed >= 2 && jed <= 4)
                        stringBuilder.Insert(0, rows[rowsNumber, 1]);
                    else if (rowsTrue)
                        stringBuilder.Insert(0, rows[rowsNumber, 2]);
                    if (jed > 1)
                        stringBuilder.Insert(0, unity[jed]);
                }
                else
                {
                    if (dzie >= 10 && dzie < 20)
                    {
                        stringBuilder.Insert(0, rows[rowsNumber, 2]);
                        stringBuilder.Insert(0, elevenPlus[dzie % 10]);
                    }
                    else
                    {
                        if (jed >= 2 && jed <= 4)
                            stringBuilder.Insert(0, rows[rowsNumber, 1]);
                        else if (rowsTrue)
                            stringBuilder.Insert(0, rows[rowsNumber, 2]);
                        stringBuilder.Insert(0, unity[jed]);
                        stringBuilder.Insert(0, dozens[dzie / 10]);
                    }
                    stringBuilder.Insert(0, hundreds[set]);
                }
                rowsNumber++;
                value = value / 1000;
            }
            return stringBuilder.ToString();

        }

        private static string[] unity = { "", "pierwszy", "drugi", "trzeci",
        "czwarty", "piąty", " szósty", "siódmy", "ósmy", "dziewiąty"};
        private static string[] dozens = { "", " dziesiąty ", " dwudziesty ",
        " trzydziesty ", " czterdziesty ", " pięćdziesiąty ",
        " sześćdziesiąty ", " siedemdziesiąty ", " osiemdziesiąty ",
        " dziewięćdziesiąty "};
        private static string[] hundreds = { "", " sto ", " dwieście ", " trzysta ",
        " czterysta ", " pięćset ", " sześćset ",
        " siedemset ", " osiemset ", " dziewięćset " };
        private static string[,] rows = {{" tysiąc ", " tysiące ", " tysięcy "},
                            {" milion ", " miliony ", " milionów "},
                            {" miliard ", " miliardy ", " miliardów "}};
        private static string[] elevenPlus = { "dziesięć", " jedenaście ", " dwanaście ",
        " trzynaście ", " czternaście ", " piętnaście ", " szesnaście ",
        " siedemnaście ", " osiemnaście ", " dziewiętnaście "};
        private static string[] anotherNumber = { "zerowy", "setny" , "tysięczny", "milionowy", "miliardowy"};

        // 532 -> Pięćset trzydziesty drugi
        //
    }
}
