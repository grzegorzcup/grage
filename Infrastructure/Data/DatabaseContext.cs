﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options):base (options) { }
        public DbSet<Garage> Garages { get; set; }
    }
}
