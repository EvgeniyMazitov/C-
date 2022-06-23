/*
7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6   782 -> 2   918 -> 8
*/

Console.WriteLine("Введите число");
string NumberUser = Console.ReadLine();
Console.WriteLine(NumberUser[NumberUser.Length-1]);

/*
char q = 'f';

char [] temp = new char [3]



Console.WriteLine("Введите трехзначное число:");
string NumberUser = Console.ReadLine();
int number = int.Parse(NumberUser);

if (number > 99 & number <1000)
{
    Console.WriteLine($"Последняя цифра {number % 10}");
}
else
    Console.WriteLine("Число введено с ошибкой");

*/