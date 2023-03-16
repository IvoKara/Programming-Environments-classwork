using System.Text;
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
            + activity + '\n';
        currentSessionActivities.Add(activityLine);

        if (File.Exists(file))
        {
            File.AppendAllText(file, activityLine + '\n');
        }
    }

    public static void GetCurrentSessionActivities()
    {
        StringBuilder sb = new StringBuilder();
        foreach (string activity in currentSessionActivities)
        {
            sb.Append(activity);
        }
        Console.WriteLine(sb);
    }

    public static void DisplayLogFromFile()
    {
        using (StreamReader sr = new StreamReader(file))
        {
            StringBuilder fullLog = new StringBuilder();

            while (!sr.EndOfStream)
            {
                fullLog.Append(sr.ReadLine() + '\n');
            }

            Console.WriteLine(fullLog);
        }
    }
}
