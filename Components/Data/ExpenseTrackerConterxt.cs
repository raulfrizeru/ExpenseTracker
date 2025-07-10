using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Components.Data
{
    public class ExpenseTrackerContext : DbContext
    {
        public ExpanseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options)
        {
        }
    }
}
