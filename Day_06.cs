using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //Console.WriteLine("Enter the number of Test Cases");
        int T = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Input " + T);
        List<string> inp_strings = new List<string>(); 
        //Console.WriteLine("Enter the strings");
        for (int i=1; i<= T; i++) {
         inp_strings.Add(Console.ReadLine().TrimEnd());
        }
 
        foreach (string i_s in inp_strings) {
          //Console.WriteLine(i_s);
          char[] c = i_s.ToCharArray();
         string even_indexes="";
         string odd_indexes="";     
          for (int j=0; j< c.Length; j++){
              if (j%2 == 0 ) 
                  even_indexes = even_indexes + c[j];
              else   
                  odd_indexes = odd_indexes + c[j];
              
          }
          Console.WriteLine(even_indexes + " " + odd_indexes); 
        }  
          
        
    }
}
