
void RandintArrayNM(int[,] arNM)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);
    int n = 0;
    int N = leni;
    int x0 = 0;
    int xn = N - 1;
    int y0 = 0;
    int yn = N - 1;
    
            while (n < N * N)
            {
                for (int x = x0; x <= xn; x++)
                {
                    arNM[y0, x] = ++n;
                }

                y0++;

                for (int y = y0; y <= yn; y++)
                {
                    arNM[y, xn] = ++n;
                }

                xn--;

                for (int x = xn; x >= x0; x--)
                {
                    arNM[yn, x] = ++n;
                }

                yn--;

                for (int y = yn; y >= y0; y--)
                {
                    arNM[y, x0] = ++n;
                }

                x0++;
            }
    }



void PrintArrayNM(int[,] arNM)
{
    int leni = arNM.GetLength(0);
    int lenj = arNM.GetLength(1);

    for (int i = 0; i < leni; i++)
        {
        for (int j = 0; j < lenj; j++)
            {
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
int n = GetIntNum("Введите n");

int [,] arr = new int[n,n];
RandintArrayNM(arr);   

Console.WriteLine($"Массив {n}x{n} заполненный по спирали: ");

PrintArrayNM(arr); 

Console.WriteLine();