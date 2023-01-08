//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите чиcло:  ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
  Console.WriteLine("Да");

}
else
{
  Console.WriteLine("Нет");
}