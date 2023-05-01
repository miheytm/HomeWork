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

int FaindArrayNM(int[,] arNM, int n, int m)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);
    if (n >= leni || m >= lenj) return -1;
    else return arNM[n, m];
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
int eli = GetIntNum("Введите номер строки: ");
int elj = GetIntNum("Введите номер столбца: ");
if (FaindArrayNM(arr, eli - 1, elj - 1) == -1) Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"Элемент найден: {FaindArrayNM(arr, eli - 1, elj - 1)}");