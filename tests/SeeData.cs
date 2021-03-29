using FundingSchedule.FundExpenses;

namespace FundingSchedule.Test
{
    public static class SeedData
    {
        public static void PopulateTestData(DataContext dbContext)
        {
            dbContext.SaveChanges();
        }
    }

}