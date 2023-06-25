using Emp_BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_BAL.Interfaces
{
    public interface IEmployee
    {
        public List<Employee> GetEmployes();
        public string InsertEmployes(Employee employe);

        public bool ValidateEmail(string email);
    }
}
