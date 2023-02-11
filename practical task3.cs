/*int N = Convert.ToInt32(Console.ReadLine());
while (N < 10000 && N > 100000);

 if((N % 10 * 100 + N /10 % 10 * 10 + N / 100 % 10) == N / 100)
      Console.WriteLine(" - > да");
 else Console.WriteLine(" - > нет");
 Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
double Distance(double xA, double yA, double zA,double xB, double yB, double zB)
{double distanceX = xB - xA;
double distanceY = yB - yA;
double distanceZ = zB - zA;
double distance = Math.Sqrt(Math.Pow(distanceX,2) + Math.Pow(distanceY,2) + Math.Pow(distanceZ,2));
return distance;
}
Console.WriteLine("enter the coordinate x of point A(xA)");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the coordinate y of point A(yA)");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the coordinate z of point A(zA)");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the coordinate x of point B(xB)");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the coordinate y of point B(yB)");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the coordinate z of point B(zB)");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("segment length A(" + xA + ", " + yA + ", "+ zA+ "); B(" + xB + ", " + yB+ ", " + zB + ") -> " + Math.Round(Distance(xA, yA, zA, xB, yB, zB),2));
 /*Задача 23 



Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void CubeOfNumbersToN(int Num)
{Console.Write("1");
for(int i = 2; i <= Num; i++)
Console.Write(", " + Math.Pow(i,3));
}

Console.WriteLine("Введите положительное число");
int N = Convert.ToInt32(Console.ReadLine());
CubeOfNumbersToN(N);*/

