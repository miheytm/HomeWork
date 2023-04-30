Console.Clear();
Console.Write("Введите координаты Ax: ");
double Ax = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Ay: ");
double Ay = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Az: ");
double Az = double.Parse(Console.ReadLine());

Console.Write("Введите координаты Bx: ");
double Bx = double.Parse(Console.ReadLine());
Console.Write("Введите координаты By: ");
double By = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Bz: ");
double Bz = double.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2)),2);

Console.WriteLine(result);

