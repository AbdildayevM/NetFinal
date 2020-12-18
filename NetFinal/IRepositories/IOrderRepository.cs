using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;

namespace NetFinal.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAll();
    }
}
