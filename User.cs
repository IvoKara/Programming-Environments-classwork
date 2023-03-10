namespace work
{
    public class User
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FacultyNumber { get; set; }
        public int Role { get; set; }

        public User() { }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Role = (int)UserRoles.ANONYMOUS;
        }

        public User(string userName, string password, int role)
        : this(userName, password)
        {
            Role = role;
        }

        public User(string userName, string password, string facultyNumber, int role)
        : this(userName, password, role)
        {
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return $"username: {UserName}\n" +
                $"password: {Password}\n" +
                (FacultyNumber != null ? $"faculty number: {FacultyNumber}\n" : "") +
                $"role id: {Role}";
        }

    }
}