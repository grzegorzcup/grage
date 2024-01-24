using App.Middleware;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class UpdateGarageDto : IMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateGarageDto, Garage>();
        }
    }
}
