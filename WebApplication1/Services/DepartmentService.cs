using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Services
{
    public class DepartmentService
    {
        private readonly WebApplication1Context _context;


        public DepartmentService(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Department> FindAll() 
        {
            return _context.Departments.OrderBy(x => x.Name).ToList();

        }


    }
}
