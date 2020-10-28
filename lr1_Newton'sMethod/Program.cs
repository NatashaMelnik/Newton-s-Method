using System;

public class Program
{
    public static void Main()
    {
        double num;
        for (double i = -10; i <= 10;)
        {
            num = i + 0.01;
            if (((func(i) > 0) && (func(num) < 0)) || ((func(i) < 0) &&
            (func(num) > 0)))
            {
                Console.WriteLine(find(i, 0.01));
            }
            i += 0.01;
        }
        Console.ReadKey();
    }
    static double find(double x, double eps)
    {
        double f, df; int iter = 0;
        Console.WriteLine("x0 = {0}", x);
        do
        {
            f = func(x);
            df = 1 - 3 / Math.Pow(x, 3);
            x = x - f / df;
            iter++;
        } while (Math.Abs(f) > eps);
        Console.WriteLine("iter = {0}", iter);
        return x;
    }
    static double func(double x)
    {
        double f;
        f = (Math.Pow(x, 4) - 1) - Math.Pow(x, 3);
        return f;
    }
}
