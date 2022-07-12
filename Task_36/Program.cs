// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(-100, 100);
        index++;
    }
    return array;
}

int[] SumElementNegIndex(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
        if (i % 2 != 0) sum = sum + arr[i];
    return new[] { sum };
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

int[] array = CreateArrayRndInt(size);
PrintArray(array);
int[] sumElementNegIndex = SumElementNegIndex(array);

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumElementNegIndex[0]}");
