/*
Напишите программу, которая на входе принимает число и выдает его квадрат (число умноженное на само себя)
*/

Console.WriteLine("Введите число, которое хотите возвести в квадрат");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

int result = number * number;

//Console.WriteLine("Квадрат числа {1} равняется {2}", number, result);

Console.WriteLine($"Квадрат числа {number} равняется {result}");

//Console.WriteLine($"Квадрат числа" + number "равняется" + result);
