using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
     public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int maxConsecutive = GetMaxConsecutiveOnes(n);
        Console.WriteLine(maxConsecutive);
    }

    static int GetMaxConsecutiveOnes(int n)
    {
        string binaryStr = Convert.ToString(n, 2); // Convert n to binary string
        int maxConsecutive = 0;
        int consecutive = 0;

        foreach (char digit in binaryStr)
        {
            if (digit == '1')
            {
                consecutive++;
                maxConsecutive = Math.Max(maxConsecutive, consecutive);
            }
            else
            {
                consecutive = 0;
            }
        }

        return maxConsecutive;
    }
}
