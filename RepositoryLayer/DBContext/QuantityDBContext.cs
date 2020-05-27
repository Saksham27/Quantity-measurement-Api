﻿using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class QuantityDBContext : DbContext
    {
        public QuantityDBContext(DbContextOptions<QuantityDBContext> options) : base(options)
        { 
        
        }

        public DbSet<ConversionModel> Conversions { get; set; }

        public DbSet<ComparisonModel> Comparisons { get; set; }
    }
}
