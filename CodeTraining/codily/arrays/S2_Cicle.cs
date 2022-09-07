class S2_Cicle
{

    public static int[] result(int[] A, int K)
    {
        if (A.Length == 0)
            return A;

        var movs = K % A.Length;
        var ret = new int[A.Length];
        for (var i = 0; i < A.Length; i++)
        {
            ret[(i + movs) % A.Length] = A[i];
        }
        return ret;
    }


}