﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("День недели:");
int N = int.Parse(Console.ReadLine());
string  s = "не день недели";
if (N >= 1 && N <= 5)
    {
        s = "не выходной";
    }
      if (N >= 6 && N <=7)
        {
          s = "ВЫХОДНОЙ";
        }
    
Console.Write(s);