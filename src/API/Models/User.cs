namespace API.Models;

public class User
{
    public User(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }

    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }
}