using System;
using System.Threading;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomExecutable
{
    class Program
    {
  
        static void WidthChange()
        {
            int Width = Console.WindowWidth;

            while (true)
            {
                if (Width != Console.WindowWidth)
                {
                    RenderLine(Console.WindowWidth - Width);
                    Width = Console.WindowWidth;
                }

                Thread.Sleep(100);
            }
        }

        static void RenderLine(int widthChange)
        {
            if (widthChange > 0)
            {
                for (int i = 0; i < widthChange; i++)
                {
                    Console.Write("-");
                }
            }
            else
            {
                for (int i = widthChange; i < 0; i++)
                {
                    Console.Write("\b \b");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Say something:");

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }

            TaskFactory taskFactory = new TaskFactory();

            taskFactory.StartNew(WidthChange);

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
