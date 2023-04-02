class Program
{
    static void Main(string[] args)
    {
        
        var address1 = new Address("Main Street 12", "Brooklyn", "New York", "11219");
        
        var address2 = new Address("5th Ave. 20","NY","New York","11220");

        var address3 = new Address("W 65 Street","Central Park","New York","11220");


        var conference = new Conference("Introduction to C#", "Basic principles of programming with C# for the development of websites", new DateTime(2023, 4, 07, 14, 16, 5),new TimeSpan(10) ,address1, "Jack Wise", 100);

        var reception = new Reception ("Reception for IT technology students", "Reception and explanation of the subjects to be studied during the year", new DateTime(2023, 5, 20, 18, 12, 0),new TimeSpan(14) ,address2, "mail@enterprise.com");

        var outdoorMeeting = new OutdoorMeeting("Amazon Employee Pic-nic", "Amazon Employee Picnic with Food - Free Drinks and Dessert", new DateTime(2023, 6, 25, 10, 0, 0),new TimeSpan(12) ,address3, "sunny");

        
        Console.WriteLine(conference.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(conference.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(conference.GetBriefDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetBriefDescription());
        Console.WriteLine();

        Console.WriteLine(outdoorMeeting.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorMeeting.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorMeeting.GetBriefDescription());

        Console.ReadKey();
    }
}
