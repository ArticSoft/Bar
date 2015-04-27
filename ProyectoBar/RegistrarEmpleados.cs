using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoBar
{
    public partial class RegistrarEmpleados : Form
    {
        public RegistrarEmpleados()
        {
            InitializeComponent();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            conexion.registrarEmpleado(Convert.ToInt32(cajaId.Text), cajaNombre.Text, cajaApellido.Text, Convert.ToInt32(cajaTelefono.Text), cajaPassword.Text ,Convert.ToInt32(cajaTipoDeUsuario.Text));
            cajaId.Text = "";
            cajaNombre.Text = "";
            cajaApellido.Text = "";
            cajaTelefono.Text = "";
            cajaPassword.Text = "";
            cajaTipoDeUsuario.Text = "";
            conexion.Desconectar();
        }
    }
}
