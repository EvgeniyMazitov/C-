/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

https://docs.microsoft.com/ru-ru/dotnet/csharp/



Random rnd = new Random();

double result = Math.Pow(2,10);

Math.Abs(-4);

int number = 10;
InsertToDb(number);
Console.WriteLine(number);

MyClass Item = new MyClass
{
    DisplayName = "3232333",
    Id = 120
};

InsertToDb(item);

Console.WriteLine($"DisplaName: {item.DisplayName} ID: {item.Id}");

void SomeFunction(MyClass item)
{
    //требуха, которая не вернет значений, а просто выполнится

    item.DisplayName = null;
    item.id = 0;
}

String AnotherFunction()
{
    return string.Empty;
}
*/

int number = 1;
SomeFunction(ref number);
Console.WriteLine(number);

void SomeFunction(ref int number)
{
    number = 12;
}