using Xunit;

class S3_PermMissingElement
{

    public static int result(int[] A)
    {
        var n = A.LongLength;
        long total = (n + 1) * (n + 2) / 2;
        foreach (var i in A)
        {
            total -= i;
        }
        return (int)total;
    }

    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S3_PermMissingElement");
        Console.WriteLine("########################################");

        var A = new int[] { 3, 2, 1, 5 };
        Console.WriteLine(A.ToString() + ": 4");
        Assert.Equal(4, result(A));

        A = new int[] { 3, 4, 1, 5 };
        Console.WriteLine(A.ToString() + ": 2");
        Assert.Equal(2, result(A));
    }

}