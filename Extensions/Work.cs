using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Work
    {
        public void CheckingSymbol()
        {
            Console.WriteLine($"Введите слово");
            string word = Console.ReadLine();
            Console.WriteLine($"Введите символ на наличие которого хотите проверить слово");
            string symbol = Console.ReadLine();
            bool check = char.TryParse(symbol, out char result);
            if (check)
            {
                word.CharCount(result);
            }
            else
            {
                Console.WriteLine($"Вы ввели не букву");
            }
        }
        public void EvenOdd()
        {
            Console.WriteLine($"Введите число");
            string number = Console.ReadLine();
            bool check = int.TryParse(number,out var result);
            if (check)
            {
                result.CheckingNumber();
            }
            else { Console.WriteLine($"Вы ввели не число"); }
        }     
        public void Number()
        {
            Console.WriteLine($"Введите номер телефона");
            string number= Console.ReadLine();
            var a=number.Replace(" ", "");
            a.CheckingNumber();

        }
    }
}
