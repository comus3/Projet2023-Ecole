//!!!EXEMPLE!!!
// NE PAS TOuCHER
// Table1Repository.cs
using schoolManager.Models; // Import your entity model

namespace schoolManager.DAL.Repositories
{
    public class Table1Repository : BaseRepository<Table1Entity>
    {
        public Table1Repository(DatabaseContext context) : base(context)
        {
        }

        // Add specific methods for Table1 if needed
    }
}
