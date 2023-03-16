namespace classwork;

public class LoginValidation
{
    private string? userName;
    private string? password;
    public List<string> Errors { get; private set; }

    public static UserRoles currentUserRole { get; private set; }
    public static string? currentUserUserName { get; private set; }

    public delegate void ActionOnError(string errorMsg);
    private ActionOnError errorAction;

    public LoginValidation(string? userName, string? password)
    {
        this.userName = userName;
        this.password = password;
        this.Errors = new List<string>();
    }

    public LoginValidation(string? userName, string? password, ActionOnError errorAction)
    : this(userName, password)
    {
        this.errorAction = new ActionOnError(errorAction);
    }

    public bool ValidateUserInput(ref User? user)
    {
        currentUserRole = UserRoles.ANONYMOUS;
        bool emptyCheck = AreCredentialsNullOrEmpty();
        bool lengthCheck = AreCredentialsUnderChars(5);

        if (emptyCheck || lengthCheck)
            return false;

        user = UserData.IsUserPassCorrect(userName, password);

        if (user == null)
        {
            // Errors.Clear();
            // Errors.Add("Не съществува такъв потребител");
            errorAction("Не съществува такъв потребител");
            return false;
        }

        currentUserRole = (UserRoles)user.Role;
        currentUserUserName = user.UserName;

        Logger.LogActivity("Успешен Login");
        return true;
    }

    private bool AreCredentialsNullOrEmpty()
    {
        bool isUsernameEmpty = String.IsNullOrEmpty(userName);
        bool isPasswordEmpty = String.IsNullOrEmpty(password);

        if (!isUsernameEmpty && !isPasswordEmpty)
        {
            return false;
        }
        else
        {
            if (isUsernameEmpty)
                errorAction("Не е посочено потребителско име");
            // Errors.Add("Не е посочено потребителско име");

            if (isPasswordEmpty)
                errorAction("Не е посоченa парола");
            // Errors.Add("Не е посоченa парола");

            return true;
        }
    }

    private bool AreCredentialsUnderChars(int number)
    {
        bool isUsernameUnder = 0 < userName.Count() && userName.Count() < number;
        bool isPasswordUnder = 0 < password.Count() && password.Count() < number;

        if (!isUsernameUnder && !isPasswordUnder)
        {
            return false;
        }
        else
        {
            if (isUsernameUnder)
                errorAction($"Потербителското име трябва да бъде над {number} символа");
            // Errors.Add($"Потербителското име трябва да бъде над {number} символа");

            if (isPasswordUnder)
                errorAction($"Паролата трябва да бъде над {number} символа");
            // Errors.Add($"Паролата трябва да бъде над {number} символа");

            return true;
        }

    }
}
