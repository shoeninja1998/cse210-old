using System;

class Program
{
    static void Main(string[] args)
    {
        Job job_1 = new Job();
            job_1._job_title = "Software Engineer";
            job_1._company = "Microsoft";
            job_1._start_year = 2010;
            job_1._end_year = 2018;

        Job job_2 = new Job();
            job_2._job_title = "Garbageman";
            job_2._company = "N/A";
            job_2._start_year = 1834;
            job_2._end_year = 2009;
        
        Resume resume_1 = new Resume();
            resume_1._name = "Jeffrey Michaelsteen";
            resume_1._jobs.Add(job_1);
            resume_1._jobs.Add(job_2);

            resume_1.Display();
    }
}