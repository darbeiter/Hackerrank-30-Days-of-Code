using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Create a Dictionary to store phone book entries
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        // Read and store phone book entries
        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string phoneNumber = entry[1];
            phoneBook[name] = phoneNumber; // Add or update the entry
        }

        // Process queries
        while (true)
        {
            string query = Console.ReadLine();
            if (query == null)
            {
                break; // No more input
            }

            if (phoneBook.ContainsKey(query))
            {
                // Print the name and phone number
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
            else
            {
                // Name not found
                Console.WriteLine("Not found");
            }
        }
    }
}
