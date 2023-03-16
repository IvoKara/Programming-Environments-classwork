namespace work;

public static class Logger
{
    private static List<string> currentSessionActivities = new List<string>();


    public static void LogActivity(string activity)
    {
        string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUserName + ";"
            + LoginValidation.currentUserRole + ";"
            + activity;
        currentSessionActivities.Add(activityLine);
    }
}
