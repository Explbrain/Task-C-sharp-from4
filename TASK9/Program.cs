// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write ("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
// if (n==0) return " ";
// return Convert.ToString(n) + " " + SumRec(n-1);

// }

// Console.WriteLine($" {SumRec(n)} ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Write("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int n, int m, int sum)
// {
//     if (m > n)
//     {
//         return sum;
//     }

//     sum = sum + (m++);
//     return SumRec(n, m, sum);
// }

// Console.WriteLine($" {SumRec(n, m, 0)} ");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}
   
Console.WriteLine($"Результат вычисления функции Аккермана {Akkerman(m, n)} ");

