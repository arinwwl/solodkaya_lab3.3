try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double s = 1;
    for (int i = 1; i <= n; i++)
    {
        long f = 1;
        for (int j = 1; j <= i; j++) f *= j;
        if (i % 2 == 0)
        {
            s += Math.Cos(x) / f;
        }
        else
        {
            s -= Math.Cos(i * x) / f;
        }

    }
    Console.WriteLine($"S={s:F2}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

