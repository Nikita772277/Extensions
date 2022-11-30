using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static int CharCount(this string word, char c)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                    counter++;
            }
            if (counter >= 3)
            {
                Console.WriteLine($"Буква встречается часто");
            }
            else if (counter < 3 && counter > 0)
            {
                Console.WriteLine($"Буква встречается редко");
            }
            else if (counter == 0)
            {
                Console.WriteLine($"Буква не встречается");
            }
            return counter;
        }
        public static void CheckEvenOdd(this int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число чётное");
            }
            else if (number % 2 > 0)
            {
                Console.WriteLine($"Число не чётное");
            }
        }
        public static string CheckingNumber(this string number)
        {
            Regex regex1 = new(@"^\+7\d{10}$");
            Regex regex2 = new(@"^8\d{10}$");
            var result1 = regex1.IsMatch(number);
            var result2 = regex2.IsMatch(number);
            if (result1)
            {
                Console.WriteLine($"Номер валиден");
            }
            else if (result2)
            {
                number = "+7" + number.Remove(0, 1);
                Console.WriteLine($"Номер валиден после преобразования");
            }
            else
            {
                Console.WriteLine($"Номер не валиден");
            }
            return number;
        }
    }
}
