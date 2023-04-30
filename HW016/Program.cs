void RandDoubleArray(double[] arN, int size)
{
    int length = arN.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        arN[index] = Math.Round(random.Next(-size, size + 1)*0.1, 10);;
        index++;
    }
}

int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintDoubleArray(double [] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"   {col[pos]}");
        pos++;
    }
    Console.WriteLine();
}

double MaxDArray(double[] col)
{
    int count = col.Length;
    int pos = 0;
    double result = 0;
    while (pos < count)
    {
        if (result < col[pos]) 
        {
            result = col[pos];
        }
        pos++;
    }
    return result;
}

double MinDArray(double[] col)
{
    int count = col.Length;
    int pos = 0;
    double result = 0;
    while (pos < count)
    {
        if (result > col[pos]) 
        {
            result = col[pos];
        }
        pos++;
    }
    return result;
}

Console.Clear();
int n = GetIntNum("Введите количество элементов массива");
double[] array = new double[n];

RandDoubleArray(array, 100);
PrintDoubleArray(array);
double max = MaxDArray(array);
double min = MinDArray(array);
double m = max - min;
Console.WriteLine($"Разность мин и мах элементов = {m}");