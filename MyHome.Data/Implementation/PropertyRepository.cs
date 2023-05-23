using Microsoft.EntityFrameworkCore;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data.Implementation
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly IMyHomeDbContext _context;

        public PropertyRepository(IMyHomeDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Property> CreateAsync(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            try
            {
                _context.Properties.Add(property);
                await _context.SaveChangesAsync();
                return property;
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var property = await _context.Properties.SingleOrDefaultAsync(p => p.Id == id);
                if (property != null)
                {
                    _context.Properties.Remove(property);
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
                //Log
                throw;
            }
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            try
            {
                return await _context.Properties
                    .Include(p => p.BrochureMap)
                    .Include(p => p.CustomData)
                    .Include(p => p.Location)
                    .Include(p => p.Negotiator)
                    .Include(p => p.Photos)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }
            public async Task<IEnumerable<Property>> GetAllAsync(string search, int pageNumber, int pageSize)
        {
            try
            {

                var query = _context.Properties
            .Include(p => p.BrochureMap)
            .Include(p => p.CustomData)
            .Include(p => p.Location)
            .Include(p => p.Negotiator)
            .Include(p => p.Photos).OrderBy(x => x.CreatedOnDate)
            .AsQueryable();

                // Apply search filter if search term is provided
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.Address.Contains(search));
                }

                // Implement pagination
                query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                return await query.ToListAsync();

            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            try
            {
                var property = await _context.Properties
                .Include(p => p.BrochureMap)
                .Include(p => p.CustomData)
                .Include(p => p.Location)
                .Include(p => p.Negotiator)
                .Include(p => p.Photos).SingleOrDefaultAsync(p => p.Id == id);

                if (property == null)
                {
                    //property is not found
                    throw new InvalidOperationException("Property not found.");
                }

                return property;
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }

        public async Task<bool> UpdateAsync(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            try
            {
                var existingProperty = await _context.Properties.FindAsync(property.Id);
                if (existingProperty == null)
                {
                    throw new ArgumentException("Property not found.", nameof(property.Id));
                }
                _context.Entry(existingProperty).State = EntityState.Detached;

                _context.Entry(property).State = EntityState.Modified;

                int affectedRows = await _context.SaveChangesAsync();
                return affectedRows > 0; // Return true if any rows were affected
            }
            catch (Exception ex)
            {
                //Log
                throw;
            }
        }
    }
}
