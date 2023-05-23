using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data
{
    public interface INegotiatorRepository:IRepository<Negotiator>
    {
        Task<IEnumerable<Negotiator>> GetAllAsync(int propertyId);
       
    }
}
