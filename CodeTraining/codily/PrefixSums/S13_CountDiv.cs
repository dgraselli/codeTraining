using Xunit;
using System.Linq;
using System.Collections;


class S13_CountDiv
{

    public static int result(int A, int B, int K)
    {
        var a = Math.Ceiling(A / (double)K);
        var b = Math.Floor(B / (double)K);

        return (int)(b - a + 1);
    }

    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S13_CountDiv");
        Console.WriteLine("########################################");

        var a = 0;
        var b = 0;
        var k = 11;
        var res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(1, res);

        a = 1;
        b = 1;
        k = 11;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(0, res);

        a = 0;
        b = 0;
        k = 11;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(1, res);

        a = 0;
        b = 1;
        k = 11;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(1, res);

        a = 0;
        b = 9;
        k = 3;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(4, res);

        a = 3;
        b = 9;
        k = 3;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(3, res);

        a = 6;
        b = 11;
        k = 2;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(3, res);

        a = 6;
        b = 12;
        k = 2;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(4, res);

        a = 7;
        b = 12;
        k = 2;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        Assert.Equal(3, res);

        a = 101;
        b = 123_000;
        k = 10_000;
        res = result(a, b, k);
        Console.WriteLine($"{a},{b},{k} -> {res}");
        //Assert.Equal(12345, res);

    }

}