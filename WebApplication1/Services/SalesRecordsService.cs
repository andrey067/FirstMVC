﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Services
{
    public class SalesRecordsService 
    {
        private readonly WebApplication1Context _context;
        public SalesRecordsService(WebApplication1Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)  
        {
            var result =  from obj in _context.SalesRecord select obj;
            if (minDate.HasValue) 
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue) 
            {
                result = result.Where(x => x.Date <= minDate.Value);
            }
            return await result
                .Include(x=> x.Seller)
                .Include(x=> x.Seller.Department)
                .OrderByDescending(x=> x.Date)
                .ToListAsync();
        }
        public async Task<List<IGrouping<Department,SalesRecord>>>FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= minDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToListAsync();
        }



    }
}
