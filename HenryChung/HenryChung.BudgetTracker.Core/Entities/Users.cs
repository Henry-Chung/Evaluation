using System;
using System.Collections.Generic;
using System.Text;

namespace HenryChung.BudgetTracker.Core.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public DateTime? JoinedOn { get; set; }

        public ICollection<Incomes> Incomes { get; set; }
        public ICollection<Expenditures> Expenditures { get; set; }

    }
}
