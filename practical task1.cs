// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// if    (a > b)
// { Console.WriteLine(a);}
// else
// { Console.WriteLine(b);}

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// //  2, 3, 7 -> 7
// // /44 5 78 -> 78
// //  22 3 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int m = 0;
if   (a > b)
{m = a;}
else
{m = b;}
    if (m<c) 
    { m = c;
    Console.WriteLine(m);}
    else
    {Console.WriteLine(m);}



// // Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// //  4 -> да
// //  -3 -> нет
// //  7 -> нет

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if    (a % 2 == 0)
// { Console.WriteLine("Число четное");}
// else
// { Console.WriteLine("Число не четное");}


// //  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// //  5 -> 2, 4
// //  8 -> 2, 4, 6, 8

// Console.WriteLine("Введите положительное число");
// int b = Convert.ToInt32(Console.ReadLine());
// int i=2;
// while (i<=b)
// {
//     Console.WriteLine(i);
//     i=i+2;
// }
   //ойой