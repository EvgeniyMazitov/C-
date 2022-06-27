/*
Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит 
остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

*/

Console.WriteLine ("Введите первое число");
String FirstStr = Console.ReadLine();
int first = int.Parse(FirstStr);

Console.WriteLine ("Введите второе число");
String SecondStr = Console.ReadLine();
int second = int.Parse(SecondStr);

int Remember = first % second;

if (Remember == 0)
{
    Console.WriteLine("Число кратное");
}
else
{
    Console.WriteLine($"Число не кратное, остаток {Remember}");
}