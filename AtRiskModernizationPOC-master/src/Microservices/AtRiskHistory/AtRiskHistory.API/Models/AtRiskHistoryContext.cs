using Microsoft.EntityFrameworkCore;
using AtRiskHistory.Models.ModelConfigurations;


namespace AtRiskHistory.Models
{
    public class AtRiskHistoryContext : DbContext
    {

        public AtRiskHistoryContext(DbContextOptions<AtRiskHistoryContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
         => modelBuilder.ApplyConfiguration(new TodoConfiguration());

        public DbSet<AtRiskHistory> AtRiskHistory { get; set; }
    }
}
