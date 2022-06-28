/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели (1-7) : ");
string numberUser = Console.ReadLine();
bool numberTest = int.TryParse(numberUser, out int number);

if (numberTest == false)
    Console.WriteLine("Введено не число");
else if (number < 1 || number > 7)
    Console.WriteLine("Введено число не соответствующее дню недели (1-7)");
else if (number > 0 && number < 6)
    Console.WriteLine("Не является выходным днем");
else
    Console.WriteLine("Является выходным днем");