// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число:");
int N =int.Parse(Console.ReadLine());
int b =0;
if (N >=100 && N < 1000) b = (N / 10) % 10;
else Console.WriteLine("число кривое");
Console.WriteLine($"Вторая цифра: {b}");
