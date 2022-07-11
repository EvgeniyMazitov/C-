/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

*/

/*
Прежде, чем решать, преобразуем математически, 
т.к. в точке пересечения координаты совпадают:

k1 * x + b1 = K2 * x + b2
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)

Тогда y можно выразить из первого уравнения:

y = k1 * x + b1 = ((b2 - b1) / (k1 - k2)) * k1 + b1

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

int b1 = GetNumber("Введите значение b1 для первого уравнения прямой y = k1 * x + b1 : ");
int k1 = GetNumber("Введите значение k1 для первого уравнения прямой y = k1 * x + b1 : ");
int b2 = GetNumber("Введите значение b2 для второго уравнения прямой y = k2 * x + b2 : ");
int k2 = GetNumber("Введите значение k2 для второго уравнения прямой y = k2 * x + b2 : ");

if (k1 - k2 == 0)
{
    Console.WriteLine($"Прямые с заданными параметрами не пересекаются");
}
else
{
    double x = (double) (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые с заданными параметрами пересекаются в точке (x ; y) = ({x} ; {y})");
}


