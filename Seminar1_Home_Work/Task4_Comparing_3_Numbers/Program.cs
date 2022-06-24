/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int max;

Console.WriteLine("Введите первое число");
string FirstNumberUser = Console.ReadLine();
bool FirstNumberTest = int.TryParse(FirstNumberUser, out int FirstNumber);

Console.WriteLine("Введите второе число");
string SecondNumberUser = Console.ReadLine();
bool SecondNumberTest = int.TryParse(SecondNumberUser, out int SecondNumber);

Console.WriteLine("Введите третье число");
string ThirdNumberUser = Console.ReadLine();
bool ThirdNumberTest = int.TryParse(ThirdNumberUser, out int ThirdNumber);

if (FirstNumberTest == false || SecondNumberTest == false || ThirdNumberTest == false)
    Console.WriteLine("Введено не число");

else

{
    max = FirstNumber;

    if (SecondNumber > max)
    {
        max = SecondNumber;
    }

    if (ThirdNumber > max)
    {
        max = ThirdNumber;
    }

    else
    {
        Console.WriteLine("Введенные числа равны");
    }

    Console.WriteLine($"max = {max}");
}