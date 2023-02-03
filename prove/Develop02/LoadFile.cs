using System;
using System.IO;

class LoadFile
{
    public  void Load(String filename,Show showLoad)
    {
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Journal journalFile = new Journal();
            string[] parts = line.Split("-");

            journalFile._prompt = parts[1];
            journalFile._response = parts[2];
            journalFile._date = parts[0];
            showLoad.journalList.Add(journalFile);
        }

        // try
        // {
        //     // Create an instance of StreamReader to read from a file.
        //     // The using statement also closes the StreamReader.
        //     using (StreamReader sr = new StreamReader("myFile.txt"))
        //     {
        //         string line;
        //         // Read and display lines from the file until the end of
        //         // the file is reached.
        //         while ((line = sr.ReadLine()) != null)
        //         {
        //             Console.WriteLine(line);
        //         }
        //     }
        // }
        // catch (Exception e)
        // {
        //     // Let the user know what went wrong.
        //     Console.WriteLine("The file could not be read:");
        //     Console.WriteLine(e.Message);
        // }
    }
}