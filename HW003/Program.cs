Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x == 0) 
{
    Console.Clear();
    Console.WriteLine("Число Ноль"); 
}
else
{
if (x % 2 == 0)
{
    Console.Clear();
    Console.WriteLine("Четное число"); 
} 
else
{
    Console.Clear();
    Console.WriteLine("Нечетное число");  

}
}