namespace work
{
    public static class UserData
    {
        private static List<User> _testUsers = new List<User>();
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            if (_testUsers.Count == 0)
            {
                _testUsers.Add(new User("admin", "admin", (int)UserRoles.ADMIN));
                _testUsers.Add(new User("pesho", "pesho", "121220434", (int)UserRoles.STUDENT));
                _testUsers.Add(new User("sasho", "sasho", "121220543", (int)UserRoles.STUDENT));
            }
        }

        public static User? IsUserPassCorrect(string userName, string password)
        {
            foreach (User testUser in TestUsers)
            {
                if (
                    testUser.UserName == userName &&
                    testUser.Password == password
                )
                { return testUser; }
            }

            return null;
        }
    }
}