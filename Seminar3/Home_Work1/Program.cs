//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да


int val1 = 12821;
int val2 = 0;
int t = val1;

while (val1 != 0)
{
  int o = val1 % 10;
  val1 = val1 / 10;
  val2 = val2 * 10 + o;
}
Console.WriteLine(val1);
Console.WriteLine(t == val2);