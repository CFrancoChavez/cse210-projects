using System;

public class Journal
{
    //public string[] _prompts = {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"};
    public String _date= "";
    public String _prompt ="";

    public String _response = "";
    
    
    public void Iteration(){
        Random rnd = new Random();
        String[] _prompts = {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"};
    
        int mIndex = rnd.Next(_prompts.Length);
        _prompt = (_prompts[mIndex]);
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }
   
} 
