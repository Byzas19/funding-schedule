using Microsoft.EntityFrameworkCore;

namespace FundingSchedule.FundExpenses
{

    public class DataContext: DbContext {


        public DbSet<Expense> Expenses { get; set; }

        
    }


}