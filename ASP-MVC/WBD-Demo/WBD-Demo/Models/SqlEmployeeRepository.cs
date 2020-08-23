using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private AppDbContext context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public bool Delete(int ID)
        {
            var delEmployee = context.Employees.Find(ID);
            if(delEmployee != null)
            {
                context.Employees.Remove(delEmployee);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmployee = context.Employees.Attach(employee);
            editEmployee.State = EntityState.Modified;
            context.SaveChanges();
            return employee;
        }

        public Employee Get(int ID)
        {
            return context.Employees.Find(ID);
        }

        public IEnumerable<Employee> Gets()
        {
            return context.Employees;
        }
    }
}
