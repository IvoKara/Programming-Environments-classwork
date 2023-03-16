namespace work;

public class User
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? FacultyNumber { get; set; }
    public int Role { get; set; }
    public DateTime CreatedAt { get; private set; }

    public DateTime ValidUntil { get; set; }

    public User() { }

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
        Role = (int)UserRoles.ANONYMOUS;
        CreatedAt = DateTime.Now;
    }

    public User(string userName, string password, int role, DateTime? validUnitl = null)
    : this(userName, password)
    {
        Role = role;
        ValidUntil = validUnitl ?? DateTime.MaxValue;
    }

    public User(string userName, string password, string facultyNumber, int role, DateTime? validUnitl = null)
    : this(userName, password, role, validUnitl)
    {
        FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        return $"username: {UserName}\n" +
            $"password: {Password}\n" +
            (FacultyNumber != null ? $"faculty number: {FacultyNumber}\n" : "") +
            $"role id: {Role}\n" +
            $"created at: {CreatedAt}\n" +
            $"valid until: {ValidUntil}";
    }
}
