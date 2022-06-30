/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result >= 1 && result <= 4)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}



void ReturnInterval(int quarter)
{
    if (quarter == 1)
        Console.WriteLine("х в интервале [0 до +oo), y в интервале [0 до +oo)");
    else if (quarter == 2)
        Console.WriteLine("х в интервале (-oo до 0], y в интервале [0 до +oo)");
    else if (quarter == 3)
        Console.WriteLine("х в интервале (-oo до 0], y в интервале (-oo до 0]");
    else
        Console.WriteLine("х в интервале [0 до +oo), y в интервале (-oo до 0]");
}
int quarter = GetNumber("Введите номер четверти:");
ReturnInterval(quarter);