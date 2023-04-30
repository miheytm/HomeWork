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

int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int n = GetIntNum("Введите количество элементов массива");
int m = GetIntNum("Введите диапазон значений массива от 1 до");
int[] array = new int[n];

RandArray(array, m);
PrintArray(array);