using Microsoft.EntityFrameworkCore;
using MyHome.Data;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data
{
    public class NegotiatorRepository:INegotiatorRepository
    {
        private readonly IMyHomeDbContext _context;

        public NegotiatorRepository(IMyHomeDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Negotiator> CreateAsync(Negotiator negotiator)
        {
            if (negotiator == null)
            {
                throw new ArgumentNullException(nameof(negotiator));
            }

            try
            {
                _context.Negotiators.Add(negotiator);
                await _context.SaveChangesAsync();
                return negotiator;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var negotiator = await _context.Negotiators.SingleOrDefaultAsync(p => p.NegotiatorId == id);
                if (negotiator != null)
                {
                    _context.Negotiators.Remove(negotiator);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Negotiator>> GetAllAsync()
        {
            try
            {
                //return await _context.Negotiators.ToListAsync();
                return await _context.Negotiators
                    .Include(p => p.Property)
                    .ToListAsync();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Negotiator>> GetAllAsync(int propertyId)
        {
            try
            {
                
             return await _context.Negotiators
            .Include(p => p.Property)
            .Where(n => n.PropertyId == propertyId) // Filter by propertyId
            .ToListAsync();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Negotiator> GetByIdAsync(int id)
        {
            try
            {
                var negotiator = await _context.Negotiators
                .Include(p => p.Property)
                .SingleOrDefaultAsync(p => p.NegotiatorId == id);

                if (negotiator == null)
                {
                    //negotiator is not found
                    throw new InvalidOperationException("Negotiator not found.");
                }

                return negotiator;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> UpdateAsync(Negotiator negotiator)
        {
            if (negotiator == null)
            {
                throw new ArgumentNullException(nameof(negotiator));
            }

            try
            {
                var existingNegotiator = await _context.Negotiators.FindAsync(negotiator.NegotiatorId);
                if (existingNegotiator == null)
                {
                    throw new ArgumentException("Negotiator not found.", nameof(negotiator.NegotiatorId));
                }
                _context.Entry(existingNegotiator).State = EntityState.Detached;

                _context.Entry(negotiator).State = EntityState.Modified;

                int affectedRows = await _context.SaveChangesAsync();
                return affectedRows > 0; // Return true if any rows were affected
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
