//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

class GFG
{
     
static void distance(double x1, double y1,
                     double z1, double x2,
                     double y2, double z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) * 1.0), 0.5);
                         // Фукция возведения в степень
    Console.WriteLine("Дистанция между точками: " + d);
    return;
}
 
public static void Main()
{
    double x1 = 3;
    double y1 = 6;
    double z1 = 8;
    double x2 = 2;
    double y2 = 1;
    double z2 = -7;
     
   
    distance(x1, y1, z1,
             x2, y2, z2);
}
}
 