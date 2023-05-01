int GetIntNum(string mes)
{
    Console.Write($"{mes}: ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

void GetXYLines(double c1, double a1, double c2, double a2, double b1, double b2)
{
if ((a1 * b2 - a2 * b1) == 0)
{
Console.WriteLine("Прямые параллельны другу друг (или совпадают) и не имеют точек пересечения");
}
else
{
double oX = -(c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
double oY = -(a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);

Console.WriteLine(oX); 
Console.WriteLine(oY);
}
}

Console.Clear();

double c1 = GetIntNum("Введите коэффициент b1");
double a1 = GetIntNum("Введите коэффициент k1");
double c2 = GetIntNum("Введите коэффициент b2");
double a2 = GetIntNum("Введите коэффициент k2");
double b1 = -1; //коофициент y1
double b2 = -1; //коофициент y2

GetXYLines(c1, a1, c2, a2, b1, b2);
