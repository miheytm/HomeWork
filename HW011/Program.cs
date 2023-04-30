
int GetIntNum(string mes)
{
Console.Write($"{mes}: ");
int result = int.Parse(Console.ReadLine());
return result;
}

bool CheckValid(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Показатель должут быть положительным");
        return false;
    }
    return true;
}

int NumInNum(int num1, int num2)
{
    int count = 1;
    int result = 1;
    while (count <= num2)
    {
        result = num1*result;
        count++;        
    }
    return result;

}

Console.Clear();
int number1 = GetIntNum("Ввежите возводимое число");
int number2 = GetIntNum("Ввежите степень числа");
if (CheckValid(number2))
{
    Console.WriteLine($"{number1} в степени {number2} равно {NumInNum(number1,number2)}");
}
