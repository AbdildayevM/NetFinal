using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace NetFinal.Repositories
{
    public class PartnersRepository : IPartnersRepository
    {
        readonly NetFinalContext _context;

        public PartnersRepository(NetFinalContext context)
        {
            _context = context;
        }

        public Task<List<Partners>> GetAll()
        {
            return _context.Partners.ToListAsync();
        }
    }
}
