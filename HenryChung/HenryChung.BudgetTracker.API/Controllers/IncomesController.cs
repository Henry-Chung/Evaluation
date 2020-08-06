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
    public class IncomesController : ControllerBase
    {
        private readonly IIncomesService _incomesService;

        public IncomesController(IIncomesService incomesService)
        {
            _incomesService = incomesService;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllIncomes()
        {
            var incomes = await _incomesService.ListAllIncomes();
            return Ok(incomes);
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddIncome([FromBody] Incomes income)
        {
            await _incomesService.AddIncome(income);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateIncome([FromBody] Incomes income)
        {
            await _incomesService.UpdateIncome(income);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<ActionResult> DeleteIncome([FromBody] Incomes income)
        {
            await _incomesService.DeleteIncome(income);
            return Ok();
        }
    }
}
