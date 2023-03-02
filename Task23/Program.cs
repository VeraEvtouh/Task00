/*Напишите программу, которая принимает
 на вход число (N)
  и выдаёт таблицу кубов чисел от 1 до N.*/

int number = Prompt("ВВедите натуральное число");
if (number > 0) PrintCube(number);
else Console.WriteLine("Введите натуральное число и выволните заново");

Void PrintCube(int n)
{
    Console.WriteLine("Число       куб числа");
    for (int i = 1; i <= n; i++)
    { Console.WriteLine($"{i,5}   {i*i*i,5}"); }

}

int Prompt(string message)
{
    Console.Write(message);
    int cc= Console.ToInt32(Console.ReadLine());
    return cc;
}