using System;
using static System.Console;

int GetIntNum(string mes)
{
    Write($"{mes}: ");
    int result = int.Parse(ReadLine());
    return result;
}

int PrSumNum(int start, int end)
{
    if (start == end) return start;
    return(start + PrSumNum(start+1, end));
}

Clear();
int n = GetIntNum("Введите N: ");
int m = GetIntNum("Введите M: ");
WriteLine(PrSumNum(n, m));