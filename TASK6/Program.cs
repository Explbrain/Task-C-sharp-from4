// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Console.Write("Введите длинну массива M: ");
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
//  void Amount (int[] mass)
//     {
//     int count = 0;
//     for (int i = 0; i < mass.Length; i++)
// {
//     if (mass[i] > 0) count++;
//     }
// Console.WriteLine($"Количество положительных чисел равно {count}");
//     }
//     Amount(mass);

//     Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите начение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите начение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x,y;
x = (b2-b1)/(k1-k2);               //решила систему заданных уравнений
y = (k1*x) + b1;
Console.WriteLine($"Координаты точки пересечения двух линий: x = {x}, y = {y}");