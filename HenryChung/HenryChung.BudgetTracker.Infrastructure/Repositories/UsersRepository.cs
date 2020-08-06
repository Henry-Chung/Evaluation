using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenryChung.BudgetTracker.Infrastructure.Repositories
{
    public class UsersRepository : EfRepository<Users>, IUsersRepository
    {
        public UsersRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
