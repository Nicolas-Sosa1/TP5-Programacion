using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo18_Programacion
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress; InitialCatalog=BDSucursales;Integrated Security = True";

        string consultaSQL;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarTabla()
        {
            consultaSQL = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal FROM Sucursal";

            SqlConnection connection = new SqlConnection(cadenaConexion);


            connection.Open();


            SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);


        }
    }
}