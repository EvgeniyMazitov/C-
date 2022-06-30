/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

AB = √(xb - xa)2 + (yb - ya)2


A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int x1 = GetNumber("Введите координату х1: ");
int y1 = GetNumber("Введите координату y1: ");
int x2 = GetNumber("Введите координату х2: ");
int y2 = GetNumber("Введите координату y2: ");

double length = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)),3);

Console.WriteLine($"Расстояние между точками = {length}");