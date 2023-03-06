/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/


int number = Prompt("ВВедите натуральное число ");
int exponent = Prompt("ВВедите степень числа ");
if (exponent > 0) PrintExp(number, exponent );
else Console.WriteLine("Степень числа должна быть положительным числом. Поробуйте ввести значение заново");

void PrintExp(int n, int m)
{ 
 double q = Math.Pow(n, m);

    Console.WriteLine($"Число {n} в степени {m}  = {q} ");
    
}

int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}