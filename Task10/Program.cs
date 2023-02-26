/* Напишите программу, которая принимает
 на вход трёхзначное число 
 и на выходе показывает
  вторую цифру этого числа.*/

Console.WriteLine("Введите  трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    int num1 = number / 10;
    int secondDigit = num1 % 10;

    Console.Write($"Вторая цифра числа - {secondDigit}");
}
else Console.Write("Число не является трехзначным");
