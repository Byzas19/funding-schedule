using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FundingSchedule.FundExpenses
{
    [ApiController]
    [Route("[controller]")]
    public class FundExpensesController : ControllerBase
    {
        private readonly ILogger<FundExpensesController> _logger;

        public FundExpensesController(ILogger<FundExpensesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ContributionSummary Post()
        {
           var summary = new ContributionSummary();
           _logger.LogDebug(JsonSerializer.Serialize(summary));
           return summary;
        }
    }
}
