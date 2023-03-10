namespace work
{
    public class LoginValidaton
    {
        private string? userName;
        private string? password;
        public string? error;

        public static UserRoles currentUserRole { get; private set; }

        public LoginValidaton(string? userName, string? password)
        {
            this.password = password;
            this.userName = userName;
        }

        public bool ValidateUserInput(ref User? user)
        {
            bool isUsernameEmpty = String.IsNullOrEmpty(userName);
            bool isPasswordEmpty = String.IsNullOrEmpty(password);

            if (isUsernameEmpty && isPasswordEmpty)
            {
                error = "Не са посочени потербителско име и парола";
            }
            else
            {
                if (isUsernameEmpty)
                    error = "Не е посочено потребителско име";

                if (isPasswordEmpty)
                    error = "Не е посоченa парола";
            }

            if (isUsernameEmpty || isPasswordEmpty)
                return false;

            User testUser = UserData.TestUser;
            if (
                this.password == testUser.password &&
                this.userName == testUser.userName
            )
            {
                user = UserData.TestUser;
                currentUserRole = (UserRoles)user.role;
            }

            return true;
        }
    }
}