using System;
using System.Collections.Generic;

namespace CableManager.Modelos
{
    
    public class Cable : Conexion
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


        public Cable()
        {
            this.Tabla = "cable";
        }

        public List<Cable> GetAllCables()
        {
            return DbQueryAll<Cable>();
        }

        public bool InsertOneCable(Cable cblModel)
        {
            string query = $"INSERT INTO {Tabla} " +
                $"(Numero, Long_inicial, Long_actual, Carreras, Drum, Fecha_llegada," +
                $"Fecha_instalacion, Tipo_cable) " +
                $"Values (@Numero, @Long_inicial, @Long_actual, @Carreras, @Drum, @Fecha_llegada, " +
                $"@Fecha_instalacion, @Tipo_cable);";

            var parametros = BuildAnonimousOject(cblModel, AccionesBase.INSERT);

            var wasInserted = DbInsert(query, parametros);
            
            return wasInserted;          

        }

        public bool UpdateOneCable(Cable cblModel)
        {
            string query = $"UPDATE {Tabla} SET " +
                $"Numero=@Numero, Long_inicial=@Long_inicial, Long_actual=@Long_actual, Carreras=@Carreras" +
                $", Drum=@Drum, Fecha_llegada=@Fecha_llegada, Fecha_instalacion=@Fecha_instalacion, Tipo_cable=@Tipo_cable" +
                $" WHERE id=@Id;";

            var parametros = BuildAnonimousOject(cblModel, AccionesBase.UPDATE);

            var wasUpdated = DbUpdate(query, parametros);
            
            return wasUpdated;
           
        }    
        
        private object BuildAnonimousOject(Cable cblModel, AccionesBase accion )
        {
            if (accion == AccionesBase.INSERT)
            {
                return new
                {
                    Numero = cblModel.Numero,
                    Long_inicial = cblModel.Long_inicial,
                    Long_actual = cblModel.Long_actual,
                    Carreras = cblModel.Carreras,
                    Drum = cblModel.Drum,
                    Fecha_llegada = cblModel.Fecha_llegada,
                    Fecha_instalacion = cblModel.Fecha_instalacion,
                    Tipo_cable = cblModel.Tipo_cable
                };
            }

            return new
            {
                Id = cblModel.Id,
                Numero = cblModel.Numero,
                Long_inicial = cblModel.Long_inicial,
                Long_actual = cblModel.Long_actual,
                Carreras = cblModel.Carreras,
                Drum = cblModel.Drum,
                Fecha_llegada = cblModel.Fecha_llegada,
                Fecha_instalacion = cblModel.Fecha_instalacion,
                Tipo_cable = cblModel.Tipo_cable
            };

        }

    }
}
