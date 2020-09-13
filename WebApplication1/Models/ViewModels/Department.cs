using Microsoft.AspNetCore.Rewrite.Internal.PatternSegments;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WebApplication1.Models.ViewModels
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { } //Default constructor 

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTimeSegment Final)
        {
            
            return Sellers.Sum(seller => TotalSales(initial, Final));

        }
    }
}
