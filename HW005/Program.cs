Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int x = (number / 10) % 10;
Console.WriteLine($"Результат: {x}");
string s = number.ToString();
Console.WriteLine($"Результат через строку: {s[1]}");
