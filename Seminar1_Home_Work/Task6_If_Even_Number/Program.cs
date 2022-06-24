/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число:");
string NumberUser = Console.ReadLine();
bool NumberTest = int.TryParse(NumberUser, out int Number);

if (NumberTest == false)
    Console.WriteLine("Введено не число");
else
{
    if (Number % 2 == 0)
        Console.WriteLine($"Число {Number} является четным");

    else
        Console.WriteLine($"Число {Number} является нечетным");
}