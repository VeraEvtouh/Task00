/*Напишите программу, которая 
принимает на вход пятизначное
 число и проверяет,
  является ли оно палиндромом.*/

  Console.WriteLine("Введите  пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int digit1 = digit/10000;
int digit2 = digit/1000 % 10;
int digit4 = digit/10 % 10;
int digit5 = digit % 10;
 if (digit > 9999 && digit < 100000)
     {
        if (digit1 == digit5 && digit2== digit4) 
  Console.Write($"Число {digit} -  является палиндромом");
   else Console.Write($"Число {digit} - не является палиндромом");
     }
     else Console.Write("Вы ввели некорректное число");
     