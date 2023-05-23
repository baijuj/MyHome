using MyHome.Data;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public async Task<Property> CreateAsync(Property property)
        {
            return await _propertyRepository.CreateAsync(property);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _propertyRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Property>> GetAllAsync(string search, int pageNumber, int pageSize)
        {
            return await _propertyRepository.GetAllAsync(search, pageNumber, pageSize);
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await _propertyRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Property property)
        {
            return await _propertyRepository.UpdateAsync(property);
        }
    }
}
