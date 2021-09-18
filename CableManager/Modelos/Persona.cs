using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Modelos
{
    class Persona : Conexion
    {
        public int Id { get; set; }
        public int PosicionId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Activo { get; set; }
        public string StrActivo { get; set; }
        public string Posicion { get; set; }
        

        public Persona()
        {
            this.Tabla = "persona";
        }

        public List<Persona> GetAllPersonas(bool activos=false)
        {
            string query = "SELECT per.*, pos.PosicionName as 'Posicion' FROM persona per JOIN  posicion pos on per.PosicionId = pos.id";
            if (activos)
            {
                query += " WHERE per.Activo = 1";
            }
            var personas = DbQuery<Persona>(query);
            foreach (Persona per in personas)
            {
                per.StrActivo = SetStrActivo(per.Activo);
            }
            return personas;
        }

        public Persona GetOnePersona(int id)
        {
            string query = $"SELECT per.*, pos.PosicionName as 'Posicion' FROM persona per JOIN  posicion pos on per.PosicionId = pos.id WHERE per.id={id};";
            var persona = DbQuery<Persona>(query).FirstOrDefault();
            persona.StrActivo = SetStrActivo(persona.Activo);
            return persona;
        }

        public List<Persona> GetAllPersonasFromPosicion(int posicionId, bool activos= false)
        {
            string query = $"SELECT per.*, pos.PosicionName as 'Posicion' FROM persona per JOIN  posicion pos on per.PosicionId = pos.id WHERE pos.id={posicionId}";
            if (activos)
            {
                query += " AND per.Activo = 1";
            }
            var personas = DbQuery<Persona>(query);
            foreach (Persona per in personas)
            {
                per.StrActivo = SetStrActivo(per.Activo);
            }
            return personas;
        }

        public bool InsertOnePersona(Persona pnaModel)
        {
            string query = $"INSERT INTO {Tabla} " +
                $"(PosicionId, Nombre, Apellido, Direccion, Activo) " +
                $"Values (@PosicionId, @Nombre, @Apellido, @Direccion, @Activo);";
            var parametros = BuildAnonimousObject(pnaModel, AccionesBase.INSERT);
            var wasInserted = DbInsert(query, parametros);
            return wasInserted;
        }

        public bool UpdateOnePersona(Persona pnaModel)
        {
            string query = $"UPDATE {Tabla} SET " +
                $"PosicionId = @PosicionId, Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Activo=@Activo " +               
                $"WHERE Id=@Id;";
            var parametros = BuildAnonimousObject(pnaModel, AccionesBase.UPDATE);
            var wasUpdated = DbUpdate(query, parametros);
            return wasUpdated;

        }

        private object BuildAnonimousObject(Persona model, AccionesBase accion)
        {
            if (accion == AccionesBase.INSERT)
            {
                return new
                {
                    PosicionId = model.PosicionId,
                    nombre = model.Nombre,
                    Apellido = model.Apellido,
                    Direccion = model.Direccion,
                    Activo = model.Activo
                };
            }
            return new
            {
                Id = model.Id,
                PosicionId = model.PosicionId,
                nombre = model.Nombre,
                Apellido = model.Apellido,
                Direccion = model.Direccion,
                Activo = model.Activo
            };
        }

        private string SetStrActivo(int activo)
        {
            if (activo == 1)
            {
                return "Activo";
            }
            else
            {
                return "Inactivo";
            }
        }
    }
}
