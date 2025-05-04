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
        //se crea una variable para guardar la cantidad de filas afectadas por una consulta sql
        private int filasAfectadas;
        //se crea una instancia de la clase "Conexion" para manejar las consultas
        private Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        private void limpiarCampos()
        {
            txtIdSucursal.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //ESTABLEZCO LA CONSULTA SQL QUE SE QUIERE EJECUTAR
            string consultaSQL = "DELETE FROM Sucursal WHERE Id_Sucursal = " + txtIDSucursal.Text;

            //Ejecutar Consulta
            filasAfectadas = conexion.ejecutarTransaccion(consultaSQL);

            limpiarCampos();
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