using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Garage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Width { get; set; }
        [Required]
        public decimal Height { get;set; }
        [Required]
        public decimal Length { get; set; }
       
    }
}
