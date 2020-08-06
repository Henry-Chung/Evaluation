using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HenryChung.BudgetTracker.MVC.Models;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using HenryChung.BudgetTracker.Core.Entities;

namespace HenryChung.BudgetTracker.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService _usersService;
        private readonly IExpendituresService _expendService;
        private readonly IIncomesService _incomesService;
        public HomeController(IUsersService usersService, IExpendituresService expendService, IIncomesService incomesService)
        {
            _usersService = usersService;
            _expendService = expendService;
            _incomesService = incomesService;
        }

        public async Task<IActionResult> Index()
        {
            Users user = new Users()
            {
                Id = 2,
                Fullname= "Javon Goodwin",
                Email = "Pablo_Bruen@yahoo.com",
                Password = "123"
            };
            //var users = await _usersService.ListAllUsers();
            await _usersService.UpdateUser(user);
            //await _usersService.DeleteUser(user);
            //var expend = await _expendService.();
            //var incomes = await _incomesService.ListAllUsers();
            return View();
        }

            //private readonly ILogger<HomeController> _logger;

            //public HomeController(ILogger<HomeController> logger)
            //{
            //    _logger = logger;
            //}

            //public IActionResult Index()
            //{
            //    return View();
            //}

            //public IActionResult Privacy()
            //{
            //    return View();
            //}

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
