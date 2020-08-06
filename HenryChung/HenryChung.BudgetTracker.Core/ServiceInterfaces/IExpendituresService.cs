using HenryChung.BudgetTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Core.ServiceInterfaces
{
    public interface IExpendituresService
    {
        Task<Expenditures> AddExpenditure(Expenditures expenditure);
        Task<Expenditures> UpdateExpenditure(Expenditures expenditure);
        Task DeleteExpenditure(Expenditures expenditure);
        Task<IEnumerable<Expenditures>> ListAllExpenditures();
    }
}
