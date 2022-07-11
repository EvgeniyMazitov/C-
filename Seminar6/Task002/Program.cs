/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
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

int Multi(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine($"Треугольник со сторонами a={a}, b={b}, c={c} существует");
    else
        Console.WriteLine($"Треугольник со сторонами a={a}, b={b}, c={c} не существует");


}

int a = GetNumber("Введите размер первой стороны: ");
int b = GetNumber("Введите размер второй стороны: ");
int c = GetNumber("Введите размер третьей стороны: ");

Triangle(a, b, c);