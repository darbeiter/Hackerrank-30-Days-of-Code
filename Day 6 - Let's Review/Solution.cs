using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      int t = Convert.ToInt32(Console.ReadLine().Trim()); // Number of test cases

        for (int i = 0; i < t; i++)
        {
            string input = Console.ReadLine().Trim(); // Read the input string

            // Initialize two empty strings for even and odd characters
            string evenChars = "";
            string oddChars = "";

            // Iterate through the characters of the input string
            for (int j = 0; j < input.Length; j++)
            {
                if (j % 2 == 0)
                {
                    // Append even-indexed character to evenChars
                    evenChars += input[j];
                }
                else
                {
                    // Append odd-indexed character to oddChars
                    oddChars += input[j];
                }
            }

            // Print even and odd characters with a space in between
            Console.WriteLine(evenChars + " " + oddChars);
        }
    }
}
