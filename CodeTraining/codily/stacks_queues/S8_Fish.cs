using Xunit;
using System.Linq;
using System.Collections;

class S8_Fish
{
    public static int result_v2(int[] A, int[] B)
    {
        var upstream = new Stack<int>();
        var survivors = 0;

        for (var i = 0; i < A.Length; i++)
        {
            var is_upstream = B[i] == 1;

            if (is_upstream)
            {
                upstream.Push(i);
                continue;
            }

            if (upstream.Count == 0)
            {
                survivors++;
                continue;
            }

            var d_size = A[i];
            while (upstream.Count > 0)
            {
                var u = upstream.Pop();
                var u_size = A[u];
                if (u_size > d_size)
                {
                    upstream.Push(u);
                    break;
                }
                else survivors++;
            }
        }

        return upstream.Count + survivors;
    }

    public static int result(int[] A, int[] B)
    {
        var downstream = new Stack<int>();
        var upstream = new Stack<int>();

        var n = A.Length;

        for (var i = 0; i < n; i++)
        {
            var is_downstream = B[i] == 0;

            if (is_downstream) downstream.Push(i);
            else upstream.Push(i);

            while (is_downstream && upstream.Count > 0 && downstream.Count > 0)
            {
                var d = downstream.Pop();
                var u = upstream.Pop();
                var d_size = A[d];
                var u_size = A[u];
                if (d_size > u_size)
                {
                    downstream.Push(d);
                }
                else
                {
                    upstream.Push(u);
                    break;
                }
            }
        }

        return upstream.Count + downstream.Count;
    }



    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S8_Fish");
        Console.WriteLine("########################################");

        var A = new int[] { 4, 3, 2, 1, 5 };
        var B = new int[] { 0, 1, 0, 0, 0 };
        var res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(2, res);

        A = new int[] { };
        B = new int[] { };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(0, res);

        A = new int[] { 4 };
        B = new int[] { 0 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(1, res);

        A = new int[] { 4 };
        B = new int[] { 1 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(1, res);

        A = new int[] { 4, 3 };
        B = new int[] { 0, 0 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(2, res);

        A = new int[] { 4, 3 };
        B = new int[] { 1, 1 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(2, res);

        A = new int[] { 4, 3 };
        B = new int[] { 0, 1 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(2, res);

        A = new int[] { 4, 3 };
        B = new int[] { 1, 0 };
        res = result(A, B);
        Console.WriteLine(res);
        Assert.Equal(1, res);
    }

}