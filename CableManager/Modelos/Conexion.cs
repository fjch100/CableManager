using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace CableManager.Modelos
{
    public class Conexion
    {
        string tabla;

        public string Tabla { get => tabla; set => tabla = value; }

        public MySqlConnection CrearConexion()
        {
            string servidor = "192.168.0.20";
            string username = "remotedb";
            string password = "remote1pi";
            string database = "Test";

            string ConnectionString = $"server={servidor}; user id={username};password={password};port=3306;sslmode=None;database={database}";

            try
            {
                MySqlConnection conexionDb = new MySqlConnection(ConnectionString);
                return conexionDb;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
                return null;
            }
        }

        public List<T> DbQuery<T>(string query)
        {
            List<T> modelos = new List<T>();
            try
            {
                using (var conexion = CrearConexion())
                {
                    modelos = conexion.Query<T>(query).ToList();                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());                
            }
            return modelos;
        }


        public List<T> DbQueryAll<T>() 
        {
            string query = $"SELECT * FROM {Tabla};";
            return DbQuery<T>(query);           
        }

        
        public T DbGetOne<T>(int Id)
        {
            string query = $"SELECT * FROM {Tabla} WHERE id = {Id};";
            using (var conexion = CrearConexion())
            {
                T  modelo = conexion.Query<T>(query).FirstOrDefault();
                return modelo;
            }  
        }


        /// <summary>
        /// Hace un Insert en la base de datos
        /// </summary>
        /// <param name="query">String  del Insert > "INSERT INTO Customers (CustomerName) Values (@CustomerName);"</param>
        /// <param name="parametros">objeto con los parametros en forma de un objeto anonimo: new {CustomerName = "Mark"}</param>
        public bool DbInsert(string query, Object parametros)
        {
            int affectedRows = 0;
            try
            {
                using (var conexion = CrearConexion())
                {
                    affectedRows = conexion.Execute(query, parametros);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error Inserting:  + {ex.Message} , Query = {query} PARAMETROS = {parametros}");
            }
            if (affectedRows > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hace un Update en la base de datos
        /// </summary>
        /// <param name="query">String  del Update 0 "UPDATE Categories SET Description = @Description WHERE CategoryID = @CategoryID;"</param>
        /// <param name="parametros">objeto con los parametros en forma de un objeto anonimo: new {CategoryID = 1, Description = "Soft drinks, coffees"}</param>
        public bool DbUpdate(string query, Object parametros)
        {
            int affectedRows = 0;
            try
            {
                using (var conexion = CrearConexion())
                {
                    affectedRows = conexion.Execute(query, parametros);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error Updating:  {ex.Message} , Query = {query} ");
            }
            if (affectedRows > 0)
            {
                return true;
            }
            return false;
            
        }

        public bool DbDelete(int id)
        {
            string query = $"DELETE FROM {Tabla} WHERE id = {id};";
            int affectedRows = 0;
            try
            {
                using (var conexion = CrearConexion())
                {
                    affectedRows = conexion.Execute(query);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            if (affectedRows > 0)
            {
                return true;
            }
            return false;
        }
    }
}
