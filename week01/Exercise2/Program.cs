using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letterGrade = "";
        int remainder = gradePercentage % 10;
        string sign;

        //Condition for the sing
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            if (remainder >= 7)
            {
                sign = "";
            }
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
            sign = "";
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your letter grade is {letterGrade}{sign}. Congratulations you pass!!");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letterGrade}{sign}. You don't pass, don't give up");
        }
        
    }
}