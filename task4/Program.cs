// Console.WriteLine("Ввеите первое число");
// int x1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввеите второе число");
// int x2= Convert.ToInt32(Console.ReadLine());
// // int sum=x1+x2;
// // Console.WriteLine(sum);

// void SumNumbers(int x1,int x2)
// {

//    int sum=x1+x2; 
//    Console.WriteLine(sum);
// }
// SumNumbers(x1,x2);

// int [] array = {8,6,3,2,4,7,8,9};
// for (int i=0;i<array.Length;i++)
// {
//    Console.WriteLine(array[i]);
// }

int[] array = new int[10];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
FillArray(array);
void SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = array[i] + sum;
    }
    Console.WriteLine(sum);
}
SumArray(array);
