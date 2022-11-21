

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int maxsum = 0;
        for (int i=1; i <= n; ++i)
        {
            if (n % i == 0)
            {
                maxsum += i;
            }
             
        }
        return maxsum;
    }
}

