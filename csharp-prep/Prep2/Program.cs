using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "grade";
        string sign ="";

        if(number>= 90){
            letter = "A";
        }
        else if(number>=80){
            letter = "B";
        }
        else if(number>=70){
            letter = "C";
        }
        else if(number>=60){
            letter = "D";
        }
        else {
            letter = "F";
        };
        if(number%10 >= 7){
            sign = "+";
        }
        else if(number%10<=3){
            sign = "-";
        };
        
        if(letter =="A" && sign != "-"){
            sign = "";
        };
        
        
        if(letter == "F"){
            sign = "";
        }
            Console.WriteLine($"Your grade is: {letter} {sign}");
        if (number >=70){
            Console.WriteLine("Congratulations you have passed the course!");
        }
        else {
           Console.WriteLine("Keep working hard to pass next time.");
        }

        
    }
}