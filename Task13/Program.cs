/* Напишите программу,
 которая выводит третью цифру 
 заданного числа или 
 сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите   число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("третья цифра числа =  " + numberText[2]);
}
else
{
    Console.WriteLine(" третьей цифры нет");
}