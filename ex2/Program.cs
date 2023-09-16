//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


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

int GetSum(int[] arr)
{
   int sumnum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumnum += arr[i];
    }
    return sumnum;
}
 int[] arr = GetArray(12, -20, 20);
Print(arr);

System.Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {GetSum(arr)}");
