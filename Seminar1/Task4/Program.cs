/*
5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

//Console.WriteLine("Все целые числа от -N до N");

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int numberN = int.Parse(number);
int numberN2 = - numberN;

for (int i = numberN2; i <= numberN; i++)
{
    Console.WriteLine(i);
}