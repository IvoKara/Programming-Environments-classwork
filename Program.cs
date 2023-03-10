namespace work;
class Program
{
    static void Main(string[] args)
    {
        string userName = Console.ReadLine() ?? "";
        string password = Console.ReadLine() ?? "";


        LoginValidaton loginValidation = new LoginValidaton(userName, password);

        User? emptyUser = null;

        if (loginValidation.ValidateUserInput(ref emptyUser))
        {
            Console.WriteLine(emptyUser?.ToString() ?? "user is Null");
            Console.WriteLine(LoginValidaton.currentUserRole);
        }
        else
        {
            foreach (var error in loginValidation.Errors)
            {

                Console.WriteLine(error);
            }
        }

    }
}