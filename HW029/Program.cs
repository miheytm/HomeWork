using System;
using static System.Console;

int GetIntNum(string mes)
{
    Write($"{mes}: ");
    int result = int.Parse(ReadLine());
    return result;
}

int ack(int n, int m)
{
    while (n != 0) 
    {
        if (m == 0) m = 1;
        else m = ack(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

Clear();
int n = GetIntNum("Введите N: ");
int m = GetIntNum("Введите M: ");
WriteLine(ack(n, m));