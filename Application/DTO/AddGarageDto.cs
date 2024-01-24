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
    public class AddGarageDto : IMap
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Width { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Length { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddGarageDto, Garage>();
        }
    }
}
