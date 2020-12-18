using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace NetFinal.Repositories
{
    public class NewsRepository : INewsRepository
    {
        readonly NetFinalContext _context;

        public NewsRepository(NetFinalContext context)
        {
            _context = context;
        }

        public Task<List<News>> GetAll()
        {
            return _context.News.ToListAsync();
        }
    }
}
