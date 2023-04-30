Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while(count <= n)
{
    Console.Write($"{Math.Pow(count,3)} ");
    count++;
}
Console.WriteLine();