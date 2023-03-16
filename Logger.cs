namespace work;

public static class Logger
{
    private static List<string> currentSessionActivities = new List<string>();

    private static string file = "test.txt";

    public static void LogActivity(string activity)
    {
        string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUserName + ";"
            + LoginValidation.currentUserRole + ";"
            + activity;
        currentSessionActivities.Add(activityLine);

        if (File.Exists(file))
        {
            File.AppendAllText(file, activityLine + '\n');
        }
    }

    public static void DisplayLogFromFile()
    {
        using (StreamReader sr = new StreamReader(file))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
