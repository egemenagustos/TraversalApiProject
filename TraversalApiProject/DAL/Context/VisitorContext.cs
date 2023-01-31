using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entity;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EGEMEN\\SQLEXPRESS; initial catalog=TraversalDbApi; integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
