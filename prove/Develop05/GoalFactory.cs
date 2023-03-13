public class GoalFactory
{
    public Goal CreateGoal(string type)
    {
        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal();
            case "EternalGoal":
                return new EternalGoal();
            case "CheckListGoal":
                return new CheckListGoal();
        }
    }
    
}