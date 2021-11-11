using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationContext
    {
        DbSet<IrisFlower> IrisFlowers { set; get; }

        Task<int> SaveChangesAsync();

    }
}
