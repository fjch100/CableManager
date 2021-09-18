using System;
using System.Collections.Generic;
using System.Linq;

namespace CableManager.Modelos
{
    public class Carrera : Conexion
    {
        public int Id { get; set; }
        public int CableId { get; set; }
        public int Num_carreras { get; set; }
        public double Max_profundidad { get; set; }
        public double Max_tension { get; set; }
        public string Service_order { get; set; }
        public DateTime Fecha_Servicio { get; set; }
        public int IngenieroId { get; set; }
        public int MalacateroId { get; set; }
        public double Long_actual { get; set; }
        public double Cantidad_cortada { get; set; }
        public double Long_previa { get; set; } 
        public string Comentarios { get; set; }
        public string CableNumero { get; set; }
        public string StrIngenieroName { get; set; }
        public string StrMalacateroName { get; set; }

        public Carrera()
        {
            this.Tabla = "carrera";
        }

        public List<Carrera> GetAllCarreras()
        {
            string query = $"SELECT ca.*, cb.Numero AS 'CableNumero', CONCAT (p.Nombre, ' ' , p.Apellido) AS 'StrIngenieroName', CONCAT (pm.Nombre, ' ' , pm.Apellido) AS 'StrMalacateroName'" +
                $" FROM carrera ca " +
                $"JOIN  cable cb ON ca.CableId = cb.id " +
                $"JOIN persona p ON ca.IngenieroId = p.Id " +
                $"JOIN persona pm ON ca.MalacateroId = pm.Id;";
            var carreras = DbQuery<Carrera>(query);            
            return carreras;
        }

        public Carrera GetOneCarrera(int id)
        {
            string query = $"SELECT ca.*, cb.Numero AS 'CableNumero', CONCAT (p.Nombre, ' ' , p.Apellido) AS 'StrIngenieroName', CONCAT (pm.Nombre, ' ' , pm.Apellido) AS 'StrMalacateroName' " +
                $"FROM carrera ca " +
                $"JOIN  cable cb ON ca.CableId = cb.id " +
                $"JOIN persona p ON ca.IngenieroId = p.Id " +
                $"JOIN persona pm ON ca.MalacateroId = pm.Id" +
                $" WHERE ca.id={id};";
            var carrera = DbQuery<Carrera>(query).FirstOrDefault();
            return carrera;
        }

        public List<Carrera> GetAllCarrerasFromCable(int cableId)
        {
            string query = $"SELECT ca.*, cb.Numero AS 'CableNumero', CONCAT (p.Nombre, ' ' , p.Apellido) AS 'StrIngenieroName', CONCAT (pm.Nombre, ' ' , pm.Apellido) AS 'StrMalacateroName' " +
                $"FROM carrera ca " +
                $"JOIN  cable cb ON ca.CableId = cb.id " +
                $"JOIN persona p ON ca.IngenieroId = p.Id " +
                $"JOIN persona pm ON ca.MalacateroId = pm.Id" +
                $" WHERE cb.id={cableId};";
            var carreras = DbQuery<Carrera>(query);
            return carreras;
        }

        public bool InsertOneCarrera(Carrera craModel)
        {            
            string query = $"INSERT INTO {Tabla} " +
                $"(CableId, Num_carreras, Max_profundidad, Max_tension, Service_order, Fecha_Servicio," +
                $"IngenieroId, MalacateroId, Long_actual, Cantidad_cortada, Long_previa, Comentarios) " +
                $"Values (@CableId, @Num_carreras, @Max_profundidad, @Max_tension, @Service_order, @Fecha_Servicio, " +
                $"@IngenieroId, @MalacateroId, @Long_actual, @Cantidad_cortada, @Long_previa, @Comentarios);";
            var parametros = BuildAnonimousObject(craModel, AccionesBase.INSERT);
            var wasInserted = DbInsert(query, parametros);            
            return wasInserted;

        }


        public bool UpdateOneCarrera(Carrera craModel)
        {
            string query = $"UPDATE {Tabla} SET " +
                $"CableId = @CableId, Num_carreras=@Num_carreras, Max_profundidad=@Max_profundidad, Max_tension=@Max_tension, " +
                $"Service_order=@Service_order, Fecha_Servicio=@Fecha_Servicio, IngenieroId=@IngenieroId, MalacateroId=@MalacateroId, " +
                $"Long_actual=@Long_actual, Cantidad_cortada=@Cantidad_cortada, Long_previa=@Long_previa, Comentarios=@Comentarios " +
                $"WHERE Id=@Id;";
            var parametros = BuildAnonimousObject(craModel, AccionesBase.UPDATE);
            var wasUpdated = DbUpdate(query, parametros);
            return wasUpdated;
            
        }


        private object BuildAnonimousObject(Carrera craModel, AccionesBase accion)
        {
            if (accion == AccionesBase.INSERT)
            {
                return new
                {
                    CableId = craModel.CableId,
                    Num_carreras = craModel.Num_carreras,
                    Max_profundidad = craModel.Max_profundidad,
                    Max_tension = craModel.Max_tension,
                    Service_order = craModel.Service_order,
                    Fecha_Servicio = craModel.Fecha_Servicio,
                    IngenieroId = craModel.IngenieroId,
                    MalacateroId = craModel.MalacateroId,
                    Long_actual = craModel.Long_actual,
                    Cantidad_cortada = craModel.Cantidad_cortada,
                    Long_previa = craModel.Long_previa,
                    Comentarios = craModel.Comentarios
                };
            }
            return new
            {
                Id = craModel.Id,
                CableId = craModel.CableId,
                Num_carreras = craModel.Num_carreras,
                Max_profundidad = craModel.Max_profundidad,
                Max_tension = craModel.Max_tension,
                Service_order = craModel.Service_order,
                Fecha_Servicio = craModel.Fecha_Servicio,
                IngenieroId = craModel.IngenieroId,
                MalacateroId = craModel.MalacateroId,
                Long_actual = craModel.Long_actual,
                Cantidad_cortada = craModel.Cantidad_cortada,
                Long_previa = craModel.Long_previa,
                Comentarios = craModel.Comentarios
            };
        }

    }
}
