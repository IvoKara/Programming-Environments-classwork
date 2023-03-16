namespace work;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("username: ");
        string userName = Console.ReadLine() ?? "";
        Console.Write("password: ");
        string password = Console.ReadLine() ?? "";


        LoginValidation loginValidation = new LoginValidation(userName, password, (msg) => Console.WriteLine(msg));

        User? user = null;

        if (loginValidation.ValidateUserInput(ref user))
        {
            Console.WriteLine(user);
            Console.WriteLine("Current role: {0}", LoginValidation.currentUserRole);

            if ((UserRoles)user!.Role == UserRoles.ADMIN)
            {
                OpenAdminMenu();
            }

        }
        // else
        // {
        //     foreach (var error in loginValidation.Errors)
        //     {
        //         Console.WriteLine(error);
        //     }
        // }
    }

    static void OpenAdminMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n0: Exit");
            Console.WriteLine("1: Change user's role");
            Console.WriteLine("2: Change user's ative to time");

            Console.Write("\nChoose an option: ");
            option = Int32.Parse(Console.ReadLine() ?? "-1");

            switch (option)
            {
                case 0:
                    break;

                case 1:
                    {
                        Console.Write("\nEnter usrename: ");
                        string userName = Console.ReadLine() ?? "";

                        User? user = UserData.findUserByUserName(userName);

                        if (user == null)
                        {
                            Console.WriteLine("No such user.");
                            option = Math.Abs(option) * -1;
                            break;
                        }

                        int newRole = user.Role;
                        var avilableRoles = Enum.GetValues(typeof(UserRoles)).Cast<UserRoles>().ToArray();
                        do
                        {

                            Console.WriteLine();

                            for (int i = 0; i < avilableRoles.Count(); i++)
                            {
                                Console.WriteLine($"{i}: {avilableRoles[i]}");
                            }
                            Console.Write("\nEnter new role: ");

                            newRole = Int32.Parse(Console.ReadLine() ?? "-1");

                            if (newRole < 0 || newRole > avilableRoles.Count())
                            {
                                Console.WriteLine("Enter role id in the given range.");
                            }
                            else
                                break;

                        } while (true);


                        UserData.AssignUserRole(ref user, (UserRoles)newRole);
                    }
                    break;

                case 2:
                    {
                        Console.Write("\nEnter usrename: ");
                        string userName = Console.ReadLine() ?? "";

                        User? user = UserData.findUserByUserName(userName);

                        if (user == null)
                        {
                            Console.WriteLine("No such user.");
                            option = Math.Abs(option) * -1;
                            break;
                        }

                        DateTime newDate = user.ValidUntil;
                        bool validFormat;
                        do
                        {
                            Console.Write("New DateTime string: ");
                            try
                            {
                                newDate = DateTime.Parse(Console.ReadLine() ?? "");
                                validFormat = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Format not valid.");
                                validFormat = false;
                            }

                        } while (!validFormat);

                        UserData.SetUserActiveTo(ref user, newDate);
                        Console.WriteLine(user);
                    }
                    break;

                default:
                    Console.WriteLine("\nPlease, enter a valid number.");
                    option = Math.Abs(option) * -1;
                    break;
            }

        } while (option < 0);
    }

    static bool FindToEditUser()
    {
        Console.Write("\nEnter usrename: ");
        string userName = Console.ReadLine() ?? "";

        User? user = UserData.findUserByUserName(userName);

        if (user == null)
        {
            Console.WriteLine("No such user.");
            return false;
        }

        return true;
    }
}