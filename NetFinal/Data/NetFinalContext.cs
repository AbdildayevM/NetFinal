using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetFinal.Models;

namespace NetFinal.Data
{
    public class NetFinalContext : DbContext
    {
        public NetFinalContext (DbContextOptions<NetFinalContext> options)
            : base(options)
        {
        }

        public DbSet<NetFinal.Models.Food> Food { get; set; }

        public DbSet<NetFinal.Models.News> News { get; set; }

        public DbSet<NetFinal.Models.Order> Order { get; set; }

        public DbSet<NetFinal.Models.Partners> Partners { get; set; }

        public DbSet<NetFinal.Models.User> User { get; set; }
    }
}
