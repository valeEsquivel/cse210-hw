using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        string letterGrade;
        string symbol = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade % 10 >= 7)
        {
            symbol = "+";
        }
        else if (grade % 10 <= 3)
        {
            symbol = "-";
        }

        // Excluding A+ and F
        if (grade > 93 || grade < 60)
        {
            symbol = "";
        }

        Console.WriteLine($"Your got a {letterGrade}{symbol}!");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass the course. You can do better next time!");
        }
    }
}