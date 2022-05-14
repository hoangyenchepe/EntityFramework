using System.Data.Entity;

namespace EntityFrameworkLearn.Model
{
    class tmDBContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
    }
}
