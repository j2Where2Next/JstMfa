using JwtMfaExample.Models;
using System.Threading.Tasks;

namespace JwtMfaExample.Services;

public class UserService
{    
    public Task<User?> Authenticate(string username, string password)
    {
        // Implement your user authentication logic here
        // For example, check username and password against a database
        if (username == "testuser" && password == "password")
        {
            return Task.FromResult<User?>(new User { Username = username });
        }
        return Task.FromResult<User?>(null);
    }
}
