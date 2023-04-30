string GetStrNum(string mes)
{
    Console.Write($"{mes}: ");
    string result = Console.ReadLine();
    return result;
}
int SumNums(string num)
{
    int count = 0;
    int result = 0;
    int intValue = 0;
    while (count < num.Length)
    {
        intValue = 0;
        if (int.TryParse(num[count].ToString(), out intValue))
        {
            result = result + intValue;
        }
        else
        {
            return -1;
        }
        count++;

    }
    return result;

}
Console.Clear();
string s = GetStrNum("Введите число");
int sum = SumNums(s);
if (sum < 0) Console.WriteLine("Некоректный ввод");
else Console.WriteLine($"Сумма цифр числа {s} равна {sum}");
