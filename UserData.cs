namespace work
{
    public static class UserData
    {
        private static User? _testUser;
        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser!;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User();
                _testUser.userName = "ivok";
                _testUser.password = "pa$$";
                _testUser.facultyNumber = "121220065";
                _testUser.role = 1;
            }
        }
    }
}