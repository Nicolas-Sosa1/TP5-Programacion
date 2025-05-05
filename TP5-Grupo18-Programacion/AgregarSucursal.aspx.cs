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
        private Conexion conexion = new Conexion();
        int filasAfectadas;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack) // Solo cargar datos en la primera carga de la pagina
                CargarDropDownList();
        }
        private void CargarDropDownList()
        {
            // Establecer consulta SQL
            string consultaProvincias = "SELECT * FROM Provincia";
            SqlDataReader reader = conexion.LeerConsulta(consultaProvincias);

            // Cargar datos de provincias en el dropdownlist desde el sqldatareader
            ddlProvincia.DataSource = reader;
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();

            // Agregar una opción por defecto al inicio del dropdownlist
            ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar provincia--", "0"));
            reader.Close();

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string idProvincia = ddlProvincia.SelectedValue;

            // Establecer consulta SQL
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