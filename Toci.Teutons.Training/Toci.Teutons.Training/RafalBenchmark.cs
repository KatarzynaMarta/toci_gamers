using System;
using System.Text;

namespace Toci.Teutons.Training
{

    public class RafalBenchmark
    {
        private static string[] letters = { "Q", "q", "W", "w", "E", "e", "R", "r", "T", "t", "Y", "y", "U", "u", "I", "i", "O", "o", "P", "p", "A", "a", "S", "s", "D", "d", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "f", "g", "h", "j", "k", "l", "z", "x", "v", "b", "n", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "&", ")", "_", "?" };
        public static string PasswordTask(int value, int lenghtPassword)                               //wartość skomplikowania hasła + długość predefiniowana przez użytkownika
        {
            value = (value % 3) + 1;
            string password = "";
            Random random = new Random();
            int randomNumber = 0;

            for (int i = 0; i < lenghtPassword; i++)                                            //losowanie hasła
            {
                int listNumber = random.Next(value);                                            //losowanie numeru w zależności od podania jak złożene ma być hasło

                if (listNumber == 0)                                                            //warunek losowania który znak z listy wejdzie, w zależności która lista została wybrana
                {
                    randomNumber = random.Next(0, 50);
                    password += letters[randomNumber];
                }
                else if (listNumber == 1)
                {
                    randomNumber = random.Next(51, 60);
                    password += letters[randomNumber];
                }
                else
                {
                    randomNumber = random.Next(61, 69);
                    password += letters[randomNumber];
                }
            }
            return password;
        }

    }
}