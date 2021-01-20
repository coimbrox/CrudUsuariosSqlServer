﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CrudUsuariosSqlServer.Models
{
    public class Contexto : DbContext 
    {
        // construtor da classe

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

