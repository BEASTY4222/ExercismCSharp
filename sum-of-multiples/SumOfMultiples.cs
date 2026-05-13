public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> myMultiples = new HashSet<int>();
        int i = 0, sum = 0;
        
        foreach (int multiple in multiples)
        {
            if (i % multiple == 0 && i < max) myMultiples.Add(i);
        }

        foreach (int number in myMultiples) sum +=  number;
        
        return sum;
    }
}