using Xunit;
using System.Linq;
using System.Collections;

class S9_Leader
{
    public static int result(int[] A)
    {
        var dict = new Dictionary<int, int>();
        var max_count = 0;
        var leader = 0;

        for(var i = 0; i < A.Length; i++)
        {
            var v = A[i];
            if (!dict.ContainsKey(v))
                dict.Add(v, 0);

            dict[v]++;
            if(dict[v] > max_count)
            {
                max_count = dict[v];
                leader = i;
            }
            
        }
        return  (max_count > A.Length / 2) ? leader : -1;
    }



    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S9_Leader");
        Console.WriteLine("########################################");

        var A = new int[] { 3, 4, 3, 2, 3, -2, 3, 3 };
        var res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.True(new int[] { 0, 2, 4, 6, 7 }.Contains(res));

        A = new int[] { 3, 4, 3, 2, 3, -2, 4 };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(-1, res);

        A = new int[] { };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(-1, res);

        A = new int[] { 1 };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1, 2 };
        res = result(A);
        Console.WriteLine(String.Join(",", A) + "  ->  " + res);
        Assert.Equal(-1, res);

    }

}