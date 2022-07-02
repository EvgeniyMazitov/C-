// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Текст сообщения");
// Ниже вариант вызова, если нужно указать конкретные аргументы при вызове,нужно, если аргументов больше, чем 1
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);

//пример явного указания вводимых аргументов ниже
//Method21(count: 4, msg: "Текст");

// Вид3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид4

string Method4(int count, string text)
{
    int i = 0;
    //string result = ""; - так можно, но это не комильфо, ниже лучше
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);