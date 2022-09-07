using Xunit;

class S4_TapeEquilibrium
{

    public static int result_v1(int[] A)
    {
        long n = A.LongLength;
        long total = A.Sum();
        long partial_sum = 0;

        long min = Math.Abs(total);

        for (var i = 0; i < n; i++)
        {
            partial_sum += A[i];
            if (Math.Abs(2 * partial_sum - total) < min)
            {
                min = Math.Abs(2 * partial_sum - total);

            }
        }
        return (int)min;
    }

    public static int result(int[] A)
    {
        long left = 0;
        long rigth = A.Sum();
        long min = Math.Abs(rigth);

        for (var i = 0; i < A.Length; i++)
        {
            left += A[i];
            rigth -= A[i];
            if (min > Math.Abs(left - rigth))
                min = Math.Abs(left - rigth);
        }
        return (int)min;
    }

    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S4_TapeEquilibrium");
        Console.WriteLine("########################################");

        var A = new int[] { 3, 1, 2, 4, 3 };
        Console.WriteLine(A.ToString() + ": " + result(A));
        Assert.Equal(1, result(A));

        A = new int[] { 3, 1, 2, 4, 3, 26 };
        Console.WriteLine(A.ToString() + ": " + result(A));
        Assert.Equal(13, result(A));

        A = new int[] { 2000, 1 };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(1999, result(A));

        A = new int[] { 1, 2000 };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(1999, result(A));

        A = new int[] { 1, -2000 };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(1999, result(A));

        A = new int[] { -1, 2000 };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(1999, result(A));

        A = new int[] { 1 };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(A[0], result(A));

        A = new int[] {  };
        Console.WriteLine(A.ToString() + ":" + result(A));
        Assert.Equal(0, result(A));

    }

}