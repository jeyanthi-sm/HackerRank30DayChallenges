

        
        // Declare second integer, double, and String variables.
        int j =0;
        double d2;
        string s2 ="";
        double d3;
        // Read and save an integer, double, and String to your variables.
        j = Convert.ToInt32(Console.ReadLine());
        d2 = Convert.ToDouble(Console.ReadLine());
        s2 = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
         Console.WriteLine(i + j);
        // Print the sum of the double variables on a new line.
        d3 = d + d2;
         Console.WriteLine(string.Format("{0:0.0}", d3));     
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + s2);
