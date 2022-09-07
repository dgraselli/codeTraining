using Xunit;

class PerfectNumbers
{

    public static bool result(int a, int b)
    {
        return getDivisors(a).Sum() == b && getDivisors(b).Sum() == a;

    }

    public static List<int> getDivisors(int n)
    {
        var ret = new List<int>();
        var nro = n;

        for (var i = 1; i < n; i++)
        {
            if(nro % i == 0)
            {
                ret.Add(i);
            }
        }
        return ret;
    }

    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### PerfectNumbers");
        Console.WriteLine("########################################");

        var n1 = 220;
        var n2 = 284;
        Console.WriteLine($"{n1},{n2}: {result(n1, n2)}");
        Assert.True(result(n1, n2));

        n1 = 123;
        n2 = 234;
        Console.WriteLine($"{n1},{n2}: {result(n1, n2)}");
        Assert.False(result(n1, n2));
    }

}