
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class StudentContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public StudentContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringg = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");
            if (connectionStringg == null)
            {
                throw new InvalidOperationException("Connection string not found");
            }
            optionsBuilder.UseSqlServer(connectionStringg);
        }
    }
}