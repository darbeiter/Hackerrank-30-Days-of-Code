public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int sum = 0;
        
        // Iterate from 1 to n and check if each number is a divisor of n.
        for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
                sum += i; // Add the divisor to the sum.
            }
        }
        
        return sum;
    }
}

