

	// Add your code here
    public Difference(int[] a)
        {
            elements = a;
        }

        // Add your code here
    public void computeDifference()
        {
            int cnt = elements.Count();
            //  int maximumDifference = 0;  
            for (int i = 0; i <= (cnt - 2); i++)
            {
                for (int j = i + 1; j <= cnt - 1; j++)
                {
                    int elementdiff = Math.Abs(elements[i] - elements[j]);
                    if (elementdiff > maximumDifference)
                        maximumDifference = elementdiff;
                }

            }
        }
