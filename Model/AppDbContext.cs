using Microsoft.EntityFrameworkCore;

namespace Sessions_app.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brinquedo> Brinquedos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brinquedo>().ToTable("TDS_TB_BRINQUEDOS"); // Nome da tabela
        }
    }
}
