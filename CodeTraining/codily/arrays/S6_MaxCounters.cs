using Xunit;
using System.Linq;

class S6_MaxCounter
{
    public static int[] result(int N, int[] A)
    {
        var counters = new int[N];
        var max = 0;
        var current_max = 0;

        foreach (var i in A)
        {
            if (i == N + 1)
                max = current_max;
            else
            {
                counters[i - 1] = Math.Max(counters[i - 1], max) + 1;
                if (counters[i - 1] > current_max)
                    current_max = counters[i - 1];
            }
        }

        return counters.Select(x => Math.Max(x,max)).ToArray();
    }

    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S6_MaxCounter");
        Console.WriteLine("########################################");

        var X = 5;
        var A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
        var res = result(X, A);
        Console.WriteLine(A.ToString() + ": " + res);
        Assert.Equal(new int[] { 3, 2, 2, 4, 2 }, res);
    }

}