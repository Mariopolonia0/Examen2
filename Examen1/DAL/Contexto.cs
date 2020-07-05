using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1.DAL
{
    public class Contexto : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\TeacherControl.db");
        }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nacionalidades>().HasData(new Nacionalidades
            {
                NacionalidadId = 1,
                Nacionalidad = "Dominicana"
            });
        }
        */
    }
}
