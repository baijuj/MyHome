using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public  interface INegotiatorService
    {
        Task<IEnumerable<Negotiator>> GetAllAsync(int propertyId);
        Task<Negotiator> GetByIdAsync(int id);
        Task<Negotiator> CreateAsync(Negotiator negotiator);
        Task<bool> UpdateAsync(Negotiator negotiator);
        Task<bool> DeleteAsync(int id);
    }
}
