//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82-> 10
//9012 -> 12

//1. Метод ввода числа
int GetNumber()
{
  Console.Write("Введите число: ");
  return Convert.ToInt32(Console.ReadLine());

}

// 2.Сложить числаа
int SummNumber(int value)
{
  if (value < 10)
    return value;

  int num = value % 10;
  int nextValue = value / 10;
  return num + SummNumber(nextValue);
}
int number = GetNumber();
int value = SummNumber(number);
Console.WriteLine("Сумма цифр в числе: " + SummNumber(number));