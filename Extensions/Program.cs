
using Extensions;

Work work = new();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Проверка наличия символа в тексте");
    Console.WriteLine($"2) Проверка чётное или нечётное число");
    Console.WriteLine($"3) Проверка номера телефона");
    Console.WriteLine();
}
void GetMenu()
{
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool check = int.TryParse(enter, out var result);
        if (result == 1)
        {
            work.CheckingSymbol();
        }
        else if (result == 2)
        {
            work.EvenOdd();
        }
        else if (result == 3)
        {
            work.Number();
        }
        else
        {
            Console.WriteLine($"Выберите пункт из меню");
        }
    }
}
GetMenu();