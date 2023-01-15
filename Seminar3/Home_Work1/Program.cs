//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да


int GetNumberByUser()
{
  Console.Write("Введите числа" + ": ");
  int val1 = Convert.ToInt32(Console.ReadLine());
  return val1;
}

int val1 = GetNumberByUser();
int val2 = 0;
int t = val1;

while (val1 != 0)
{
  int o = val1 % 10;
  val1 = val1 / 10;
  val2 = val2 * 10 + o;
}
Console.WriteLine($"Число является палиндромом?");
Console.WriteLine((t == val2));