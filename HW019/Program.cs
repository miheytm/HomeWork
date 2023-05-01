void RandDoubleArrayNM(double[,] arNM, int size)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);

    Random random = new Random();
    for (int i = 0; i < leni; i++)
        {
        for (int j = 0; j < lenj; j++)
            {
            arNM[i, j] = Math.Round(random.Next(-size, size + 1)*0.01, 10);
            Console.Write("{0}\t", arNM[i, j]);
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
int n = GetIntNum("Введите n: ");
int m = GetIntNum("Введите m: ");
double [,] arr = new double[n,m];
RandDoubleArrayNM(arr,1000);