﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

ThirdNumber();

static void ThirdNumber()
{
  Console.Write("Введи трёхзначное число: ");
  int Number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(Number % 100 / 10);
}

