using HenryChung.BudgetTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Core.ServiceInterfaces
{
    public interface IIncomesService
    {
        Task<Incomes> AddIncome(Incomes income);
        Task<Incomes> UpdateIncome(Incomes income);
        Task DeleteIncome(Incomes income);
        Task<IEnumerable<Incomes>> ListAllIncomes();
    }
}
