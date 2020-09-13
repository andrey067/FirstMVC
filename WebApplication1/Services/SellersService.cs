
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SellersService
    {
        private readonly WebApplication1Context _context;


        public SellersService(WebApplication1Context context) 
        {
            _context = context;
        }


        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
        


    }
}
