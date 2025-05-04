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
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales;Integrated Security = True";

        string consultaSQL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {//se llama a la funcion unicamente la primera vez que se carga la pagina
                cargarTabla();
            }
        }

        private void cargarTabla()
        {
            consultaSQL = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal FROM Sucursal";

            SqlConnection connection = new SqlConnection(cadenaConexion);

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);

            //ejecuta la consulta SELECT y obtiene un lector de datos para recorrer los resultados
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //asigna el lector de datos como fuente de datos del gridview para mostrar los resultados
            gvListado.DataSource = reader;
            //vincula los datos al gridview, actualiza la tabla en pantalla con los datos obtenidos
            gvListado.DataBind();
            //cierra la conexion con la base de datos
            connection.Close();
        }


        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

            consultaSQL = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal FROM Sucursal WHERE Id_Sucursal = " + txtIdSucursal.Text;
            SqlConnection connection = new SqlConnection(cadenaConexion);


            connection.Open();


            SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);


            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            gvSucursales.DataSource = sqlDataReader;
            gvSucursales.DataBind();

            connection.Close();

        }

    }
}