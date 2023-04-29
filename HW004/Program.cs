Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int coint = 1;
if (n <= 1) Console.WriteLine("Вы ввели число меньше или равное единице ");
else
while (coint <= n)
{
    if (coint % 2 == 0) Console.WriteLine(coint);
    coint++;
}