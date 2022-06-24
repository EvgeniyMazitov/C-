/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string FirstNumberUser = Console.ReadLine();
bool FirstNumberTest = int.TryParse(FirstNumberUser, out int FirstNumber);

Console.WriteLine("Введите второе число");
string SecondNumberUser = Console.ReadLine();
bool SecondNumberTest = int.TryParse(SecondNumberUser, out int SecondNumber);

if  (FirstNumberTest == false || SecondNumberTest == false)
    Console.WriteLine("Введена не цифра");
else if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"max = {FirstNumber}");
}

else if (FirstNumber < SecondNumber)
    {
        Console.WriteLine($"max = {SecondNumber}");
    }

else
{
    Console.WriteLine("Среди введенных данных невозможно определить максимальное");
}