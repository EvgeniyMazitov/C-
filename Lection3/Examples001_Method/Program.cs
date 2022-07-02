

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Текст");

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

int Method4(int count, char c)
{
    int i = 0;
    string result = string.Empty;

while (i<count)
{
    result = result + text;
    i++;
}
return result;
}

string res=Method4(10, "z");
Console.WriteLine(res);