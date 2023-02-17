// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое цисло:");
int number = Convert.ToInt32(Console.ReadLine());
int index = Convert.ToInt32(Math.Log10(number));

if (number < 100)

  Console.WriteLine("Третьей цифры нет");

else if (number < 1000)

  Console.WriteLine(number % 10);

else
{
  int temp1 = Convert.ToInt32(Math.Pow(10, index - 2));
  int temp2 = number / temp1;
  int temp3 = Convert.ToInt32(Math.Pow(10, index - 3));
  int temp4 = number / temp3;
  int temp5 = temp4 - temp2 * 10;
  Console.WriteLine(temp5);
}