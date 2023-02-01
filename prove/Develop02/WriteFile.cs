using System;
using System.IO;

public class WriteFile
{
    public List<Journal>journalList= new List<Journal>();
    
    public String _data1 ="";
    public String _data2 ="";

    public String fileName = "myFile.txt";
    public void Data(){
        foreach(Journal i in journalList){
            _data1 =($"date: {i._date} - prompt: {i._prompt}");
            _data2 =(i._response);
            Console.WriteLine(_data1);
            Console.WriteLine(_data2);
        }
        using (StreamWriter outputFile = new StreamWriter(fileName,append:true))
            {
              outputFile.WriteLine($" {_data1} {_data2}.");  
            }
    }
    
    
    
}
