//ветка для создания запроса на совместную работу
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Программа поиска количества четных чисел в случайно заполненном трехзначными положительными числами  массиве");
// void FillArray( int[] arr)
// {
//    Random random = new Random(); 
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//             arr[i]= random.Next(100,999);
//     }
// } 
//  void PrintArray( int[] arr)
// {
 
//     for(int i=0; i<arr.GetLength(0); i++)
    
//      {Console.Write(arr[i] + " ");
//      }   
       
// }
// int arrayCount = 7;
// int [] array = new int[arrayCount];
// int Count = 0;
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
//  for(int i=0; i < array.GetLength(0); i++)
//     {
//             if (array[i] % 2 == 0)
//             Count++;
//     }
// Console.WriteLine("количество четных чисел в представленном массиве " + Count);
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// //  [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

Console.WriteLine("Программа поиска суммы элементов, стоящих  на нечетных позициях в случайно заполненном массиве");
void FillArray( int[] arr)
{
   Random random = new Random(); 
    for(int i=0; i<arr.GetLength(0); i++)
    {
            arr[i]= random.Next(-100,999);
    }
} 
 void PrintArray( int[] arr)
{
 
    for(int i=0; i<arr.GetLength(0); i++)
    
     {Console.Write(arr[i] + " ");
     }   
       
}
int arrayCount = 7;
int [] array = new int[arrayCount];
int Sum = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
 for(int i=0; i < array.GetLength(0); i=i+2)
    {
      Sum = array[i] + Sum;
    }
Console.WriteLine("сумма элементов, стоящих на нечетных позициях " + Sum); //с точки зрения пользователя, когда первый элемент соответствует индексу i=0

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// // [3.3 7.76 22 2 78.67] -> 76.67
