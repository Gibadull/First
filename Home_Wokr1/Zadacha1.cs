//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int firstA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondB = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (firstA > secondB) 
 
{
  max = firstA;
  min = secondB;}
else 
  {
  max = secondB;
  min = firstA;
}
Console.WriteLine("max = второе число min=первое число");