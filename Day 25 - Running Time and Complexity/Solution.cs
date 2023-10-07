using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static bool IsPrime(int n) {
        if (n <= 1) {
            return false;
        }
        if (n <= 3) {
            return true;
        }
        if (n % 2 == 0 || n % 3 == 0) {
            return false;
        }
        for (int i = 5; i * i <= n; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0) {
                return false;
            }
        }
        return true;
    }
    static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n)) {
                Console.WriteLine("Prime");
            } else {
                Console.WriteLine("Not prime");
            }
        }
    }
}
