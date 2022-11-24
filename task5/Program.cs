

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//  int a = int.Parse(Console.ReadLine());
//  void SumNumbers(int a)
//  {
//             int s = 0;
//             while (a > 0)
//             {
 
//                 s = s + a % 10;
//                 a = a /10 ;
 
//             }
//  Console.WriteLine(s);
//  }
// SumNumbers(a);



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Write("Введите число, которое хотите возвести в степень: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число равное степени: ");
// int b = Convert.ToInt32(Console.ReadLine());

// void Degree(int a, int b)
// {
//     int c = 1;
//     for (int i = 0; i < b; i++) c *= a;
//    // Console.WriteLine("Число {0} в степени {1} равно {2}", a, b, c);
//    Console.WriteLine($"Число {a} в степени {b} равно {c}");
// }
// Degree(a,b);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

// Console.Write("Введите длинну массива N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] EnterDislay()
// {
// int[] mass = new int[N];
// int i;
// Console.WriteLine("Введите числа:");
// for (i=0; i<mass.Length;i++) mass[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введенные числа:");
// for (i=0; i<mass.Length;i++) Console.Write("{0} ", mass[i]);
// return mass;
// }
// int [] mass=EnterDislay();


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите размер двумерного массыва: ");
Console.WriteLine();
int m=Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int[,] massiv=new int[m,n];
Napolnenie(massiv);
Print(massiv);
Console.WriteLine();
Console.WriteLine();
Srednee(massiv);

void Print (int[,] massiv)
{
    for (int i=0; i<massiv.GetLength(0);i++)
    {
        Console.WriteLine();
        for (int j=0;j<massiv.GetLength(1);j++)
        {
            Console.Write(" "+massiv[i,j]);
        }
    }
}

void Napolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void Srednee(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum=sum+array[i,j];
        }
    sum=sum/array.GetLength(0);
    Console.Write(" "+sum);
    }
}