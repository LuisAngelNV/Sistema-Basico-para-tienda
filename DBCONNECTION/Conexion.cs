using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistem_Tienda.DBCONNECTION
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion con = null;


        //instanciar proceso
        private Conexion()
        {
            //Declaración de variables
            this.Base = "db_almacen";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "sasa";
        }


        //Implementación de variables para crear conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor + "; port=" + this.Puerto + "; username=" + this.Usuario +
                    ";password=" + this.Clave + ";Database=" + this.Base;
            }catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }


        //Abrir Conexion
        public static Conexion getInstacia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
