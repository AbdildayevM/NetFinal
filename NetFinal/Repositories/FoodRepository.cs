using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace NetFinal.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        readonly NetFinalContext _context;

        public FoodRepository(NetFinalContext context)
        {
            _context = context;
        }

        public Task<List<Food>> GetAll()
        {
            return _context.Food.ToListAsync();
        }
    }
}
