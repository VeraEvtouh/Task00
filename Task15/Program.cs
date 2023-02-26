/* Напишите программу,
 которая принимает на вход цифру, 
 обозначающую день недели, 
 и проверяет, является ли этот день выходным.*/


Console.WriteLine("Введите   число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.Write("Это выходной день");
}
else if (num > 0 && num < 6)
    Console.Write("Это будний день");
else Console.Write("Такого дня недели нет");