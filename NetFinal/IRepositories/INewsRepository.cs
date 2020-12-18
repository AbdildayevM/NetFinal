using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;

namespace NetFinal.Repositories
{
    public interface INewsRepository
    {
        Task<List<News>> GetAll();
    }
}
