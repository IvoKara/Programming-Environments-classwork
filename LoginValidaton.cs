namespace work
{
    public class LoginValidaton
    {
        public static UserRoles currentUserRole { get; private set; }
        public bool ValidateUserInput()
        {
            currentUserRole = UserRoles.ADMIN;
            return true;
        }
    }
}