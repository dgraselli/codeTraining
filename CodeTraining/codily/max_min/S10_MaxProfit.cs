using Xunit;
using System.Linq;
using System.Collections;

class S10_MaxProfit
{
    public static int result(int[] A)
    {
        var diff = 0;
        var min = int.MaxValue;

        foreach (var p in A)
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
        Console.WriteLine("### S10_MaxProfit");
        Console.WriteLine("########################################");

        var A = new int[] { 3, 4, 3, 2, 3, -2, 4 };
        var res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(6, res);

        A = new int[] { };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1 };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1, 2 };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(1, res);

    }

}