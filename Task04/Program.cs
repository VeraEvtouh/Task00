//Напишите программу, 
//которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите  первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int numMAx = 0;
if (num1 >= num2 && num1 >= num3)
    numMAx = num1;
else if (num2 >= num1 && num2 >= num3)
    numMAx = num2;
else if (num3 >= num1 && num3 >= num2)
    numMAx = num3;
Console.Write($"Большее число = {numMAx}");
