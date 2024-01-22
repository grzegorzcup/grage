using App.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Garagerepository : IGarageRepository
    {
        private readonly DatabaseContext _databaseContext;

        public Garagerepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public async Task<Garage> GetById(int id)
        {
            return await _databaseContext.Garages.FindAsync(id);
        }
        public async Task<Garage> GetByName(string name)
        {
            return await _databaseContext.Garages.FindAsync(name);
        }
        public async Task<List<Garage>> GetGarages()
        {
            return await _databaseContext.Garages.ToListAsync();
        }
        public async Task<Garage> Add(Garage garage)
        {
            await _databaseContext.Garages.AddAsync(garage);
            await _databaseContext.SaveChangesAsync();
            return garage;
        }
        public async Task<Garage> Update(Garage garage)
        {
            var garageToUpdate = await _databaseContext.Garages.SingleOrDefaultAsync(x => x.Id == garage.Id);
            
            using( var context = _databaseContext)
            {
                if (garageToUpdate != null)
                {
                    garageToUpdate.IsDeleted = garage.IsDeleted;
                    garageToUpdate.Name = garage.Name;
                    garageToUpdate.Width = garage.Width;
                    garageToUpdate.Height = garage.Height;
                    garageToUpdate.Length = garage.Length;
                }

                await context.SaveChangesAsync();
            }
            return garageToUpdate;
        }
        public async Task Delete(int id)
        {
            var garageToDelete = await _databaseContext.Garages.SingleOrDefaultAsync(x => x.Id == id);
            using (var context = _databaseContext)
            {
                if (garageToDelete != null)
                    garageToDelete.IsDeleted = true;
                await context.SaveChangesAsync();
            }
        }
    }
}
