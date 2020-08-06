using HenryChung.BudgetTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Core.ServiceInterfaces
{
    public interface IUsersService
    {
        Task<Users> AddUser(Users user);
        Task<Users> UpdateUser(Users user);
        Task DeleteUser(Users user);
        Task<IEnumerable<Users>> ListAllUsers();
    }
}
