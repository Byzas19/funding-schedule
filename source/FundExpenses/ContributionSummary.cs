using System;
using System.Collections.Generic;
using System.Linq;

namespace FundingSchedule.FundExpenses
{

    public class ContributionSummary {

        public string ScheduleName { get; set;}

        public DateTime Date { get; set;}

        public IDictionary<string, decimal> Expenses { get; set;}

        public IDictionary<string, decimal> Goals { get; set; }

        public decimal UpdatedSafeToSpend {get; set;}

        public decimal TotalContribution(){
            return Expenses.Values.Sum();
        }        

    }


}