using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP5_Grupo18_Programacion
{
    public class Conexion
    {
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress; InitialCatalog=BDSucursales;Integrated Security = True";

        public int ejecutarTransaccion(string consultaSQL)
        {
            //ESTABLECER UNA CONEXION A LA BASE DE DATOS SOL SERVER
            //CREAR EL OBJETO DE TIPO SqlConnection
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);

            //ABRIR LA CONEXION
            sqlConnection.Open();

            //Pasarle Cadena de Conexión Y Consulta SQL AL SqlCommand
            SqlCommand sqlCommand = new SqlCommand(consultaSQL, sqlConnection);

            
        }
    }
}