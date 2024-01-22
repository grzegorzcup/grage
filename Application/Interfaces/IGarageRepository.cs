using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IGarageRepository
    {
        Task<List<Garage>> GetGarages();
        Task<Garage> GetById(int id);
        Task<Garage> GetByName(string name);
        Task<Garage> Add(Garage garage);
        Task<Garage> Update(Garage garage);
        Task Delete(int id);
    }
}
