using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace NetFinal.Repositories
{
    public class UserRepository : IUserRepository
    {

        readonly NetFinalContext _context;

        public UserRepository(NetFinalContext context)
        {
            _context = context;
        }

        public Task<List<User>> GetAll()
        {
            return _context.User.ToListAsync();
        }
    }

}
