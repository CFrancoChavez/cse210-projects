using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if(number>= 90){
            Console.WriteLine("A");
        }
        else if(number>=80){
            Console.WriteLine("B");
        }
        else if(number>=70){
            Console.WriteLine("C");
        }
        else if(number>=60){
            Console.WriteLine("D");
        }
        else {
            Console.WriteLine("F");
        };
        
        if (number >=70){
            Console.WriteLine("Congratulations you have passed the course!");
        }
        else {
           Console.WriteLine("Keep working hard to pass next time.");
        }

        
    }
}