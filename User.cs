namespace work
{
    public class User
    {
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? facultyNumber { get; set; }
        public int role { get; set; }

        public override string ToString()
        {
            return $"username: {userName}\n" +
                $"password: {password}\n" +
                $"faculty number: {facultyNumber}\n" +
                $"role id: {role}\n ";
        }
    }
}