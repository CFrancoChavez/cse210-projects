using System;

class Program
{   static void DisplayResult(string name, int number ){
    Console.WriteLine($"{name}, the square of your number is {number}");
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static string PromptUserName(){
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
}
    
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName,squareNumber);
    }
    

}