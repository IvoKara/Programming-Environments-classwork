namespace work
{
    public class LoginValidaton
    {
        private string? userName;
        private string? password;
        public List<string> Errors { get; private set; }

        public static UserRoles currentUserRole { get; private set; }

        public LoginValidaton(string? userName, string? password)
        {
            this.userName = userName;
            this.password = password;
            this.Errors = new List<string>();
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
                Errors.Clear();
                Errors.Add("Не съществува такъв потребител");
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
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
                    Errors.Add("Не е посочено потребителско име");

                if (isPasswordEmpty)
                    Errors.Add("Не е посоченa парола");

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
                    Errors.Add($"Потербителското име трябва да бъде над {number} символа");

                if (isPasswordUnder)
                    Errors.Add($"Паролата трябва да бъде над {number} символа");

                return true;
            }

        }
    }
}