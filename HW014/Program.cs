void RandArray(int[] arN, int size)
{
    int length = arN.Length;
    int index = 0;
    while (index < length)
    {
        arN[index] = new Random().Next(100, size);
        index++;
    }
}

int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($" {col[pos]}");
        pos++;
    }
    Console.WriteLine();
}

int Com2Array(int[] col)
{
    int count = col.Length;
    int pos = 0;
    int result = 0;
    while (pos < count)
    {
        if (col[pos] % 2 == 0) result++;
        pos++;
    }
    return result;
}

Console.Clear();
int n = GetIntNum("Введите количество элементов массива");
int[] array = new int[n];

RandArray(array, 999);
PrintArray(array);
int m = Com2Array(array);
Console.WriteLine($"Найдено {m} четных элементов");