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
        string S = Console.ReadLine();
        try
            {

                int i = Convert.ToInt32(S);
                Console.WriteLine(i);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Bad String");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("{0} {1} ", ex.Message, ex.GetType());
                Console.WriteLine("Overflow String");
            }
    }
}
