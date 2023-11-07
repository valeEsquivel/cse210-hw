using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Red";
        job1._jobTitle = "Trainee";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Grupo CASSA";
        job2._jobTitle = "Sofware Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Valeria Esquivel";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}