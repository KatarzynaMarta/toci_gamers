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
                string result = string.Empty;

                int choice = int.Parse(choiceKey.KeyChar.ToString());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nPass First Integer (MinLength String) ");
                        if(int.TryParse(Console.ReadLine(), out int minLengthInput) && minLengthInput >= 0)
                        {
                            Console.WriteLine("Pass Second Integer (MaxLength String) ");

                            if (int.TryParse(Console.ReadLine(), out int maxLengthInput) && maxLengthInput > minLengthInput)
                                result = GetRandomString(minLengthInput, maxLengthInput);
                            else return "\nWrong maxLengthInput";
                        }
                        else return "\nWrong minLengthInput";


                        break;

                    case 2:
                        result = GetRandomPassword();

                        break;

                    case 3:
                        result = GetStrongRandomPassword();

                        break;

                }

                Console.WriteLine("\n\nGenerated string length = " + result.Length);

                return result;
            }
            else return "\nInvalid number option";
        }

        protected abstract string GetRandomString(int minLength, int maxLength);

        protected abstract string GetRandomPassword(); // edascx86A

        protected abstract string GetStrongRandomPassword(); // F_we23@azWEc^&8

        // ascii
    }
}
