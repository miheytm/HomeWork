void InputArray(int[] arN)
{
    int length = arN.Length;
    int index = 0;
    while (index < length)
    {
        arN[index] = GetIntNum($"Введите {index + 1}-й элемент: ");
        index++;
        Console.WriteLine();
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

int PlusIntArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    int result = 0;
    while (pos < count)
    {
        if (col[pos] > 0) result++;
        pos++;
    }
    return result;
}

Console.Clear();
int n = GetIntNum("Введите количество элементов массива");
int[] array = new int[n];
InputArray(array);
int sum = PlusIntArray(array);
Console.WriteLine($"В массиве {sum} положительный(х) элемент(а)");