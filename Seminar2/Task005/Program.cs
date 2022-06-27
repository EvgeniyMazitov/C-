/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine ("Введите первое число");
String FirstStr = Console.ReadLine();
int first = int.Parse(FirstStr);

Console.WriteLine ("Введите второе число");
String SecondStr = Console.ReadLine();
int second = int.Parse(SecondStr);

if (first == second*second || second == first*first)
{
    Console.WriteLine("одно число является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно из чиел не является квадратом другого");
}