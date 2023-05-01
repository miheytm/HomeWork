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

int [,] PrArrayNM(int[,] arNM1, int[,] arNM2)
{
    int leni = arNM1.GetLength(0);
    int lenj = arNM1.GetLength(1);
    int [,] arrRez = new int[leni,leni];
   
    for (int i = 0; i < leni; i++)
        {
        for (int j = 0; j < lenj; j++)
            {
            arrRez[i, j] = arNM1[i, j] * arNM2[i, j];
            Console.Write("{0}\t", arrRez[i, j]);
            }
        Console.WriteLine();
        }
    return arrRez;
}



int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

Console.Clear();
int n = GetIntNum("Введите n");

int [,] arr1 = new int[n,n];
RandintArrayNM(arr1,10);
Console.WriteLine();

int [,] arr2 = new int[n,n];
RandintArrayNM(arr2,10);
Console.WriteLine("Произведение массивов: ");

int [,] arr = new int[n,n];

arr = PrArrayNM(arr1, arr2);

Console.WriteLine();