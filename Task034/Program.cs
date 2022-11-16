// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int l)
{
    int[] array = new int[l];
    Random rnd  = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    } 
    return array;
}
void PrintArray(int[] arr)
{
    int j = 0;
    Console.Write("[");
    for (j = 0; j < (arr.Length-1); j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[j]);
    Console.Write("]");
}
int CountPlusDig(int [] arr)
{
    int count = 0;
    for (int i = 0; i < (arr.Length); i++)
    {
        if (arr[i] % 2 == 0) 
        {
            count ++;
        }
    }    
    return count;
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int [] myArray = FillArray(length);
PrintArray(myArray);
Console.WriteLine(" ");
int res = CountPlusDig(myArray);
Console.WriteLine($"В заданом массиве содержиться {res} четных чисел");
