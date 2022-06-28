/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите число :");
string numberUser = Console.ReadLine();
bool numberTest = int.TryParse(numberUser, out int number);

if (numberTest == false)
    Console.WriteLine("Введено не число");
else if (Math.Abs(number) < 100)
    Console.WriteLine("Третьей цифры числа нет");
else
{
    Console.WriteLine($"Третья цифра числа = {numberUser[2]}");
}