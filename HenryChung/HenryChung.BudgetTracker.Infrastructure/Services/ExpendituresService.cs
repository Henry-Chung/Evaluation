using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Infrastructure.Services
{
    public class ExpendituresService:IExpendituresService
    {
        private readonly IExpendituresRepository _expendituresRepository;
        public ExpendituresService(IExpendituresRepository expendituresRepository)
        {
            _expendituresRepository = expendituresRepository;
        }


        public async Task<Expenditures> AddExpenditure(Expenditures expenditure)
        {
            return await _expendituresRepository.AddAsync(expenditure);
        }

        public async Task<Expenditures> UpdateExpenditure(Expenditures expenditure)
        {

            return await _expendituresRepository.UpdateAsync(expenditure);
        }

        public async Task DeleteExpenditure(Expenditures expenditure)
        {

            await _expendituresRepository.DeleteAsync(expenditure);
        }

        public async Task<IEnumerable<Expenditures>> ListAllExpenditures()
        {
            var expenditures = await _expendituresRepository.ListAllAsync();
            return expenditures;
        }
    }
}
