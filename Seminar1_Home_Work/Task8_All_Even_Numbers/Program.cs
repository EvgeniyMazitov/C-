/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число:");
string NumberUser = Console.ReadLine();
bool NumberTest = int.TryParse(NumberUser, out int Number);

if (NumberTest == false)
    Console.WriteLine("Введено не число");
else if (Number >= 2)
{
    for (int i = 2; i <= Number; i += 2)
    {
        if (Number - i > 1)
            Console.Write($"{i}, ");
        else
            Console.Write(i);
    }
}
else Console.WriteLine("Введено число в диапазоне (-оо;2). Последовательность не может быть сформирована");
