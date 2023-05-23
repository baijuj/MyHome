using MyHome.Data;
using MyHome.Domain;
using MyHome.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Service
{
    public class NegotiatorService:INegotiatorService
    {
        private readonly INegotiatorRepository _propertyRepository;

        public NegotiatorService(INegotiatorRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public async Task<Negotiator> CreateAsync(Negotiator property)
        {
            return await _propertyRepository.CreateAsync(property);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _propertyRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Negotiator>> GetAllAsync(int propertyId)
        {
            return await _propertyRepository.GetAllAsync(propertyId);
        }

        public async Task<Negotiator> GetByIdAsync(int id)
        {
            return await _propertyRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Negotiator property)
        {
            return await _propertyRepository.UpdateAsync(property);
        }
    }
}
