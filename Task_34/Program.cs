// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами . 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(100, 1000);
        index++;
    }
    return array;
}

int[] GetCountEvenElem(int[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) count++;
    return new[] { count };
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
int[] getCountEvenElem = GetCountEvenElem(array);

Console.WriteLine();
Console.WriteLine($"количество чётных чисел в массиве = {getCountEvenElem[0]}");



