using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Infrastructure.Repositories
{
    public class UsersRepository : EfRepository<Users>, IUsersRepository
    {
        public UsersRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Users> GetByIdAsync(int id)
        {
            var movies = await _dbContext.Users
            .Where(u => u.Id == id)
            .Include(u => u.Incomes)
            .Include(u => u.Expenditures)
            .FirstAsync();

            //_dbContext.Reviews.Where(r => r.MovieId == id).Load();
            //_dbContext.Purchases.Where(p => p.MovieId == id).Load();
            //_dbContext.Favorites.Where(p => p.MovieId == id).Load();
            //movies.Rating = movies.Reviews.Average(r => r.Rating);

            return movies;
        }
    }
}
