public class Goal {
    public string _goalTitle {get; set;} 
    public string _goalDescription {get; set;}
    public int _pointsForGoal{get; set;} = 50;
    public bool _goalIsAchieved{get; set;}

    public GoalTypes _type;

    public Goal(){
        _goalTitle = SetGoalTitle();
        _goalDescription = SetGoalDescription();
        _pointsForGoal = SetGoalPoints();
        _type = GoalTypes.SimpleGoal;
    }

    public Goal(string title, string description, int points, bool isAchieved){
        _goalTitle = title;
        _goalDescription = description;
        _pointsForGoal = points;
        _goalIsAchieved = isAchieved;
        _type = GoalTypes.SimpleGoal;
    }

    public virtual int RecordEvent(){
        _goalIsAchieved = IsComplete();
        return _pointsForGoal;
    }

    public virtual bool IsComplete(){
        return true;
    }

    public string SetGoalTitle()
    {
        Console.WriteLine("What is the name of your goal?");
        return Console.ReadLine();
    }

    public string SetGoalDescription()
    {
        Console.WriteLine("What is a short description of it?");
        return Console.ReadLine();
    }

    public int SetGoalPoints()
    {
    Console.WriteLine("How many points will this be worth?");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int points))
        {
            return points;
        }
    else
        {
            Console.WriteLine($"Invalid input. Set to default{_pointsForGoal}.");
            return _pointsForGoal;
        }
    }
}