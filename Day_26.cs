using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
               List<int> returneddate = (Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrtemp => Convert.ToInt32(arrtemp)).ToList());

        List<int> duedate = (Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrtemp => Convert.ToInt32(arrtemp)).ToList());
        var fine = 0;
        if (returneddate[2] > duedate[2])  // Same calendar year
            fine = 10000;  //fine of 50000 hackos 
        else if (returneddate[2] == duedate[2]) //same year
        {
            if (returneddate[1] > duedate[1])  //different month Checking for month
            {
                int noofmonths = returneddate[1] - duedate[1];
                fine = noofmonths * 500;
            }
            else if (returneddate[1] == duedate[1] //same month
                                    && returneddate[0] > duedate[0])
            {
                int noofdays = returneddate[0] - duedate[0];
                fine = noofdays * 15;

            }
        }
        //if (fine > 0)
        Console.WriteLine(fine);
 
    }
}
