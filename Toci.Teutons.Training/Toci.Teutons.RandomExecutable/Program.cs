using System;

namespace Toci.Teutons.RandomExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say something:");

            /*string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput[i]);
            }*/

            Difference(new[] { 4,  6,7, 8, 12, 5, 17, 9 }, new[] { 3,7,8,9,1,2 });

            Console.ReadKey();
        }

        static int[] Difference(int[] first, int[] second)
        {
            int resultLength = first.Length > second.Length ? first.Length : second.Length; // ??

            int[] result = new int[resultLength];

            int resultCount = 0;

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        break;
                        
                    }

                    if (j == second.Length - 1)
                    {
                        result[resultCount] = first[i];
                        resultCount++;
                    }
                }
            }

            return result;
        }
        // 1,2,3 | 3,2,4

        static int[] Intersect(int[] first, int[] second)
        {
            int resultLength = first.Length > second.Length ? first.Length : second.Length; // ??

            int[] result = new int[resultLength];

            int resultCount = 0;

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        result[resultCount] = first[i];
                        resultCount++;
                    }
                }
            }

            return result;
        }
    }
}
