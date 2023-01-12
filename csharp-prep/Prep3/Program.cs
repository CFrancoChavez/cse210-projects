using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number?");
        string magicNum = Console.ReadLine();
        int magic = int.Parse(magicNum);

        Console.WriteLine("What is your guess?");
        string guessNum = Console.ReadLine();
        int guess = int.Parse(guessNum);
        
        if(magic > guess){
            Console.WriteLine("Higher");
        }
        else if(magic< guess){
            Console.WriteLine("Lower");
        }
        else {
            Console.WriteLine("You guessed it!");
        };
    }
}