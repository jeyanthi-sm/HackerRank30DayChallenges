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

namespace Day10Challenge
{



    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int max = DecimaltoBinary(n);
            Console.WriteLine(max);
            Console.Read();
        }
         private static int DecimaltoBinary(int n)
        //private static int DecimaltoBinary(int n)
        {
            int i;
            int inp = n;
            string binarystr = "";
            List<int> list = new List<int>();
            while (inp > 0)
            {
                i = (inp % 2);
                binarystr += i;
                list.Add(i);
                inp /= 2;

            }
     /*       string binarystr = "";
            foreach (var x in list)
                binarystr += x; */
            string[] mainList1 = binarystr.Split("0");
            int max1 = 0;
            foreach (var x in mainList1)
            {
               if (x.Count() > max1 )
                    max1 = x.Count();

            }
            return max1;

        }
    }


}
