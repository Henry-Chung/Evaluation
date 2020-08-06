using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Infrastructure.Services
{
    public class IncomesService:IIncomesService
    {
        private readonly IIncomesRepository _incomesRepository;
        public IncomesService(IIncomesRepository incomesRepository)
        {
            _incomesRepository = incomesRepository;
        }


        public async Task<Incomes> AddIncome(Incomes income)
        {
            return await _incomesRepository.AddAsync(income);
        }

        public async Task<Incomes> UpdateIncome(Incomes income)
        {

            return await _incomesRepository.UpdateAsync(income);
        }

        public async Task DeleteIncome(Incomes income)
        {

            await _incomesRepository.DeleteAsync(income);
        }

        public async Task<IEnumerable<Incomes>> ListAllIncomes()
        {
            var incomes = await _incomesRepository.ListAllAsync();
            return incomes;
        }
    }
}
