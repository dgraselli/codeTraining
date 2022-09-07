class S1_PlusMinus
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void result(List<int> arr)
    {
        var total = arr.Count();
        var positives = arr.Where(s => s > 0).Count();
        var negatives = arr.Where(s => s < 0).Count();
        var zeros = total - positives - negatives;
        Console.WriteLine($"{((double)positives / total):0.000000}");
        Console.WriteLine($"{(double)negatives / total:0.000000}");
        Console.WriteLine($"{(double)zeros / total:0.000000}");

    }

}