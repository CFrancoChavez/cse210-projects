public static class Menu{
    private const string _menuHeader = "Menu Options:";

    private const string _menuFooter = "Select a choice from the menu: ";

    private const string _goalMenuHeader = "The types of goals are:";

    private const string _goalMenuFooter = "Which type of goal would you like to create?";

    

    private static readonly Dictionary<int, string> _menuOptions = new Dictionary<int, string>(){
        {1, "Create New Goal" },
        {2, "List Goals"},
        {3, "Save Goals"},
        {4, "Load Goals"},
        {5, "Record Event"},
        {6, "Quit"}
    };

    private static readonly Dictionary<int, string> _goalMenuOptions = new Dictionary<int, string>(){
        {1, "Simple Goal" },
        {2, "Eternal Goal"},
        {3, "Checklist Goal"}
    };

    public static string GetInput(bool isGoalMenu = false)
    {
        Console.WriteLine(isGoalMenu ? _goalMenuHeader : _menuHeader);

        var options = isGoalMenu ? _goalMenuOptions : _menuOptions;

        foreach (var option in options)
        {
            Console.WriteLine($"{option.Key}. {option.Value}");
        }

        Console.Write(_menuFooter);

        return Console.ReadLine();
    }
}