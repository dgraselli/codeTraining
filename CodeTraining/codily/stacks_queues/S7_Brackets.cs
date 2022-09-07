using Xunit;
using System.Linq;
using System.Collections;

class S7_Brackets
{
    public static int result(String S)
    {
        var stack = new Stack<char>();

        foreach (var s in S.ToCharArray())
        {
            if ("({[".Contains(s))
                stack.Push(s);
            else if (")}]".Contains(s))
            {
                if (stack.Count == 0) return 0;
                var e = stack.Pop();
                if (oposite(e) != s)
                    return 0;
            }

        }
        return stack.Count == 0 ? 1 : 0;

    }

    private static char oposite(char x)
    {
        if (x == '{') return '}';
        if (x == '(') return ')';
        if (x == '[') return ']';
        throw new Exception("not [{(");
    }

    public static void test() 
    {
        Console.WriteLine("########################################");
        Console.WriteLine("### S7_Brackets");
        Console.WriteLine("########################################");

        var S = "{ [()()]}";
        var res = result(S);
        Console.WriteLine(S + ": " + res);
        Assert.Equal(1, res);

        S = "{ [())]}";
        res = result(S);
        Console.WriteLine(S + ": " + res);
        Assert.Equal(0, res);
    }

}