using Xunit;
using System.Linq;
using System.Collections;


class S11_NumbersOfDiscIntersect
{
    public static int compare_disc (Tuple<long, int> a, Tuple<long, int> b)
    {
        if (a.Item1 == b.Item1) return b.Item2 - a.Item2;
        else return (a.Item1 > b.Item1)? 1 : -1;
    }
    
    public static int result(int[] A)
    {
        var start_end_arr = new Tuple<long, int>[A.Length * 2];
        for (long i = 0; i < A.Length; i++)
        {
            start_end_arr[i] = new Tuple<long, int>(i - A[i], 1);
            start_end_arr[i + A.Length] = new Tuple<long, int>(i + A[i], -1);
        }
        Array.Sort(start_end_arr, compare_disc);

        var cant_inter = 0;
        var active_inter = 0;
        foreach (var t in start_end_arr)
        {
            var start_end = t.Item2;
            active_inter += start_end;
            if (start_end > 0) cant_inter += active_inter - 1;
            if (cant_inter > 10000000) return -1;
        }
        return cant_inter;
    }



    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S11_NumbersOfDiscIntersect");
        Console.WriteLine("########################################");

        var A = new int[] { 1, 5, 2, 1, 4, 0 };
        var res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(11, res);

        A = new int[] { };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        //A = new int[] { 1, 0, 0, 1 };
        //res = result(A);
        //Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        //Assert.Equal(0, res);

        A = new int[] { 1, 2 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(1, res);

        A = new int[] { 1, int.MaxValue };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(1, res);

        A = new int[] { int.MaxValue, int.MaxValue };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(1, res);


    }

}