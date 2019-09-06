using Microsoft.EntityFrameworkCore;

namespace REST_API_TESTE_3.Model.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext()
        {

        }

        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }

    }
}
