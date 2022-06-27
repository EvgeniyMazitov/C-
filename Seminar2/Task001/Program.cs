/*
. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8

*/

Random rnd = new Random();
int number = rnd.Next(10,100); //[10, 100)

Console.WriteLine($"Сгенерированное число {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)
    Console.WriteLine(firstDigit);
else if(secondDigit > firstDigit)
    Console.WriteLine(secondDigit);
else
    Console.WriteLine("Числа равны");