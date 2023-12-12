//classe mere qui va communiquer avec db
// confer le model de mr nguyen en js (meme idee)

// OBSELETE
//
// This is the old version (at least what we started)
// the app now is implemented using json instead of 
// sql for facility but the code is here for potential
// future implementation

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace schoolManager.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Table1Entity> Table1Entities { get; set; }
        public DbSet<Table2Entity> Table2Entities { get; set; }
        // Add DbSet properties for other tables as needed

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost;Initial Catalog=YourDatabase;Integrated Security=True";
            optionsBuilder.UseSqlite(connectionString); // Adjust this based on your database provider
        }
    }
}
