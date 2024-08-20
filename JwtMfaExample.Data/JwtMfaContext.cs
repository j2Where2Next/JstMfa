using Microsoft.EntityFrameworkCore;
using JwtMfaExample.Models;

namespace JwtMfaExample.Data;

public class JwtMfaContext : DbContext
{
    public JwtMfaContext(DbContextOptions<JwtMfaContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MfaToken> MfaTokens { get; set; }
}
