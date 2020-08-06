using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HenryChung.BudgetTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpendituresController : ControllerBase
    {
        private readonly IExpendituresService _expendituresService;

        public ExpendituresController(IExpendituresService expendituresService)
        {
            _expendituresService = expendituresService;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllExpenditures()
        {
            var expenditures = await _expendituresService.ListAllExpenditures();
            return Ok(expenditures);
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddExpenditure([FromBody] Expenditures expenditure)
        {
            await _expendituresService.AddExpenditure(expenditure);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateExpenditure([FromBody] Expenditures expenditure)
        {
            await _expendituresService.UpdateExpenditure(expenditure);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<ActionResult> DeleteExpenditure([FromBody] Expenditures expenditure)
        {
            await _expendituresService.DeleteExpenditure(expenditure);
            return Ok();
        }
    }
}
