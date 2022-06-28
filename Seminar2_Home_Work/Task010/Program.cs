/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число");
string numberUser = Console.ReadLine();
bool numberTest = int.TryParse(numberUser, out int number);

if (numberTest == false)
    Console.WriteLine("Введено не число");
else if ((Math.Abs(number) > 999) || (Math.Abs(number) < 100))
    Console.WriteLine($"Введено не трехзначное число");
else
{
    int result = Math.Abs((number / 10) % 10);
    Console.WriteLine($"Вторая цифра числа = {result}");
}