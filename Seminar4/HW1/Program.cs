// 1. Ввод N
int GetNumberByUser()
{
  Console.Write("Введите числа" + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива

int[] CreateArr(int Number)
{
  int[] arr = new int[Number];
  return arr;
}

// 3. Заполнение массива 0 и 1
void FillArray(int[] colectNumber)
{

  int count = colectNumber.Length;
  for (int i = 1; i < count; i++)
  {
    colectNumber[i] = Random.Shared.Next(2);
  }
  colectNumber[0] = 1;
}
// 4. Печать массива
string PrintArray(int[] Numbers)
{
  string output = string.Empty;
  int size = Numbers.Length;

  for (int i = 0; i < size; i++)
  {
    output = output + $"{Numbers[i]} ";

  }
  return output;
}


// 5. Конвертация из 2-ого в 10-ое
int BinTo(int[] arrBin)
{
  int count = arrBin.Length;
  int exponent = arrBin.Length - 1;
  int result = 0;
  for (int i = 0; i < arrBin.Length; i++)
  {
    if (arrBin[i] == 1)
    {
      result += Convert.ToInt32(Math.Pow(2, exponent));
    }
    exponent--;
  }
  return result;
}
// 6. 10110100 >> 180
string GoodPrint(int[] bin, int dec)
{
  return $"{String.Join("", bin)} >> {dec}";
}

int Number = GetNumberByUser();
int[] arr = CreateArr(Number);
FillArray(arr);
int result = BinTo(arr);
string BinPrint = PrininttArray(arr);
Console.WriteLine(BinPrint);
Console.WriteLine(GoodPrint(arr, result));