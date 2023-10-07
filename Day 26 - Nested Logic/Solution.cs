using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] returnedDate = Console.ReadLine().Split(' ');
        int returnedDay = int.Parse(returnedDate[0]);
        int returnedMonth = int.Parse(returnedDate[1]);
        int returnedYear = int.Parse(returnedDate[2]);

        // Read the due date
        string[] dueDate = Console.ReadLine().Split(' ');
        int dueDay = int.Parse(dueDate[0]);
        int dueMonth = int.Parse(dueDate[1]);
        int dueYear = int.Parse(dueDate[2]);

        int fine = 0;

        if (returnedYear > dueYear || (returnedYear == dueYear && returnedMonth > dueMonth) || (returnedYear == dueYear && returnedMonth == dueMonth && returnedDay > dueDay)) {
            // Book is returned after due date
            if (returnedYear == dueYear && returnedMonth == dueMonth) {
                // Within the same month and year
                fine = 15 * (returnedDay - dueDay);
            } else if (returnedYear == dueYear && returnedMonth > dueMonth) {
                // Within the same year
                fine = 500 * (returnedMonth - dueMonth);
            } else {
                // After the calendar year
                fine = 10000;
            }
        }

        Console.WriteLine(fine);
    }
}
