using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Diseño de tablas dentro de CS
using System.Data;
//trabajar con Mysql
using MySql.Data;
using MySql.Data.MySqlClient;
using Sistem_Tienda.DBCONNECTION;

namespace Sistem_Tienda.Datos
{
    public class D_Articulos
    {
        public DataTable Listado_ar(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Table = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Consumo de conectividad
                sqlcon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT a.id_ar, a.descripcion_ar, a.marca_ar, " +
                    "b.descripcion_un, c.descripcion_ca, a.stock_actual, a.codigo_um, " +
                    "a.codigo_ca FROM tb_articulos a " +
                    "INNER JOIN tb_unidad_medidas b ON a.codigo_um=b.id_um " +
                    "INNER JOIN tb_categoria c ON a.codigo_ca=c.id_ca " +
                    "where a.descripcion_ar like '"+cTexto+"' " +
                    " order by a.id_ar";

                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlcon);
                Comando.CommandTimeout = 60;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
    }
}
