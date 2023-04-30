void RandArray(int[] arN, int size)
{
    int length = arN.Length;
    int index = 0;
    while (index < length)
    {
        arN[index] = new Random().Next(1, size);
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

int Sum3Array(int[] col)
{
    int count = col.Length;
    int pos = 0;
    int result = 0;
    while (pos < count)
    {
        if (pos % 2 != 0) 
        {
            result = result + col[pos];
        }
        pos++;
    }
    return result;
}

Console.Clear();
int n = GetIntNum("Введите количество элементов массива");
int[] array = new int[n];

RandArray(array, 99);
PrintArray(array);
int m = Sum3Array(array);
Console.WriteLine($"Сумма нечетных элементов = {m}");