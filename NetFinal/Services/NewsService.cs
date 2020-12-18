using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Repositories;

namespace NetFinal.Services
{
    public class NewsService
    {
        private readonly INewsRepository _newsRepo;

        public NewsService(INewsRepository newsRepo)
        {
            _newsRepo = newsRepo;
        }

        public async Task<List<News>> GetNews()
        {
            return await _newsRepo.GetAll();
        }
    }
}
