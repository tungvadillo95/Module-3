using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using WBD_Demo.ViewModels;

namespace WBD_Demo.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private AppDbContext context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public CreateEmployeeViewModel Create(CreateEmployeeViewModel employee)
        {
            var newEmp = new Employee()
            {
                Avatarpath = employee.Avatarpath,
                DepartmentId = employee.DepartmentId,
                Email = employee.Email,
                Name = employee.Name
            };
            context.Employees.Add(newEmp);
            context.SaveChanges();
            if (employee.Languages != null)
            {
                var empList = new List<EmployeeLanguage>();
                empList = employee.Languages.Select(l => new EmployeeLanguage()
                {
                    LanguageId = l,
                    EmployeeId = newEmp.ID
                }).ToList();
                context.EmployeeLanguages.AddRange(empList);
                context.SaveChanges();
            }
            employee.EmployeeId = newEmp.ID;
            return employee;
        }

        public bool Delete(int ID)
        {

            var delEmployee = context.Employees.Find(ID);
            if (delEmployee != null)
            {
                var elList = (from el in context.EmployeeLanguages
                              where el.EmployeeId == delEmployee.ID
                              select el).ToList();
                context.EmployeeLanguages.RemoveRange(elList);
                context.SaveChanges();

                context.Employees.Remove(delEmployee);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public EditEmployeeViewModel Edit(EditEmployeeViewModel employee)
        {
            //1. delete all current language selected
            var elList = (from el in context.EmployeeLanguages
                          where el.EmployeeId == employee.EmployeeId
                          select el).ToList();
            context.EmployeeLanguages.RemoveRange(elList);
            context.SaveChanges();
            //2. add new
            if (employee.Languages != null)
            {
                var empList = new List<EmployeeLanguage>();
                empList = employee.Languages.Select(l => new EmployeeLanguage()
                {
                    LanguageId = l,
                    EmployeeId = employee.EmployeeId
                }).ToList();
                context.EmployeeLanguages.AddRange(empList);
                context.SaveChanges();
            }
            //3.update database
            var editEmployee = context.Employees.Attach(new Employee()
            {
                Avatarpath = employee.Avatarpath,
                DepartmentId = employee.DepartmentId,
                Email = employee.Email,
                ID = employee.EmployeeId,
                Name = employee.Name
            });
            editEmployee.State = EntityState.Modified;
            context.SaveChanges();
            return employee;
        }

        public EmployeeDetailViewModel Get(int ID)
        {
            var data = (from e in context.Employees
                        join d in context.Departments
                        on e.DepartmentId equals d.DepartmentId
                        where e.ID == ID
                        select new EmployeeDetailViewModel()
                        {
                            ID = e.ID,
                            DepartmentId = d.DepartmentId,
                            Avatarpath = e.Avatarpath,
                            DepartmentName = d.DepartmentName,
                            Email = e.Email,
                            Name = e.Name
                        }).FirstOrDefault();
            var laguages = (from lg in context.Languages
                            join el in context.EmployeeLanguages
                            on lg.LanguageId equals el.LanguageId
                            where el.EmployeeId == data.ID
                            select lg).ToList();
            data.Languages = laguages;
            //data.Languages = laguages != null ? string.Join(", ", laguages.Select(d=>d.LanguageName)) : string.Empty;
            return data;
        }

        public IEnumerable<Employee> Gets()
        {
            return context.Employees;
        }
    }
}
