using System.Text;

public class Progress{
    private int _totalPoints = 0;
    private Dictionary<int, Goal> _goalDict = new Dictionary<int, Goal>();

    public void Points(int totalPoints)
    {
        _totalPoints = totalPoints;
    }


    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void DisplayGoalList()
    {
        Console.WriteLine("The Goals Are:");
            for (int i = 1; i <= _goalDict.Count(); i++){
                Console.Write($"{i}. {IsAchievedDisplay(_goalDict[i]._goalIsAchieved)} {_goalDict[i]._goalTitle} ({_goalDict[i]._goalDescription})");
                if(_goalDict[i] is ChecklistGoal checklistGoal)
                {
                    Console.Write($"-- Currently Completed: {checklistGoal._timesCompleted}/{checklistGoal._timesToComplete}");
                }
        }
        Console.WriteLine();
        Console.WriteLine($"you have {_totalPoints} points");
    }

    private string IsAchievedDisplay(bool isComplete){
        if(isComplete){
            return "[X]";
        }
        return "[ ]";
    }

    public int GetGoalListIncrementNumber(){
        return _goalDict.Count() + 1;
    }

    public void AddGoal(GoalTypes type)
    {
        switch(type){
            case GoalTypes.SimpleGoal:
                _goalDict.Add(GetGoalListIncrementNumber(),new Goal());
                break;
            case GoalTypes.EternalGoal:
                _goalDict.Add(GetGoalListIncrementNumber(),new EternalGoal());
                break;
            case GoalTypes.ChecklistGoal:
                _goalDict.Add(GetGoalListIncrementNumber(),new ChecklistGoal());
                break;    
        }
    }

    public void GetAndRecordEvent()
    {
        for (int i = 1; i <= _goalDict.Count(); i++){
            Console.WriteLine($"{i}. {_goalDict[i]._goalTitle}");
        }
        Console.WriteLine("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int goalNumber))
            {
                if(goalNumber <= _goalDict.Count()){
                    _totalPoints += _goalDict[goalNumber].RecordEvent();
                }
                else{
                    Console.WriteLine("invalid number entered.");
                }
            }
        else
            {
                Console.WriteLine($"Invalid input.");
            }
    }

      public void Save(string fileName)
    {
        String file = @$"{fileName}";
        StringBuilder goals = new StringBuilder();
        goals.AppendLine(_totalPoints.ToString());
        foreach (KeyValuePair<int, Goal> goal in _goalDict)
        {
            String newLine;
            if (goal.Value._type == GoalTypes.ChecklistGoal){
                var checklistGoal = (ChecklistGoal) goal.Value;
                newLine = $"{checklistGoal._type}|{checklistGoal._goalTitle}|{checklistGoal._goalDescription}|{checklistGoal._pointsForGoal}|{checklistGoal._goalIsAchieved}|{checklistGoal._bonusPoints}|{checklistGoal._timesToComplete}|{checklistGoal._timesCompleted}";
            }
            else{
                newLine = $"{goal.Value._type}|{goal.Value._goalTitle}|{goal.Value._goalDescription}|{goal.Value._pointsForGoal}|{goal.Value._goalIsAchieved}";
            }
            
            
            goals.AppendLine(newLine);
        }

        try
        {
            File.WriteAllText(file, goals.ToString());
            Console.WriteLine($"Goals saved to {file}");
        }
        catch (Exception)
        {
            Console.WriteLine("Data could not be written to the file.");
            return;
        }
}

    public void Load(string file){
        int type = 0;
        int title = 1;
        int description = 2;
        int pointsForGoal = 3;
        int goalIsAcheived = 4;
        int bonusPoints = 5;
        int timesToComplete = 6;
        int timesCompleted = 7;
        _goalDict = new Dictionary<int, Goal>();
        using(var reader = new StreamReader(@$"{file}"))
        {
            _totalPoints = int.Parse(reader.ReadLine());
            while ((!reader.EndOfStream)) {
            var values = reader.ReadLine().Split('|');
            
            if (values[type] == GoalTypes.ChecklistGoal.ToString())
            {
                _goalDict.Add(GetGoalListIncrementNumber(),new ChecklistGoal(values[title], values[description], int.Parse(values[pointsForGoal]),int.Parse(values[timesToComplete]),int.Parse(values[timesCompleted]),int.Parse(values[bonusPoints]),bool.Parse(values[goalIsAcheived])));
            }
            else if (values[type] == GoalTypes.EternalGoal.ToString()){
                _goalDict.Add(GetGoalListIncrementNumber(),new EternalGoal(values[title], values[description], int.Parse(values[pointsForGoal]),bool.Parse(values[goalIsAcheived])));
            }
            else if (values[type] == GoalTypes.SimpleGoal.ToString()){
                _goalDict.Add(GetGoalListIncrementNumber(),new Goal(values[title], values[description], int.Parse(values[pointsForGoal]),bool.Parse(values[goalIsAcheived])));
            }
            }
        }
    } 
}
