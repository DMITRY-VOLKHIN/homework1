// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Привет хозяин");
Console.WriteLine("Введите трехзначное число:");
int N =int.Parse(Console.ReadLine());
int b =0;
if (N >=100)
{
    while (N >1000)
        {
            N = N / 10;
        }
    Console.WriteLine($"Третья цифра: {b = N  % 10}");
}
else Console.WriteLine("третьей цифры нет");