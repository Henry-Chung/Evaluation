using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HenryChung.BudgetTracker.Infrastructure.Services
{
    public class UsersService:IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        public async Task<Users> AddUser(Users user)
        {
            return await _usersRepository.AddAsync(user);
        }

        public async Task<Users> UpdateUser(Users user)
        {

            return await _usersRepository.UpdateAsync(user);
        }

        public async Task DeleteUser(Users user)
        {

            await _usersRepository.DeleteAsync(user);
        }

        public async Task<IEnumerable<Users>> ListAllUsers()
        {
            var users = await _usersRepository.ListAllAsync();
            return users;
        }

        public async Task<Users> GetUserDetails(int id)
        {
            var user = await _usersRepository.GetByIdAsync(id);
            return user;
        }
    }
}
