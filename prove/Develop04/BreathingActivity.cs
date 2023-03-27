using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity 
{
    private int _inputNumber;

    protected string [] typeActivity={"Welcome to the Breathing Activity.","Welcome to the Reflection Activity.","Welcome to the Listing Activity."};

    public void Welcome(){

        Console.WriteLine(typeActivity[0]);
        Console.WriteLine("This Activity will help you relax by walking\n your through breathing in and out\n slowly. Clear your mind and focus on your breathing.\n");
        //Console.WriteLine("Get ready...");
        Console.WriteLine("*************************************");
    }

    public void BreathingPrompt()
    {
        Console.WriteLine("How long in seconds, would you like for your session?");
        string option = Console.ReadLine();
        InputNumber = int.Parse(option);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(InputNumber);
        Spinner();
        while(DateTime.Now<= endTime)
        {
            Console.WriteLine("Breath in ...");
            CountDown();
            Console.WriteLine("Now breath out...");
            CountDown();
            Console.WriteLine("Well done!! you have completed another "+ InputNumber+" seconds of the Breathing Activity");
        }
    }

    public int InputNumber 
    {
        get { return _inputNumber; }
        private set { _inputNumber = value; }
    }
    protected int timer = 6;
    public void CountDown()
    {
        timer = 6;
        for(int i = timer; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected List<string> animationString = new List<string>();
    public void Spinner()
    {
        Console.WriteLine("Get ready...");
        //animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");

        foreach(string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
