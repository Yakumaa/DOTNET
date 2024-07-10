using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    public class OfficerContext : DbContext
    {
        public OfficerContext(DbContextOptions<OfficerContext> options) : base(options) { }

        public DbSet<Officer> tbl_officer { get; set; } // This is the table name i.e tbl_officer
    }
}
