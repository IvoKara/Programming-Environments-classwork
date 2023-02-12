namespace upr1;
class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.userName = "ivok";
        user.password = "pa$$";
        user.facultyNumber = "121220065";
        user.role = 1;

        Console.WriteLine(user);
    }
}