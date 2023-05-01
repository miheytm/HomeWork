void RandintArrayNMK(int[,,] arNM, int size)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);
    int lenk = arNM.GetLength(1);

    Random random = new Random();
    for (int i = 0; i < leni; i++)
        for (int j = 0; j < lenj; j++)
            for (int k = 0; k < lenk; k++)
                {
                arNM[i, j, k] = random.Next(10, size);
                Console.Write($"{arNM[i, j, k]}({i}, {j}, {k}) ");
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
int k = GetIntNum("Введите k");

int [,,] arr = new int[n,m,k];
RandintArrayNMK(arr, 100);


Console.WriteLine();