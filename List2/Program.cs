// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Привет хозяин");
Console.WriteLine("Введите трехзначное число:");
int N =int.Parse(Console.ReadLine());
int b =0;
if (N >=100 && N < 1000) b = N  % 10;
if (b < 3)
    Console.WriteLine("третьей цифры нет");
else 
    {
        Console.WriteLine($"Третья цифра: {b}");
    }
