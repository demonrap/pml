using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PmlMvc.Models
{
    public class PmContext : DbContext
    {
        static PmContext()
        {
            //non modifico lo schema del database
            Database.SetInitializer<PmContext>(null);
        }

        public PmContext() 
            : base(nameOrConnectionString: "DefaultConnection")
        {
        }

        public virtual DbSet<ap_marchi> ap_marchi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}