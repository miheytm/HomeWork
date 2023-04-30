Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
try
{
     Console.WriteLine($"Третья цифра: {s[2]}");
}
catch
{
     Console.WriteLine("Третьей цифры нет");
}
finally
{
     
}