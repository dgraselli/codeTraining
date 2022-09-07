using Xunit;

class Trading
{

    /// <summary>
    /// Retorna la ganancia maxima posible 
    /// </summary>
    /// <param name="precios"> array de precios en dias consecutivos</param>
    /// <returns></returns>
    public static double result(double[] precios)
    {
        var diff = double.MinValue;
        var min = double.MaxValue;

        foreach(var p in precios)
        {
            if (p < min)
                min = p;

            if (p - min > diff)
                diff = p - min;
        }
        return diff;
    }

    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### Trading");
        Console.WriteLine("########################################");

        var precios = new double[] { 1.0, 12.1, 25.0, 2.1, 50, 12 };
        Console.WriteLine(precios + " => " + result(precios));
        Assert.Equal(49, result(precios));

        precios = new double[] { 1.0, 12.1, 25.0, 2.1, 50, 12, 0 };
        Console.WriteLine(precios + " => " + result(precios));
        Assert.Equal(49, result(precios));

        precios = new double[] { 1.0, 12.1, 25.0, 2.1, 50, 12, 0, 150,200,12 };
        Console.WriteLine(precios + " => " + result(precios));
        Assert.Equal(200, result(precios));
    }


}