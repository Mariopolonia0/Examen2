using Examen2.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet <Proyecto> Proyecto { set; get; }
        public DbSet <Proyecto> TareaDetalle { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\BDProyecto.db");
        }
    }
}
