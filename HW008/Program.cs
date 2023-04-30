Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
int count = 0;
bool flag = true;
while (count < s.Length / 2)
{
    if (s[count] !=s[s.Length -1 - count])
    {
        flag = false;
        break;
    }
count++;
}
if (flag == true) Console.WriteLine("Палиндром");
else
Console.WriteLine("Не палиндром");