using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenryChung.BudgetTracker.Infrastructure.Repositories
{
    public class ExpendituresRepository: EfRepository<Expenditures>, IExpendituresRepository
    {
        public ExpendituresRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
