using System;

namespace lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Jewel = new Student("Jewel", "Ramirez");
            Student Emily = new Student("Emily", "V.");
            Instructor steve = new Instructor("Steve", "Brownlee");
            Cohort cohort26 = new Cohort();

            cohort26.Instructors.Add(steve);
            cohort26.Students.Add(Emily);
            cohort26.Students.Add(Jewel);

            Exercises ex1 = new Exercises();
            ex1.Name = "ChickenMonkey";
            ex1.Language = "JavaScript";
            ex1.GithubUrl = "www.github.com";

            Exercises ex2 = new Exercises();
            ex2.Name = "Millionaire";
            ex2.Language = "C#";
            ex2.GithubUrl = "www.github.com";

            steve.Assign(Jewel, ex1);

            foreach (Exercises exe in Jewel.assignedExercises)
            {
                Console.WriteLine($"{exe.Name} was assinged to {Jewel.FullName}");
            }
        }
    }
}
