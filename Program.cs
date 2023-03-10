namespace work;
class Program
{
    static void Main(string[] args)
    {
        string userName = Console.ReadLine() ?? "";
        string password = Console.ReadLine() ?? "";


        LoginValidaton loginValidation = new LoginValidaton(userName, password, (msg) => Console.WriteLine(msg));

        User? user = null;

        if (loginValidation.ValidateUserInput(ref user))
        {
            Console.WriteLine(user);
        }
        // else
        // {
        //     foreach (var error in loginValidation.Errors)
        //     {
        //         Console.WriteLine(error);
        //     }
        // }

        Console.WriteLine("Current role: {0}", LoginValidaton.currentUserRole);

    }
}