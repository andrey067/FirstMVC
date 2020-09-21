using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Services
{
    public class DepartmentService
    {
        private readonly WebApplication1Context _context;


        public DepartmentService(WebApplication1Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() 
        {
            return await _context.Departments.OrderBy(x => x.Name).ToListAsync();

        }


    }
}
