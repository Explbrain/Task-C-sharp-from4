// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateFillArray()
// {
// int [] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
//     return array;
// }
//     void Amount (int[] array)
//     {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) count++;
//     }
// Console.WriteLine($"Количество четных чисел равно {count}");
//     }
//     int [] array = CreateFillArray();
//     Amount(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[10];
void Sum (int [] array)
{
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(array[i] + " ");
    }
    int sumindex = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (i % 2 < 0 || i % 2 > 0) sumindex+=array[i];
    }
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumindex}");
}
Sum (array);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// double [] array = new double[10];
// for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//         Console.Write(array[i] + " ");
//     }
//     double min = array [0];
//     double max = array [0];
    
//     for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] < min) min = array[i];

//     }
// for (int i = 1; i < array.Length; i++)
// {
//      if (array[i] > max) max = array[i];
// }
// double dif = max-min;
                
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {dif}");
