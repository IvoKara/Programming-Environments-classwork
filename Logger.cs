using System.Text;

namespace classwork;

public static class Logger
{
    private static List<string> currentSessionActivities = new List<string>();

    private static string file = "test.txt";

    public static void LogActivity(string activity)
    {
        string activityLine = DateTime.Now + ";"
            + LoginValidation.currentUserUserName + ";"
            + LoginValidation.currentUserRole + ";"
            + activity + '\n';
        currentSessionActivities.Add(activityLine);

        if (!File.Exists(file))
        {
            File.Create(file);
        }
        File.AppendAllText(file, activityLine);
    }

    public static IEnumerable<string> GetCurrentSessionActivities()
    {
        return currentSessionActivities;
    }

    public static IEnumerable<string> DisplayLogFromFile()
    {
        List<string> logs = new List<string>();

        using (StreamReader sr = new StreamReader(file))
        {
            while (!sr.EndOfStream)
            {
                logs.Add(sr.ReadLine() + '\n');
            }
        }

        return logs;
    }
}
