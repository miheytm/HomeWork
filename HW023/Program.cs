void RandintArrayNM(int[,] arNM, int size)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);

    Random random = new Random();
    for (int i = 0; i < leni; i++)
        {
        for (int j = 0; j < lenj; j++)
            {
            arNM[i, j] = random.Next(1, size + 1);
            Console.Write("{0}\t", arNM[i, j]);
            }
        Console.WriteLine();
        }

}

int StrMinArrayNM(int[,] arNM)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);
   
    int minSum = 0;
    int minS = 0;

    for (int j = 0; j < lenj; j++)
    minSum = minSum + arNM[0, j];

    for (int i = 0; i < leni; i++)
    {
        int sum = 0;
        for (int j = 0; j < lenj; j++)
            sum = sum + arNM[i, j];

        if (sum < minSum) 
        {
            minSum = sum;
            minS = i;
        }
   
    }
    return minS;
}



int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int n = GetIntNum("Введите n");

int [,] arr = new int[n,n];
RandintArrayNM(arr,100);
Console.WriteLine();

Console.WriteLine($"Строка с минимальной суммой под номером {StrMinArrayNM(arr) + 1}");

Console.WriteLine();