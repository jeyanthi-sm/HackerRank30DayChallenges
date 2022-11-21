

	/**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
    // Write your code here
          static public void PrintArray<T>(T[] first) //
        {
             for (int i = 0; i < first.Length; i++)
                Console.WriteLine(first[i]);
        }

