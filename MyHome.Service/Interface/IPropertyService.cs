using MyHome.Data;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllAsync(string search, int pageNumber, int pageSize);
        Task<Property> GetByIdAsync(int id);
        Task<Property> CreateAsync(Property property);
        Task<bool> UpdateAsync(Property property);
        Task<bool> DeleteAsync(int id);
    }

}
