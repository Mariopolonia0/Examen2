using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Examen2.Entidades
{
    public class Proyecto
    {
        [Key]
        public int proyectoId { get; set; }
        public DateTime fecha { get; set; }
        public string descripcionproyecto { get; set; }

        [ForeignKey("tipoId")]
        public List<TareaDetalle> Detalle { get; set; } = new List<TareaDetalle>();
    }

    public class TareaDetalle
    {
        public int tipoId { get; set; }
        public string tipoTarea { get; set; }
        public string requerimiento { get; set; }
        public int tiempo { get; set; }

        public TareaDetalle(string TipoTarea, string Requerimiento, int Tiempo)
        {
            tipoId = 0;
            tipoTarea = TipoTarea;
            requerimiento = Requerimiento;
            tiempo = Tiempo;
        }
    }
}
