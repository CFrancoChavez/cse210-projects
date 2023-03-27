using System;
using System.Threading;


public class ReflectionActivity : BreathingActivity
{
    protected int inputNumber;
    protected string option;
    protected string _prompt;
    protected string question;

    public void ReflectingPrompt()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        option = Console.ReadLine();
        inputNumber = int.Parse(option);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(inputNumber);
        Spinner();

        Console.WriteLine("Consider the folowing prompt");
        Random rnd = new Random();
        String[] _prompts = { "Think of a time when you stood up for someone else.\n", "Think of a time when you did something really difficult.\n", "Think of a time when you helped someone in need.\n", "Think of a time when you did something truly selfless.\n" };
        int mIndex = rnd.Next(_prompts.Length);
        _prompt = (_prompts[mIndex]);
        
        
        //Random one = new Random();
        String[] _questions = {"< How do you feel when it was complete?","< What is your favorite thing about this experience","< How did you get started?","< Why was this experience meaningful to you?", "< Have you ever done anything like this before?","< What made this time different than other times when you were not as successful?","< What could you learn from this experience that applies to other situations?","< What did you learn about yourself through this experience?","< How can you keep this experience in mind in the future?"};
        //int myOne = one.Next(_questions.Length);
        //_question = (_questions[myOne]);

        while(DateTime.Now<= endTime)
        {
            Console.WriteLine(_prompt);
            Console.WriteLine("When you have something in mind press enter to continue.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("");
            Console.WriteLine("You may begin in:");
            CountDown();
            foreach(string question in _questions){
                Console.WriteLine(question);
                CountDown();
            }
            Console.WriteLine("Well done!! You have completed another "+inputNumber+" seconds of the Reflecting Activity");
        }
    }

}