using Xunit;

class Compression
{

    public static string result(string a)
    {
        if (a == null || a.Length == 0)
            return a;

        var i = 1;
        var count = 1;
        var output = "";
        var c = a[0];

        while (i < a.Length)
        {
            if (a[i] == c)
            {
                count += 1;
                i += 1;
                continue;
            }
            output += (count > 1) ? $"{count}{c}" : $"{c}";
            c = a[i];
            count = 1;
            i += 1;
        }

        if (count > 0)
            output += (count > 1) ? $"{count}{c}" : $"{c}";

        return output;
    }

    public static void test()
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### Compression");
        Console.WriteLine("########################################");

        var cadema = "AAABBCDDDDEEE";
        Console.WriteLine(cadema + ": " + Compression.result(cadema));
        Assert.Equal("3A2BC4D3E", Compression.result(cadema));

        cadema = "ABBCDDDDEEEG";
        Console.WriteLine(cadema + ": " + Compression.result(cadema));
        Assert.Equal("A2BC4D3EG", Compression.result(cadema));

    }

}