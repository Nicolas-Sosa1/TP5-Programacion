using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TP5_Grupo18_Programacion
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        private Conexion conexion  = new Conexion();
        int filasAfectadas;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        private void LimpiarCampos()
        {
            txtIDSucursal.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // Establecer consulta SQL
            string consultaSQL = "DELETE FROM Sucursal WHERE Id_Sucursal = " + txtIDSucursal.Text;

            // Ejecutar Consulta
            filasAfectadas = conexion.EjecutarTransaccion(consultaSQL);

            LimpiarCampos();
            MostrarMensaje(filasAfectadas);

        }

        private void MostrarMensaje(int filasAfectadas)
        {
            if (filasAfectadas == 1)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito";
                lblMensaje.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                lblMensaje.Text = "El ID ingresado no existe. No se eliminó ninguna sucursal.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}