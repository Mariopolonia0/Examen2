using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Examen2.Entidades
{
    public class Proyectos
    {
        [Key]
        public int proyectoId { get; set; }
        public DateTime fecha { get; set; }
        public string descripcionproyecto { get; set; } 
    }

    public class TareaDetalle
    {
        public int tipoId { get; set; }
        public string tipoTarea { get; set; }
        public string requerimiento { get; set; }
        public int tiempo { get; set; }

        [ForeignKey("tipoId")]
        public Proyectos proyectos { get; set; } = new Proyectos(); 
    }
}
