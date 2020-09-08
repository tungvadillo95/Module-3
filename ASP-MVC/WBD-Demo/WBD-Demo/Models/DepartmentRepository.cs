using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context;

        public DepartmentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> Gets()
        {
            return context.Departments;
        }
    }
}
