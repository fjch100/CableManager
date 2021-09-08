using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Modelos
{
    class Posicion : Conexion
    {
        public Posicion()
        {
            this.Tabla = "posicion";
        }

        public int Id { get; set; }
        public string PosicionName { get; set; }

        public List<Posicion> GetAllPosiciones()
        {
            return DbQueryAll<Posicion>();
        }

    }
}
