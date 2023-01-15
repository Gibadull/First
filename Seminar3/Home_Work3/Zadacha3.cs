//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N




void Cube(int size)
{
  for (int i = 1; i <= size; i++)
    Console.WriteLine(Math.Pow(i, 3));
}

Cube(5);