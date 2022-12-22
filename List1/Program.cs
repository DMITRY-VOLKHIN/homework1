// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string numbers = Console.ReadLine();
int b = numbers.Length;
if (b == 5)
{
    if ( numbers [0] == numbers [4] && numbers [1] == numbers [3])
    {
        Console.WriteLine($"{numbers} - yes");
    }
    else
    {
        Console.WriteLine($"{numbers} - no");
    }
}
else
{
    Console.WriteLine($"Не пятизначное число");
}