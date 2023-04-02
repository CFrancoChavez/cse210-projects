using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Run run = new Run(new DateTime(2023, 04, 3), 30, 5.0);
        Cycling cycling = new Cycling(new DateTime(2023, 04, 4), 30, 13.0);
        Swimming swimming = new Swimming(new DateTime(2024, 04, 5), 30, 18);

        activities.Add(run);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"**{activity.GetSummary()}**\n");
        }
    }
}
