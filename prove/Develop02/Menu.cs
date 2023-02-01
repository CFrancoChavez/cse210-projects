using System;
using System.IO;

public class Menu
{
    public void Display(){
        

        string option = "";
        int inputNumber = 0;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        WriteFile writeFile= new WriteFile();
        LoadFile load = new LoadFile();
        Show showFile = new Show();

        while (inputNumber!=5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
           
            option = Console.ReadLine();
            inputNumber = int.Parse(option);
            
            if(inputNumber == 1){
                Journal myJournal = new Journal();
                myJournal.Iteration();
                String prompt = myJournal._prompt;
                String response = myJournal._response;
                myJournal._prompt = prompt;
                myJournal._response = response;
                myJournal._date = dateText;
                writeFile.journalList.Add(myJournal);
                
            
            }
            else if(inputNumber == 2){
                showFile.Data();
                
            }
            else if(inputNumber == 3){
                load.Load();
            }
            else if(inputNumber == 4){
                //saveFile.Saver();
                writeFile.Data();
            }
            else{
                Console.WriteLine("See You soon!");
            }
            } 
    }
}