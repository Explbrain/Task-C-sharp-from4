// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. // 0,5 7 -2 -0,2 // 1 -3,3 8 -9,9 // 8 7,8 -7,1 9
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] FillArray(int m, int n)
// {
//     double [,] array = new double[m,n];
//     var Random = new Random();
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= Random.NextDouble()*40-20;
//     }
//     return array;
// }

// void PrintArray(double[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] array=FillArray(m,n);
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(1,10);
//     }
//     return array;
// }
// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите число от 1 до 10");
// int el = Convert.ToInt32(Console.ReadLine());
// void Element (int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image [i,j] == el) 
//             Console.WriteLine($"Позиция введенного числа {i},{j}");
//             else Console.Write($"Такого элемента нет");
//         }
//     }
// }

// int[,] image=FillArray(m,n);
// PrintArray(image);
// Element(image);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(1,10);
    }
    return array;
}
void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} \t");
            }
        Console.WriteLine();
    }
}
double sum=0;
double av=0;
void Average(int[,] image)
{
    for (int j = 0; j < image.GetLength(1); j++)
    {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            sum=sum + image [i,j]; 
        }
        av= sum/image.GetLength(0);
        Console.WriteLine(av);
    }
}

int[,] image=FillArray(m,n);
PrintArray(image);
Average(image);