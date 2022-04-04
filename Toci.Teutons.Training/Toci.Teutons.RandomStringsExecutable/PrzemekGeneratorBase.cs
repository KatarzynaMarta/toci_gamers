using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.RandomStringsExecutable
{
    public abstract class PrzemekGeneratorBase
    {
        public virtual string GenerateString()
        {

            Console.WriteLine("Get Random String - 1 \n" +
                "Get Random Password - 2 \n" +
                "Get Strong Random Password - 3");

            ConsoleKeyInfo choiceKey = Console.ReadKey();


            if (choiceKey.Key.Equals(ConsoleKey.D1) | choiceKey.Key.Equals(ConsoleKey.D2) | choiceKey.Key.Equals(ConsoleKey.D3))
            {
                StringBuilder sb = new StringBuilder();

                int choice = int.Parse(choiceKey.KeyChar.ToString());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nPass First Integer (MinLength String) ");
                        if(int.TryParse(Console.ReadLine(), out int minLengthInput) && minLengthInput >= 0)
                        {
                            Console.WriteLine("Pass Second Integer (MaxLength String) ");

                            if (int.TryParse(Console.ReadLine(), out int maxLengthInput) && maxLengthInput > minLengthInput) 
                                GetRandomString(minLengthInput, maxLengthInput, ref sb);
                            else return "\nWrong maxLengthInput";
                        }
                        else return "\nWrong minLengthInput";


                        break;

                    case 2:
                        GetRandomPassword(ref sb);

                        break;

                    case 3:
                        GetStrongRandomPassword(ref sb);

                        break;

                }

                Console.WriteLine("\n\nGenerated string length = " + sb.ToString().Length);

                return sb.ToString();
            }
            else return "\nInvalid number option";
        }

        protected abstract void GetRandomString(int minLength, int maxLength, ref StringBuilder sbResult);

        protected abstract void GetRandomPassword(ref StringBuilder sbResult); // edascx86A

        protected abstract void GetStrongRandomPassword(ref StringBuilder sbResult); // F_we23@azWEc^&8

        // ascii
    }
}
