

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
      public Student(string firstName, string lastName, int id, int[] scores):base(firstName, lastName,id)
    {
        //this.firstName = firstName;
        //this.lastName = lastName;
        //this.id = id;
        testScores = scores;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
public char Calculate()
    {
   
     var x = (from tvar in this.testScores select tvar).Average();
        
        

        if ((x >= 90) && (x <= 100))
            return 'O';
        else if ((x >= 80) && (x < 90))
            return 'E';
        else if ((x >= 70) && (x < 80))
            return 'A';
        else if ((x >= 55) && (x < 70))
            return 'P';
        else if ((x >= 40) && (x < 55))
            return 'D';
        else if (x < 40) 
            return 'T';
        return 'T';
    }
}

