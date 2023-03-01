using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("1 Samuel", 17, 45, 46);
        var scriptureText = "Then said David to the Philistine, Thou comest to me with a sword, and with a spear, and with a shield: but I come to thee in the aname of the Lord of hosts, the God of he armies of Israel, whom thou hast defied. This day will the Lord adeliver thee into mine hand; and I will smite thee, and take thine head from thee; and I will give the carcases of the host of the Philistines this day unto the fowls of the air, and to the wild beasts of the earth; that all the earth may bknow that there is a God in Israel.";
        var scripture = new Scripture(reference, scriptureText);
        
        //scripture.SetDifficulty();
        var input = ""; 
             
        //while (true) 
        do
        {
            Console.WriteLine(scripture.GetRenderedText());
            input = Menu.GetInput();
            if(input == "Q" || input == "q"){
                break;
            }
            if(scripture.IsCompletelyHidden()){
                break;
            }
            scripture.HideWords();
        }
        while(input =="");
        Console.ReadKey();
    }
}