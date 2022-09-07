using Xunit;

class S5_FrogRiver
{
    public static int result(int X, int[] A)
    {
        var total = X;
        var positions = new bool[X];
        for (int i = 0; i < A.Length; i++)
        {
            var pos = A[i] -1;
            if(!positions[pos])
            {
                positions[pos] = true;
                total--;
                if (total == 0) 
                    return i;
            }
        }

        return -1;
    }

    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S5_FrogRiver");
        Console.WriteLine("########################################");

        var X = 5;
        var A = new int[] { 3, 1, 2, 4, 3, 5, 3, 2, 1 };
        Console.WriteLine(A.ToString() + ": " + result(X, A));
        Assert.Equal(5, result(X, A));

        X = 6;
        A = new int[] { 3, 1, 2, 4, 3, 5, 3, 2, 1, 6 };
        Console.WriteLine(A.ToString() + ": " + result(X, A));
        Assert.Equal(9, result(X, A));

        X = 6;
        A = new int[] { 3, 1, 2, 4, 3, 5, 3, 2, 1 };
        Console.WriteLine(A.ToString() + ": " + result(X, A));
        Assert.Equal(-1, result(X, A));

        X = 6;
        A = new int[] { };
        Console.WriteLine(A.ToString() + ": " + result(X, A));
        Assert.Equal(-1, result(X, A));

        X = 1;
        A = new int[] { 1 };
        Console.WriteLine(A.ToString() + ": " + result(X, A));
        Assert.Equal(0, result(X, A));
    }

}