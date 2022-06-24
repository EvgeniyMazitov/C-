/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число:");
string FirstNumberUser = Console.ReadLine();
bool FirstNumberTest = int.TryParse(FirstNumberUser, out int FirstNumber);

if  (FirstNumberTest == false)
    Console.WriteLine("Введено не число");
else
    {
       if (FirstNumber % 2 == 0) 
        Console.WriteLine($"Число {FirstNumber} является четным");

        else
            Console.WriteLine($"Число {FirstNumber} является нечетным");
    }