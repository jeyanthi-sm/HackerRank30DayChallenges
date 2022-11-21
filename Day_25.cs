using System;
using System.Collections.Generic;
using System.IO;
class Solution {
     static string PrimeCheck(int n)
        {
          
            
            if (n < 2)
                return "Not prime";
            if ((n == 2) || (n == 3))
                return "Prime";
            if ((n % 2 == 0) || (n % 3 ==0))
                return "Not prime";  
            int sqrtn = (int)Math.Sqrt(n); 
            
            for ( int i = 5; i * i <= n; i+=6)
            {  
               if (n % i == 0 || n % (i + 2) == 0)
                return "Not prime";
            
                
            }
          
                return "Prime";
          
      

        }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
                    int T = 0;
            List<int> list = new List<int>();
            T = int.Parse(Console.ReadLine().TrimEnd());
            while (T-- > 0)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in list)
            {
               // Console.WriteLine("{0} {1} ",Convert.ToString(item),PrimeCheck(item));
                Console.WriteLine("{0}", PrimeCheck(item));
            }
        
    }
}
