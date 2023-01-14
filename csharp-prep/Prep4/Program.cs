using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        string inputNumber="";
        int number=0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
        List<int> numbers;
        numbers = new List<int>();
        

        
        
        do 
        {
             Console.WriteLine("Enter number:  ");
             inputNumber = Console.ReadLine();
             number = int.Parse(inputNumber);
             numbers.Add(number);
        } while(number!=0);
        

        int count = (numbers.Count)-1;
        int sum = 0;

        for(int i =0; i< numbers.Count;i++){
            sum += numbers[i];
        }
        Console.WriteLine(count);
        Console.WriteLine("The sum is: "+sum);

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine("The average is: " + average);

        int max = numbers[0];
        foreach(int numb in numbers)
        {
            if(numb>max){
                max = numb;
            }
            
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}