

    //Write your code here
class Calculator
    {
       internal int power(int n, int p)
        {
            try
            {
                if ((n < 0 || p < 0))
                {
                    throw new System.Exception("n and p should be non-negative");
                   
                }
                return ((int)Math.Pow(n, p));
            }
            catch (Exception e)
            {

                // Console.WriteLine(e.Message);
                throw;
                return 0;
            } 
  
        }
    }


