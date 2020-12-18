using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;

namespace NetFinal.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        readonly NetFinalContext _context;

        public OrderRepository(NetFinalContext context)
        {
            _context = context;
        }

        public Task<List<Order>> GetAll()
        {
            return _context.Order.ToListAsync();
        }

        public IEnumerable<Order> AllOrders => _context.Order;
    }
}
