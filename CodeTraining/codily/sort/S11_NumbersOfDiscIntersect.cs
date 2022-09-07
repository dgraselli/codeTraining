using Xunit;
using System.Linq;
using System.Collections;


class S11_NumbersOfDiscIntersect
{
    public static int compare_disc (Tuple<int, int> a, Tuple<int, int> b)
    {
        if (a.Item1 == b.Item1) return a.Item2 - b.Item2;
        else return a.Item1 - b.Item1;
    }

    public static int result(int[] A)
    {
        var start_end_arr = new Tuple<int, int>[A.Length * 2];
        for( var i = 0; i < A.Length; i++ )
        {
            start_end_arr[i] = new Tuple<int, int>(i - A[i], 1);
            start_end_arr[i+A.Length] = new Tuple<int, int>(i + A[i], -1);
        }
        Array.Sort(start_end_arr, compare_disc);
        Console.WriteLine( start_end_arr);

        return 1;
        var cant_inter = 0;
        var active_inter = 0;
        foreach(var (ini, start_end) in start_end_arr )
        {
            cant_inter += start_end;
            if(start_end > 0) active_inter +
        }

    }



    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S11_NumbersOfDiscIntersect");
        Console.WriteLine("########################################");

        var A = new int[] { 1,5,2,1,4,0 };
        var res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(11, res);


    }

}