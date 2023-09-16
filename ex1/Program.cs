//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int GetCount(int[] arr)
{
    int countN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countN++;
        }
    }
    return countN;
}

int[] arr = GetArray(8, 100, 999);
Print(arr);

System.Console.WriteLine($"Количество четных чисел в массиве: {GetCount(arr)}");

