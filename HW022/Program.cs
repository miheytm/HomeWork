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

void SortrArrayNM(int[,] arNM)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);
    int[] temp = new int[lenj];
    
    for (int i = 0; i < leni; i++)
    {
        for (int j = 0; j < lenj; j++)
            temp[j] = arNM[i, j];
            Array.Sort(temp);
                for (int k = 0; k < lenj; k++)
                {
                    arNM[i, k] = temp[k];
                    Console.Write("{0}\t", arNM[i, k]);
                }
        Console.WriteLine();
    }

}



int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int n = GetIntNum("Введите n");
int m = GetIntNum("Введите m");
int [,] arr = new int[n,m];
RandintArrayNM(arr,100);
Console.WriteLine();

Console.WriteLine("Отсортированный массив: ");
SortrArrayNM(arr);
Console.WriteLine();