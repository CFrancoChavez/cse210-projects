using System;

class Program
{
    static void Main(string[] args)
    {
        var isGoalMenu = true;
        var quit = false;
        var progress = new Progress();
        var points = progress.GetTotalPoints();
        Console.WriteLine($"You have {points} points");
        while (!quit) 
        {
            var input = Menu.GetInput();
            switch (input){
                case "1":
                    input = Menu.GetInput(isGoalMenu);
                    switch(input){
                        case "1":
                            progress.AddGoal(GoalTypes.SimpleGoal);
                        break;
                        case "2":
                            progress.AddGoal(GoalTypes.EternalGoal);
                        break;
                        case "3":
                            progress.AddGoal(GoalTypes.ChecklistGoal);
                        break;
                    }
                    break;
                case "2":
                    progress.DisplayGoalList();
                    break;
                case "3":
                    Console.Write($"Enter the name of the file to save to: ");
                    var file = Console.ReadLine();
                    progress.Save(file);
                    break;
                case "4":
                    Console.Write($"Enter the name of the file to load: ");
                    file = Console.ReadLine();
                    progress.Load(file);
                    break;
                case "5":
                    if(progress.GetGoalListIncrementNumber() > 1)
                    {
                        progress.GetAndRecordEvent();
                    }
                    else{
                        Console.WriteLine("Please Create New a New Goal First.");
                    }
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}