//Цикл foreach пример использования
void PrintArray(int[] array)
{
for(int i = 0; i< array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}

void PrintArrayForEach(int[] array)
{
foreach(int item in array)
{
//int item = array[i], в цикле по i

    Console.Write($"{item} ");
}
}

var array = new int[8];
Random rnd = new Random();

for(int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(1,10);
}

Console.WriteLine("Вывод через цикл for: ");
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Вывод через цикл foreach: ");
PrintArrayForEach(array);

var clients = new Client[100];
//заполнили 100 клиентами

var accountsOfConfirmedClients = clients
.Where(client=> client.IsConfirmed)
.SelectMany(client=>client.AccountsArr)
.ToArray();

foreach(var account in accountsOfConfirmedClients)
{
foreach(var card in account.CardsArray)
{
Console.WriteLine(card.CardNumber);
}
}

for(int i=0; i<accountsOfConfirmedClients.Length; i++)
{
for(int j=0; j< accountsOfConfirmedClients[i].CardsArray.Length; j++)
{
Console.WriteLine(accountsOfConfirmedClients[i].CardsArray[j].CardNumber);
}
}

class Client
{
public Account[] AccountsArr{get;set;}
public bool IsConfirmed{get;set;}
}

class Account
{
public Card[] CardsArray {get;set;}
}

class Card
{
public string CardNumber{get;set;}
}