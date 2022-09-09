using Xunit;
using System.Linq;
using System.Collections;


class S12_PassingCars
{

    public static int result(int[] A)
    {
        return result_codility_suffix(A);
        //return result_codility_diego(A);
    }
    public static int result_diego(int[] A)
    {
        var total_pass = 0;
        var east_count = 0;
        var west_count = 0;

        for (var i = 0; i < A.Length; i++)
        {
            var is_west = A[i] == 1;

            if (is_west) west_count++;
            else east_count++;

            if (is_west)
                total_pass += east_count;

            if (total_pass > 1_000_000_000) return -1;
        }
        return total_pass;
    }

    public static int result_codility_suffix(int[] A)
    {
        var count = 0;
        var suffix = new int[A.Length + 1];
        for (var i = A.Length - 1; i >= 0; i--)
        {
            suffix[i] = A[i] + suffix[i + 1];
            if (A[i] == 0) count += suffix[i];
            if (count > 1_000_000_000) return -1;
        }

        return count;
    }




    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S12_PassingCars");
        Console.WriteLine("########################################");

        var A = new int[] { };
        var res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 1, 0 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(0, res);

        A = new int[] { 0, 1 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(1, res);

        A = new int[] { 0, 1, 1 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(2, res);

        A = new int[] { 0, 1, 0 ,1, 1 };
        res = result(A);
        Console.WriteLine(string.Join(",", A) + "  ->  " + res);
        Assert.Equal(5, res);



    }

}