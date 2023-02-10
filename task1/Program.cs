

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CountEvenNumber(int[] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
   }

int[] newArray = GetRandomArray(10, 100, 999);
PrintArray(newArray); 
int answer = CountEvenNumber(newArray);
 Console.WriteLine($"Количество четных чисел в данном массие: {answer}");