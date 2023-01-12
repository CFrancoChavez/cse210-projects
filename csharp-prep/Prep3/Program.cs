using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string magicNum = "";
        int magic = 0;
        string guessNum = "";
        int guess = 0;

        Console.WriteLine("What is the magic number?");
        magicNum = Console.ReadLine();
        magic = int.Parse(magicNum);

        
        do 
        {
            

            Console.WriteLine("What is your guess?");
            guessNum = Console.ReadLine();
            guess = int.Parse(guessNum);
            
            if(magic > guess){
                Console.WriteLine("Higher");
                //break;
            }
            else if(magic< guess){
                Console.WriteLine("Lower");
                //break;
            }
            else{
                Console.WriteLine("You guessed it!");
            }
            } while (magic!=guess);
            
        
    }

}