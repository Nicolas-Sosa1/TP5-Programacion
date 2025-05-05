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
        private Conexion conexion  = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack) 
            { // Se llama a la funcion unicamente la primera vez que se carga la pagina
                CargarTabla();
            }
        }

        private void CargarTabla()
        {
            // Establecer consulta SQL
            string consultaSQL = "SELECT S.id_Sucursal AS ID_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion " +
            "FROM Sucursal S INNER JOIN Provincia P ON S.id_ProvinciaSucursal = P.id_Provincia";
            SqlDataReader reader = conexion.LeerConsulta(consultaSQL);

            gvListado.DataSource = reader;
            gvListado.DataBind();
            reader.Close();
        }


        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Establecer consulta SQL
            string consultaSQL = "SELECT S.id_Sucursal AS ID_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion  " +
            "FROM Sucursal S INNER JOIN Provincia P ON S.id_ProvinciaSucursal = P.id_Provincia WHERE S.id_Sucursal = " + txtIdSucursal.Text;

            SqlDataReader reader = conexion.LeerConsulta(consultaSQL);

            gvListado.DataSource = reader;
            gvListado.DataBind();
            reader.Close();

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
            txtIdSucursal.Text = "";
        }

       
    }
}