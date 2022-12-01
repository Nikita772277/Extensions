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
            Console.WriteLine($"Введите текст");
            string word = Console.ReadLine();
            if (word == "" || word == " ")
            {
                Console.WriteLine($"Вы ничего не ввели");
                return;
            }
            Console.WriteLine($"Введите символ на наличие которого хотите проверить слово");
            string symbol = Console.ReadLine();
            bool check = char.TryParse(symbol, out char result);
            if (check)
            {
                word.CharCount(result);
            }
            else
            {
                Console.WriteLine($"Вы ввели не символ");
            }
        }
        public void EvenOdd()
        {
            Console.WriteLine($"Введите число (максимальное число - 2 147 483 647)");
            string inputnumber = Console.ReadLine();
            bool check = int.TryParse(inputnumber, out var result);
            bool checkinputnumber = false;
            foreach (var i in inputnumber)
            {
                 checkinputnumber = char.IsLetter(i);
                if (checkinputnumber)
                {
                    break;
                }
            }
            if (check)
            {
                result.CheckEvenOdd();
            }
            else if(checkinputnumber) { Console.WriteLine($"Вы ввели не число"); }
            else
            {
                Console.WriteLine($"Введено число выходящее за пределы диапозона");
            }
        }
        public void Number()
        {
            Console.WriteLine($"Введите номер телефона");
            string number = Console.ReadLine();
            var a = number.Replace(" ", "");
            bool check = string.IsNullOrEmpty(a);
            bool check2 = false;
            foreach (char c in a)
            {
                check2 = char.IsLetter(c);
                if (check2) { break; }
            }
            if (check) { Console.WriteLine($"Вы нечего не ввели"); return; }
            else if (check2) { Console.WriteLine($"В номере телефона не должны присутствовать буквы"); return; }
            else
            {
                a.CheckingNumber();
            }
        }
    }
}
