using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data
{
    public interface IMyHomeDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Property> Properties { get; set; }
        DbSet<BrochureMap> BrochureMaps { get; set; }
        DbSet<CustomData> CustomDatas { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Negotiator> Negotiators { get; set; }
        DbSet<Photo> Photos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry Entry(object entity);
    }
}
