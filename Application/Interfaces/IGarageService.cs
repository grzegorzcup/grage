using App.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IGarageService
    {
        IEnumerable<Garage> GetGarages();
        Garage GetGarage(int id);
        Garage AddGarage(AddGarageDto garage);
        Garage UpdateGarage(int id, UpdateGarageDto garage);
        void DeleteGarage(int id);
    }
}
