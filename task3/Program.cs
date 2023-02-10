double[] GetRandomArray()
{
    double[] array = new double[10];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] FindMaxMin(double[] array)
{
    double[] result = new double[2];
    result[0] = 0; // maximum
    result[1] = array[0]; // minimum
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > result[0])
        {
            result[0] = array[i];
        }
        if (array[i] < result[1])
        {
            result[1] = array[i];
        }
    }
    return result;
}

double[] newArray = GetRandomArray();
PrintArray(newArray);
double[] maxMin = FindMaxMin(newArray);

Console.WriteLine($"Mаксимальное значение - {maxMin[0]}, минимальное значение: {maxMin[1]}");
Console.WriteLine($"Разница между максимальным и минимальным значение: {maxMin[0] - maxMin[1]}");
