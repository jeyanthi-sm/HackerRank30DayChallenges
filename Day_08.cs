using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Name Phone key Values");
        Dictionary<string, int> dic = new Dictionary<string, int>();
        
        string[] x;
        for (int i = 0; i < n; i++)
        {
             x = Console.ReadLine().TrimEnd().Split(" ");
            dic.Add(x[0], Convert.ToInt32(x[1]));

            //   dic.Add("sam", 99912222);

        }

        bool c = true;
        bool valfound = false;
        string inpstr = "";
        //Console.WriteLine("Enter the name to search in the phone book");
        List<string> y = new List<string>();
        do
        {
            valfound = false;
            try
            {
                inpstr = Console.ReadLine().Trim();
            }
            catch
            {
                // Console.WriteLine(" Got you"); 
                c = false;
                break;
            }
            //Console.WriteLine("{0}",inpstr ?? "uu"); 
            int input = inpstr.Count();
        //  if (string.IsNullOrEmpty(inpstr))
                if (input == 0)
                c = false;
            else
                y.Add(inpstr);

        } while (c == true);
        int outvalue;
        foreach (var vinpstr in y)
        {
            valfound = false;
            if (dic.TryGetValue(vinpstr, out outvalue))
                    Console.WriteLine($"{vinpstr}={outvalue}");
            else
                Console.WriteLine("Not found");

            /*foreach (var item in dic)
            {
                if (vinpstr == item.Key)
                {
                    Console.WriteLine($"{item.Key}={item.Value}");
                    valfound = true;
                    break;
                }
            }
            
            if (valfound == false)
                Console.WriteLine("Not found"); */
        }


    }
}
