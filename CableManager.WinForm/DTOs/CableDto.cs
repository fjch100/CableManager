using System;
using System.Collections.Generic;

namespace CableManager.WinForm.DTOs
{
    
    public class CableDto
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public double Long_inicial { get; set; }
        public double Long_actual { get; set; }
        public int Carreras { get; set; }
        public string Drum { get; set; }
        public DateTime Fecha_llegada { get; set; }
        public DateTime Fecha_instalacion { get; set; }
        public string Tipo_cable { get; set; }
    }
}
