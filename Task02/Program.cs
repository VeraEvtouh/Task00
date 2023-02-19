//Напишите программу,
// которая на вход
//принимает два числа и выдаёт,
//какое число большее, а
//какое меньшее

Console.WriteLine("Введите  первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"Большее число - {num1}; меньшее число - {num2}");
}
else Console.Write($"Большее число - {num2}; меньшее число - {num1}");
