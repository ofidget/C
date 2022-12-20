//ветка для создания запроса на совместную работу
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

Console.WriteLine("Программа поиска количества четных чисел в случайно заполненном трехзначными положительными числами  массиве");
void FillArray( int[,] arr)
{
   Random random = new Random(); 
    for(int i=0; i<arr.GetLength(0); i++)
    {
    for(int j=0; j<arr.GetLength(1); j++)
        {   
        arr[i,j]= random.Next(100,999);
        }
    }
} 
 
void PrintArray( int[,] arr)
{
 
    for(int i=0; i<arr.GetLength(0); i++)
    {
    for(int j=0; j<arr.GetLength(1); j++)
        {   
        Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    }
int rowCount = 3;
int columnCount = 4;
int [,] array = new int[rowCount,columnCount];
int Count = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
 for(int i=0; i < array.GetLength(0); i++)
    {
    for(int j=0; j < array.GetLength(1); j++)
        {   
            if (array[i,j] % 2 == 0)
            Count++;
        }
    }
Console.WriteLine("количество четных чисел в представленном массиве " + Count);
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// //  [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// // [3.3 7.76 22 2 78.67] -> 76.67
