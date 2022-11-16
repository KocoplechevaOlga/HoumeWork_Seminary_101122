// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементами массива.

double [] FillArray(int l, double min, double max)
{
    double[] array = new double[l];
    Random rnd  = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max-min) + min;
        array[i] = Math.Round(array[i], 2);
    } 
    return array;
}
void PrintArray(double[] arr)
{
    int j = 0;
    Console.Write("[");
    for (j =0 ; j < (arr.Length-1); j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[j]);
    Console.Write("]");
}
double FindMax (double [] arr)
{
    double nmax = arr[0];
    for (int i =0 ; i< (arr.Length); i++)
    {
        if (arr[i] > nmax) nmax = arr[i];
    }
     return nmax;
}
double FindMin (double [] arr)
{
    double nmin = arr[0];
    for (int i =0 ; i< (arr.Length); i++)
    {
        if (arr[i] < nmin) nmin = arr[i];
    }
     return nmin;
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
double b = Convert.ToInt32(Console.ReadLine())+1;
double [] myArray = FillArray(length, a, b);
PrintArray(myArray);
Console.WriteLine(" ");

double sbt = Math.Round(FindMax(myArray) - FindMin(myArray), 2);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива составляет {sbt}");
