/*
Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Random rnd = new Random();
int number = rnd.Next(100,1000); //[10, 100)

Console.WriteLine($"Сгенерированное число {number}");




int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)
    Console.WriteLine(firstDigit);
else if(secondDigit > firstDigit)
    Console.WriteLine(secondDigit);
else
    Console.WriteLine("Числа равны");