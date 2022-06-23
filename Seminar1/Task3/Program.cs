/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
  3 -> Среда 
5 -> Пятница
*/
Console.WriteLine("Введите номер дня недели");
string WeekDayUser = Console.ReadLine();
int WeekDay = int.Parse(WeekDayUser);

if (WeekDay == 1)
{
    Console.WriteLine($"Введен {WeekDay} день недели понедельник");
}
else if (WeekDay == 2)
    {
        Console.WriteLine($"Введен {WeekDay} день недели вторник");
    } 

else if (WeekDay == 3)
    {
        Console.WriteLine($"Введен {WeekDay} день недели среда");
    }

else if (WeekDay == 4)
    {
        Console.WriteLine($"Введен {WeekDay} день недели четверг");
    }

else if (WeekDay == 5)
    {
        Console.WriteLine($"Введен {WeekDay} день недели пятница");
    }

else if (WeekDay == 6)
    {
        Console.WriteLine($"Введен {WeekDay} день недели суббота");
    }

else if (WeekDay == 7)
    {
        Console.WriteLine($"Введен {WeekDay} день недели воскресенье");
    }

else
{
     Console.WriteLine("Введен ошибочный день недели");
}