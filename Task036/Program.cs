// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int l, int min, int max)
{
    int[] array = new int[l];
    Random rnd  = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    } 
    return array;
}
void PrintArray(int[] arr)
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
int SumDigEvenPos(int [] arr)
{
    int sum = arr[1];
    for (int i = 3; i < (arr.Length); i+=2)
    {
        sum = sum + arr[i];
    }    
    return sum;
}


Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
int b = Convert.ToInt32(Console.ReadLine())+1;
int [] myArray = FillArray(length, a, b);
PrintArray(myArray);
Console.WriteLine(" ");
int s = SumDigEvenPos(myArray);
Console.WriteLine($"Сумма всех элементао, стоящиих на четных позициях в массиве {s}");