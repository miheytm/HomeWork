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

void SrArrayNM(int[,] arNM)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);

    
    for (int j = 0; j < lenj; j++)
        {
        double sum = 0;    
        for (int i = 0; i < leni; i++)
            {
            sum = sum + arNM[i, j];
            }
        Console.Write("{0}\t", Math.Round(sum / (lenj - 1), 2));
        }

}



int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int n = GetIntNum("Введите n: ");
int m = GetIntNum("Введите m: ");
int [,] arr = new int[n,m];
RandintArrayNM(arr,100);
Console.WriteLine();
SrArrayNM(arr);
Console.WriteLine();
