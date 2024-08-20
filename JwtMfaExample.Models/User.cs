namespace JwtMfaExample.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
}

public class MfaToken
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expiry { get; set; }
    // Additional properties...
}

public class JwtToken
{
    public string Token { get; set; }
    public DateTime Expiry { get; set; }
    // Additional properties...
}