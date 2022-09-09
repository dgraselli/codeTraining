using Xunit;
using System.Linq;
using System.Collections;


class S14_Flags
{

    public static int result(int[] A)
    {
        var n = A.Length;

        if (n < 3) 
            return 0;

        var max_k = (int) Math.Sqrt(n) + 1;
        var next_peak_arr = getNextPeakArr(A);
        
        var k = max_k;
        while (!fitFlags(k, next_peak_arr))
            k--;

        //var from = 0;
        //var to = max_k;
        //var k = (int) ((to - from) / 2);
        //while(true)
        //{
        //    if (fitFlags(k, next_peak_arr))
        //        from = k;
        //    else
        //        to = k - 1;

        //    if (from >= to)
        //        break;

        //    k = (int)Math.Ceiling((double)(from + to) / 2);
        //}

        return k;
    }

    private static bool fitFlags(int k, int[] arr)
    {
        if (k == 0) return true;
        var cant = 0;
        var next_peak_index = arr[0];
        while(next_peak_index < arr.Length)
        {
            cant++;
            if (cant == k) 
                return true;
            if (next_peak_index + k >= arr.Length)
                return false;
            next_peak_index = arr[next_peak_index + k];
        }
        return false;
    }
    private static int[] getNextPeakArr(int[] A)
    {
        var n = A.Length;
        var res = new int[n];
        var last_peak_index = n;
        res[n - 1] = last_peak_index;

        for (var i = A.Length - 2; i >= 1; i--)
        {
            if (A[i] > A[i - 1] && A[i] > A[i + 1])
                last_peak_index = i;

            res[i] = last_peak_index;
        }
        res[0] = res[1];

        return res;
    }

    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S14_Flags");
        Console.WriteLine("########################################");

        var a = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
        var res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(3, res);

        a = new int[] { };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);
        a = new int[] { 1 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);
        a = new int[] { 1, 2 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);

        a = new int[] { 1, 2, 3 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);

        a = new int[] { 3, 2, 1 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);

        a = new int[] { 3, 2, 3 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(0, res);

        a = new int[] { 1, 2, 1 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(1, res);

        a = new int[] { 1, 2, 1, 4, 1 };
        res = result(a);
        Console.WriteLine($"{string.Join(",", a)} -> {res}");
        Assert.Equal(2, res);

    }

}