namespace work
{
    public class LoginValidaton
    {
        private string? userName;
        private string? password;
        private string? error;

        public static UserRoles currentUserRole { get; private set; }

        public LoginValidaton(string? userName, string? password)
        {
            this.password = password;
            this.userName = userName;
        }

        public bool ValidateUserInput(ref User? user)
        {
            currentUserRole = UserRoles.ADMIN;

            User testUser = UserData.TestUser;
            if (
                this.password == testUser.password &&
                this.userName == testUser.userName
            )
            {
                user = UserData.TestUser;
            }

            return true;
        }
    }
}