using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final grade? ");
        string gradeInput = Console.ReadLine();

        int grade = int.Parse(gradeInput);

        string finalGrade = "";

        if (grade >= 90)
        {
            finalGrade = "A";
        }
        else if (grade >= 80)
        {
            finalGrade = "B";
        }
        else if (grade >= 70)
        {
            finalGrade = "C";
        }
        else if (grade >= 60)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }

        Console.WriteLine($"Your final grade is {finalGrade}.");

        if (grade >= 0)
        {
            if (grade>= 70)
            {
                Console.WriteLine("Congratulations you have PASSED the course!");
            }
            else
            {
                Console.WriteLine("Remember that with persistence comes sucess. Please try again!");
            }
        }

    }
}