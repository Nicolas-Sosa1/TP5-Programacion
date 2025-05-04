using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo18_Programacion
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        string consultaSQL;

        private const string cadenaConexion = @"Data Source=DESKTOP-Q0EVBE4\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

        private string consultaProvincias = "SELECT * FROM Provincia";

        private int filasAfectadas;

        private Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        private void cargarDropDownList()
        {
            //Establecemos la conexion a la base de datos en SQL Server
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);


            sqlConnection.Open();

            // Consulta SQL que se desea ejecutar
            SqlCommand sqlCommand = new SqlCommand(consultaProvincias, sqlConnection);

            //Ejecutar Consulta SqlCommand
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            

        }


    }
}