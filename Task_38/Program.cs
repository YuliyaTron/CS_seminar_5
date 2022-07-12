// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndInt(int size)
{
    double[] array = new double[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(-100, 100);
        index++;
    }
    return array;
}

double[] RaznicaMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    double raznica = max - min;
    return new[] { raznica };
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

double[] array = CreateArrayRndInt(size);
PrintArray(array);
double[] raznicaMaxMin = RaznicaMaxMin(array);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива  = {raznicaMaxMin[0]}");


