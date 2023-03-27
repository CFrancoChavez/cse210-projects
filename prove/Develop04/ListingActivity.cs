using System;
using System.Threading;


public class ListingActivity : BreathingActivity
{
    protected int inputNumber;
    protected string option;
    protected string _prompt;
    protected string response;

    public void ListingPrompt()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        option = Console.ReadLine();
        inputNumber = int.Parse(option);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(inputNumber);
        Spinner();

        Console.WriteLine("List as many responses you can to the following prompt.");
        Random rnd = new Random();
        String[] _prompts = { "Who are people that you appreciate?\n", "What are personal strengths of yours?\n", "Who are people that you have helped this week?\n", "When have you felt the Holy Ghost this month?\n","Who are some of your personal heroes?\n" };
        int mIndex = rnd.Next(_prompts.Length);
        _prompt = (_prompts[mIndex]);
        
        
        //Random one = new Random();
        List<string> _responses = new List<string>();

        //int myOne = one.Next(_questions.Length);
        //_question = (_questions[myOne]);

        while(DateTime.Now<= endTime)
        {
            
            Console.WriteLine("");
            Console.WriteLine(_prompt);
            Console.WriteLine("You may begin in:");
            CountDown();
            //CountDown();
            while (true)
            {
               
                response = Console.ReadLine();
                Console.ReadKey();
                if (DateTime.Now >= endTime)
                {
                    break;
                }
                _responses.Add(response);
                // Console.WriteLine("You listed " + _responses.Count + " items");
                // Console.WriteLine("Well done!!");
            }
            Console.WriteLine("You listed " + _responses.Count + " items");
            Console.WriteLine("Well done!! You have completed another "+inputNumber+" seconds of the Listing Activity");
        }

        
    }

}