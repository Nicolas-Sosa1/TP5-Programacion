using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP5_Grupo18_Programacion
{
    public class Conexion
    {
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales;Integrated Security = True";

        public int EjecutarTransaccion(string consultaSQL)
        {
            //ESTABLECER UNA CONEXION A LA BASE DE DATOS SOL SERVER
            //CREAR EL OBJETO DE TIPO SqlConnection
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);

            //ABRIR LA CONEXION
            sqlConnection.Open();

            // Pasarle Cadena de Conexión Y Consulta SQL AL SqlCommand
            SqlCommand sqlCommand = new SqlCommand(consultaSQL, sqlConnection);

            // Ejecuta el comando sql y guarda el numero de filas que fueron afectadas en una variable
            int filasAfectadas = sqlCommand.ExecuteNonQuery();

            // Cierra la conexion sql
            sqlConnection.Close();
            
            // Devuelve el numero de filas
            return filasAfectadas;
        }

        public SqlDataReader LeerConsulta(string consultaSQL)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand command = new SqlCommand(consultaSQL, conexion);
            conexion.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}