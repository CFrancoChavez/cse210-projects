using System;
using System.IO;

public class Base 
{
    private string option = "";
    private int inputNumber = 0;
    protected string [] typeActivity={"Welcome to the Breathing Activity.","Welcome to the Reflection Activity.","Welcome to the Listing Activity."};

    protected string[] description ={"This Activity will help you relax by walking\n your through breathing in and out\n slowly. Clear your mind and focus on your breathing.\n","This actvity will help you reflect on times in your life\n when you have shown strength and resilience.\n This will help you recognize the power you have\n and how you can use it in others aspects of your life. ","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."};

    public int GetInputNumber()
    {
        return inputNumber;
    }

    public void Display(int inputNumber)
    {
        
        


        while (inputNumber != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu");
           
            option = Console.ReadLine();
            inputNumber = int.Parse(option);
            
            if (inputNumber == 1) {
                Console.WriteLine(typeActivity[0]);
                Console.WriteLine(description[0]);
                BreathingActivity myBreath = new BreathingActivity();
                //myBreath.Welcome();
                //myBreath.Spinner();
                myBreath.BreathingPrompt();
                myBreath.CountDown();
            }
             else if(inputNumber == 2){
                Console.WriteLine(typeActivity[1]);
                Console.WriteLine(description[1]);
                ReflectionActivity myReflect = new ReflectionActivity();
                myReflect.ReflectingPrompt();    
                
             }
              else if(inputNumber == 3){
                Console.WriteLine(typeActivity[2]);
                Console.WriteLine(description[2]);
                ListingActivity myListing = new ListingActivity();
                myListing.ListingPrompt();
            //     
                
             }
           
            // else {
            //     Console.WriteLine("Your choice is invalid!");
            // }
        } 
    }
}
