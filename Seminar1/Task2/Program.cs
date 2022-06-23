/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число");
string FirstNumberUser = Console.ReadLine();
int FirstNumber = int.Parse(FirstNumberUser );

Console.WriteLine("Введите первое число");
string SecondNumberUser = Console.ReadLine();
int SecondNumber = int.Parse(SecondNumberUser);

if (SecondNumber*SecondNumber == FirstNumber)
    {
        Console.WriteLine($"Первое число {FirstNumber} является квадратом второго числа {SecondNumber}");
    }    
        else
        {
             Console.WriteLine($"Первое число {FirstNumber} не является квадратом второго числа {SecondNumber}");
        }