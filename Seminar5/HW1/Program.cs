//Найдите произведение пар чисел в одномерном массиве. 

//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

//Результат запишите в новом массиве.

//СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

Console.Write($"Введи число  (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

InputNumbers(m);
int[] arr = MultArray(massiveNumbers);
Console.WriteLine("Произведение пар чисел: " + (PrintArray(arr)));

//1.Ввод массива
void InputNumbers(int m)
{
  for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i + 1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

//2.произведение пар чисел
int[] MultArray(int[] array)
{
  int[] mult = new int[array.Length / 2];

  for (int i = 0; i < array.Length / 2; i++)
  {
    mult[i] = array[i] * array[array.Length - 1 - i];
  }
  return mult;
}

// 3.печать массива
string PrintArray(int[] numbers)
{
  string output = string.Empty;
  int size = numbers.Length;

  for (int i = 0; i < size; i++)
  {
    output = output + $"{numbers[i]} ";

  }
  return output;
}






