using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CableManager.Business.Models
{
    [Table("carrera")]
    public class Carrera
    {
        public int Id { get; set; }
        public int CableId { get; set; }
        public int Num_carreras { get; set; }
        public double Max_profundidad { get; set; }
        public double Max_tension { get; set; }
        public string Service_order { get; set; }
        public DateTime Fecha_Servicio { get; set; }
        public string Ingeniero { get; set; }
        public string Malacatero { get; set; }
        public double Long_actual { get; set; }
        public double Cantidad_cortada { get; set; }
        public double Long_previa { get; set; } 
        public string Comentarios { get; set; }

        [ForeignKey("CableId")]
        public virtual Cable Cable { get; set; }
    }
}
