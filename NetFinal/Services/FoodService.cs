using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Repositories;

namespace NetFinal.Services
{
    public class FoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public async Task<List<Food>> GetFoods()
        {
            return await _foodRepo.GetAll();
        }
    }
}
