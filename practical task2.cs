﻿// // Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("вторая цифра числа " + ((N/10)%10));

// // Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6
// Console.WriteLine("Введите число");
// int Num = Convert.ToInt32(Console.ReadLine());
// if (Num < 100)
//  {Console.WriteLine("третьей цифры нет");
// }
// else 
// { while (Num > 999)
//    Num = Num/10;
//  Console.WriteLine("третья цифра числа " + (Num%10));
//   }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет
// // Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// // 14 -> нет
// // 46 -> нет
// // 161 -> да
Console.WriteLine("Введите номер дня недели");
int L = Convert.ToInt32(Console.ReadLine());
if (L == 6 || L == 7)

{
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Не выходной, либо число не является порядковым номером дня недели");