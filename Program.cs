namespace classwork;
class Program
{
    static void Main(string[] args)
    {
        LoginValidaton loginValidation = new LoginValidaton();

        if (loginValidation.ValidateUserInput())
        {
            Console.WriteLine(UserData.TestUser);
            Console.WriteLine(LoginValidaton.currentUserRole);
        }

    }
}