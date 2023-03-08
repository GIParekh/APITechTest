using APITechTest.DataModel;
using Microsoft.EntityFrameworkCore;

namespace APITechTest.DatabaseContext
{
    public class MyDatabaseContext: DbContext
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "APITechTestDB");
        }

        public DbSet<CompanyDataModel> Companies { get; set; }
        public DbSet<ClaimDataModel> Claims { get; set; }
        public DbSet<ClaimTypeDataModel> ClaimTypes { get; set; }
    }
}
