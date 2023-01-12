using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //string magicNum = "";
        //int magic = 0;
        string guessNum = "";
        int guess = 0;
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        

        
        do 
        {
            

            Console.WriteLine("What is your guess?");
            guessNum = Console.ReadLine();
            guess = int.Parse(guessNum);
            
            if(magic > guess){
                Console.WriteLine("Higher");
                
            }
            else if(magic< guess){
                Console.WriteLine("Lower");
                
            }
            else{
                Console.WriteLine("You guessed it!");
            }
            } while (magic!=guess);
            
        
    }

}