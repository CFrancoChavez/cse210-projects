public class ChecklistGoal:Goal {
    public int _timesToComplete {get; set;} = 3;

    public int _timesCompleted {get; set;}

    public int _bonusPoints {get; set;} = 500;

    public ChecklistGoal() : base(){
        _timesToComplete = SetTimesToComplete();
        _bonusPoints = SetBonusPoints();
        _type = GoalTypes.ChecklistGoal;
    }

    public ChecklistGoal(string title, string description, int points, int timesToComplete, int timesCompleted, int bonusPoints, bool isAchieved) : base(title, description, points, isAchieved){
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
        _type = GoalTypes.ChecklistGoal;
    }

    private int SetBonusPoints()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int points))
            {
                return points;
            }
        else
            {
                Console.WriteLine($"Invalid input. Set to default{_bonusPoints}.");
                return _bonusPoints;
            }
    }

    private int SetTimesToComplete()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string input = Console.ReadLine();
            if (int.TryParse(input, out int times))
                {
                    return times;
                }
            else
                {
                    Console.WriteLine($"Invalid input. Set to default{_timesToComplete}.");
                    return _timesToComplete;
                }
    }

    public override int RecordEvent(){
        _timesCompleted++;
        _goalIsAchieved = IsComplete();
        if(_goalIsAchieved){
            return _pointsForGoal + _bonusPoints;
        }

        return _pointsForGoal;
    }

    public override bool IsComplete(){
        if(_timesCompleted == _timesToComplete)
        {
            return true;
        }
        return false;
    }
}