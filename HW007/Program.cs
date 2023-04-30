Console.Clear();
Console.Write("Введите номер дня недели : ");
int a = int.Parse(Console.ReadLine());

if (a > 7|| a < 1) Console.WriteLine("Неверный день недели");
else
{
if (a == 6|| a == 7) Console.WriteLine("Выходной");
else
Console.WriteLine("Рабочий день");
}