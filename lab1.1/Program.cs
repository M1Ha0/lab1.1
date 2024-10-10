try
{
    Console.WriteLine("Введите a");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите z");
    double z = double.Parse(Console.ReadLine());
    double c = Math.Pow(Math.Cos(b * Math.Pow(x, 5)), 7) - (Math.Sin(a * a) + Math.Cos(Math.Pow(x, 3) + Math.Pow(z, 5) - Math.Pow(a, 2)));
    double v = Math.Asin(Math.Pow(a, 2)) + Math.Acos(Math.Pow(x, 7) - Math.Pow(a, 2));
    Console.WriteLine($"f={c / v}");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}