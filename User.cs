namespace upr1
{
    public class User
    {
        public string? userName;
        public string? password;
        public string? facultyNumber;
        public int? role;

        public override string ToString()
        {
            return $"username: {userName}\n" +
                $"password: {password}\n" +
                $"faculty number: {facultyNumber}\n" +
                $"role id: {role}\n ";
        }
    }
}