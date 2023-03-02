/*Напишите программу, которая принимает 
на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите  X координату первой точки: ");
int Ха = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Y координату первой точки: ");
int Yа = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Z координату первой точки: ");
int Zа = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  X координату второй точки: ");
int Хb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Y координату второй точки: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  Z координату второй точки: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double result = Distance (Ха,Yа,Zа,Хb,Yb, Zb);
Console.Write(Math.Round (result,2, MidpointRounding.ToZero));
 
double Distance (int Х1, int Y1, int Z1, int Х2,int Y2, int Z2)
{
    double SumSquare = ((Х1-Х2)*(Х1-Х2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
    double res = Math.Sqrt(SumSquare);
    return res;
}