using System;
using System.IO;

public class Show
{
public List<Journal>journalList= new List<Journal>();
    
    


    public void Data(){
        foreach(Journal i in journalList){
            Console.WriteLine($"date: {i._date} - Prompt: {i._prompt}");
            Console.WriteLine(i._response);
            Console.WriteLine();
        }
    }
    
    public void WriteFile(String fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
            { 
                foreach(Journal i in journalList){
                outputFile.WriteLine($"{i._date}-{i._prompt}-{i._response}-"); 
            } 

            }
        
            
    }
}    
