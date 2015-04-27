using ProyectoBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBar
{
    class Conexion
    {
        static string CadenaConexion;
        static OleDbConnection Conex;
        static OleDbDataAdapter Adaptador;
        static OleDbCommandBuilder Constructor;
        static DataTable Tabla;
        static BindingSource Fuente;

        public BindingSource Source
        {
            get
            {
                return Fuente;
            }
        }
        public void Conectar()
        {
            CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Roberto\Documents\Bases de Datos\Ingenieria de Software\Bar.mbd.accdb;User ID=admin";
            Conex = new OleDbConnection(CadenaConexion);
            Conex.Open();
        }
        public void Desconectar()
        {
            Conex.Close();
        }
        public void registrarEmpleado(int codigo, string nombre, string apellido, int  telefono,string password ,int tipodeusuario)
        {
            try
            {

                string insertar = "INSERT INTO Empleados VALUES ('" + codigo + "','" + nombre + "','" + apellido + "','" + telefono + "','" + password + "','" + tipodeusuario +"')";
                OleDbCommand cmd = new OleDbCommand(insertar, Conex);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");


            }

            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Consultar(string tabla, string campos, string columna, string variable)
        {
            string Consulta = "select " + campos + " from " + tabla + " where " + columna + " = '" + variable + "';";
            Adaptador = new OleDbDataAdapter(Consulta, Conex);
            Constructor = new OleDbCommandBuilder(Adaptador);
            Tabla = new DataTable(tabla);
            Adaptador.Fill(Tabla);
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }
        public void consultarSesion(string tabla, string username, string password)
        {
            string Consulta = "select * from " + tabla + " where  Codigo like '" + username + "' and Password like '" + password + "';";
            Adaptador = new OleDbDataAdapter(Consulta, Conex);
            Constructor = new OleDbCommandBuilder(Adaptador);
            Tabla = new DataTable(tabla);
            Adaptador.Fill(Tabla);
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }
        public bool verificar(string consulta, string password)
        {
            bool bandera;
            if (consulta.Equals(password))
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            return bandera;
        }

        public bool login(string tabla, string username, string password)
        {
            bool bandera;
            //ESTABLECEMOS TODAS LAS INTRUCCIONES DE LA BD
            //MANEJO DE LA INFORMACION
            string sqlquery = "select * from " + tabla + " where  Id like '" + username + "' and Password like '" + password + "';";
            string sqlquery2 = "select TipoUsuario from " + tabla + " where  Id like '" + username + "' and Password like '" + password + "';";
            OleDbCommand cmd = new OleDbCommand(sqlquery, Conex);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd2 = new OleDbCommand(sqlquery2, Conex);
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                bandera = true;
                if (int.Parse(dr["TipoUsuario"].ToString()) == 1)
                {
                    MenuAdministrador form2 = new MenuAdministrador();
                    form2.Show();
                }
                else
                {
                    MenuEmpleado form3 = new MenuEmpleado();
                    form3.Show();
                }
            }
            else
            {
                bandera = false;
                MessageBox.Show("Codigo o password erroneos, intente de nuevo");
            }
            return bandera;
        }
    }
}
