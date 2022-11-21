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
using System.Diagnostics;

class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        /* for (int row = 0; row < arr.Count; row++)
            for (int col = 0; col < arr.Count; col++)
                Console.WriteLine(arr[row][col]);
        */
        // Array hourglass sum declaration
                 int[,] arrayhourglasssum = new int[4, 4];
           

        int maxvalue = 0;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {

               arrayhourglasssum[row, col] = hourglass(arr, row, col);
            }
        }
        var query = from int xyz in arrayhourglasssum select xyz;
        var query2 = (from item in arrayhourglasssum.Cast<int>() select item).Max();
       
        Console.WriteLine("{0}", query2);
        //maxvalue = query.Max();
        //Console.WriteLine("{0}", maxvalue);
   
    }
            private static int hourglass (List<List<int>> arr,int r1,int c1)
    {
        int startrow = r1;
        int startcol = c1;
        int currsum = 0;
        Debug.WriteLine("Start row {0} Start col {1}" , startrow, startcol);
        //a b c
        for (int scol = startcol; scol <= startcol + 2; scol++)
            currsum += arr[startrow][scol];
        Debug.WriteLine("abc" + currsum);
        //d
        currsum += arr[startrow+1][startcol+1];
        Debug.WriteLine("d" + currsum);
        //efg
        for (int scol = startcol; scol <= startcol + 2; scol++)
            currsum += arr[startrow + 2][scol];
        Debug.WriteLine("efg" + currsum);
        return currsum;
    }
}
