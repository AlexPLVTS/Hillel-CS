using System.ComponentModel.Design;
using System.Transactions;

Console.WriteLine("Enter the day of the week number");

string enter = Console.ReadLine();

long dayOfWeek;

if (long.TryParse(enter, out dayOfWeek))
// Щоб "конвертувати" string в bool використав цей матеріал (https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number) так як ми це не проходили окремо
{
    if (dayOfWeek == 1)
    {
        Console.WriteLine("Monday");
    }
    else if (dayOfWeek == 2)
    {
        Console.WriteLine("Tuesday");
    }
    else if (dayOfWeek == 3)
    {
        Console.WriteLine("Wednesday");
    }
    else if (dayOfWeek == 4)
    {
        Console.WriteLine("Thursday");
    }
    else if (dayOfWeek == 5)
    {
        Console.WriteLine("Friday");
    }
    else if (dayOfWeek == 6)
    {
        Console.WriteLine("Saturday");
    }
    else if (dayOfWeek == 7)
    {
        Console.WriteLine("Sunday");
    }
    else
    {
        Console.WriteLine("Error: enter number from 1 to 7");
    }
}
else
{
    Console.WriteLine("Error: incorrect input, enter whole number please");
}