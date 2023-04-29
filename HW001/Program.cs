Console.Clear();
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.Clear();
if (a > b) Console.WriteLine("a больше b");
if (a < b) Console.WriteLine("a меньше b");
if (a == b) Console.WriteLine("a равно b");