using App.DTO;
using App.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class GarageService : IGarageService
    {
        private readonly IGarageRepository _garageRepository;
        private readonly IMapper _mapper;
        public GarageService(IGarageRepository garageRepository,IMapper mapper)
        {
            _mapper = mapper;
            _garageRepository = garageRepository;
        }
        public Garage AddGarage(AddGarageDto garage)
        {
            if (garage is null)
                throw new ArgumentNullException("nie można stworzyć garażu");
            var newGarage = _mapper.Map<Garage>(garage);
            _garageRepository.Add(newGarage);
            return newGarage;
        }

        public void DeleteGarage(int id)
        {
            if(id == 0) throw new ArgumentNullException($"nie ma garażu o id {id}");
            _garageRepository.Delete(id);
        }

        public Garage GetGarage(int id)
        {
            var garage = _garageRepository.GetById(id);
            if (garage is null)
                throw new ArgumentNullException("garage is null");
            return garage.Result;
        }

        public IEnumerable<Garage> GetGarages()
        {
            var garages = _garageRepository.GetGarages();
            if (garages is null)
                throw new ArgumentNullException("nie ma garaży");
            return garages.Result;
        }

        public Garage UpdateGarage(int id, UpdateGarageDto garage)
        {
            //var garageToUpdate = _garageRepository.GetById(id).Result ?? throw new ArgumentNullException("nie ma garażu o takim id");
            var garageToUpdate = _mapper.Map<Garage>(garage);
            return _garageRepository.Update(garageToUpdate).Result;
        }
    }
}
