using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        if (grade >= 90)
        {
            string gradeLevel = "A";
            Console.WriteLine("Your grade level is " + gradeLevel +".");
            Console.WriteLine();
        }
        else if (grade >= 80)
        {
            string gradeLevel = "B";
            Console.WriteLine("Your grade level is " + gradeLevel +".");
            Console.WriteLine();
        }
        else if (grade >= 70)
        {
            string gradeLevel = "C";
            Console.WriteLine("Your grade level is " + gradeLevel +".");
            Console.WriteLine();
        }
        else if (grade >= 60)
        {
            string gradeLevel = "D";
            Console.WriteLine("Your grade level is " + gradeLevel +".");
            Console.WriteLine();
        }
        else
        {
            string gradeLevel = "F";
            Console.WriteLine("Your grade level is " + gradeLevel +".");
            Console.WriteLine();
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed the course. Congrats!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Your grade is lower than 60% needed to pass this course,\n but you can certainly do better if you persevere");
            Console.WriteLine();
        }
    }
}