

class Student : Person{
    private int[] testScores;  
    public Student(string firstName, string lastName, int identification, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
        this.testScores = scores;
    }
   public char Calculate()
    {
        int sum = testScores.Sum();
        int average = sum / testScores.Length;

        if (average >= 90 && average <= 100)
        {
            return 'O'; // Outstanding
        }
        else if (average >= 80 && average < 90)
        {
            return 'E'; // Exceeds Expectations
        }
        else if (average >= 70 && average < 80)
        {
            return 'A'; // Acceptable
        }
        else if (average >= 55 && average < 70)
        {
            return 'P'; // Poor
        }
        else if (average >= 40 && average < 55)
        {
            return 'D'; // Dreadful
        }
        else
        {
            return 'T'; // Troll
        }
    }
}

