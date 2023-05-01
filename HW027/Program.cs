using System;
using static System.Console;

int GetIntNum(string mes)
{
    Write($"{mes}: ");
    int result = int.Parse(ReadLine());
    return result;
}

string PrNum(int start, int end)
{
    if (start == end) return start.ToString();
    return(start + " "+PrNum(start+1, end));
}

Clear();
int n = GetIntNum("Введите N: ");
int m = GetIntNum("Введите M: ");
WriteLine(PrNum(n, m));