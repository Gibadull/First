﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n

double A(double m, double n)
{
  if (m == 0)
    return n + 1;
  else if (m > 0 && n == 0)
    return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

Console.WriteLine(A(3, 2));