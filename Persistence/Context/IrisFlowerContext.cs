using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class IrisFlowerContext : DbContext, IApplicationContext
    {
        public IrisFlowerContext(DbContextOptions<IrisFlowerContext> options): base(options)
        {


        }
        public DbSet<IrisFlower> IrisFlowers { get; set ; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
