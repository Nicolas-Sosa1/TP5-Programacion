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
        int filasAfectadas;
        private Conexion conexion = new Conexion();
        private const string cadenaConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        private string consultaProvincias = "SELECT * FROM Provincia";

        
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)// solo cargar datos en la primera carga de la pagina
                cargarDropDownList();
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

            //cargar datos de provincias en el dropdownlist desde el sqldatareader
            ddlProvincia.DataSource = sqlDataReader;
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();

            //agregar una opción por defecto al inicio del dropdownlist
            ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar provincia--", "0"));
            sqlConnection.Close();

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string idProvincia = ddlProvincia.SelectedValue;

            //ESTABLEZCO LA CONSULTA SQL QUE SE DESEA EJECUTAR
            string consultaSQL = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES ('" + txtNombreSucursal.Text + "', '" + txtDescripcion.Text + "', " + ddlProvincia.SelectedValue + ", '" + txtDireccion.Text + "')";

            //Ejecutar Consulta
            filasAfectadas = conexion.EjecutarTransaccion(consultaSQL);

            Limpiar();
            MostrarMensaje(filasAfectadas);
        }  

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtNombreSucursal.Text = "";
            ddlProvincia.SelectedIndex = 0;
            
        }

        private void MostrarMensaje(int filasAfectadas)
        {
            if (filasAfectadas == 1)
            {
                lblMensaje.Text = "La sucursal se ha agregado con éxito";
                lblMensaje.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                lblMensaje.Text = "No se pudo realizar la operacion";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }

        }

    }
}