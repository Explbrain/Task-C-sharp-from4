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

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

Console.Write("Введите длинну массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] EnterDislay()
{
int[] mass = new int[N];
int i;
Console.WriteLine("Введите числа:");
for (i=0; i<mass.Length;i++) mass[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введенные числа:");
for (i=0; i<mass.Length;i++) Console.Write("{0} ", mass[i]);
return mass;
}
int [] mass=EnterDislay();
