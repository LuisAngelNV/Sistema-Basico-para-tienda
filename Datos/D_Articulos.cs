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
using Sistem_Tienda.Propiedades;

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
                    "and a.Estado=1" +
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
        //oAr = Objeto Articulo
        //Rpta = Respuesta
        public string Guardar_ar(int nOpcion, P_Articulos oAr)
        {
            string Rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                sqlcon = Conexion.getInstacia().CrearConexion();
                if (nOpcion==1) //Nuevo registro
                {
                    sqlTarea = "Insert into tb_articulos(descripcion_ar, " +
                           "marca_ar, " +
                           "codigo_um, " +
                           "codigo_ca, " +
                           "stock_actual, " +
                           "fecha_creado, " +
                           "fecha_modificado," +
                           "estado) " +
                           "values('" + oAr.descripcion_ar + "', " +
                                   "'" + oAr.marca_ar + "', " +
                                   "'" + oAr.codigo_um + "', " +
                                   "'" + oAr.codigo_ca + "', " +
                                   "'" + oAr.stock_actual + "', " +
                                   "'" + oAr.fecha_creado + "', " +
                                   "'" + oAr.fecha_modificado + "', 1)"; 
                }
                else //Actualizar Registro
                {
                    sqlTarea = "update tb_articulos set descripcion_ar= '"+ oAr.descripcion_ar+"' ," +
                                                        "marca_ar= '"+oAr.marca_ar+"' ," +
                                                        "codigo_um= '"+oAr.codigo_um+"' ," +
                                                        "codigo_ca= '"+oAr.codigo_ca+"' ," +
                                                        "stock_actual= '"+oAr.stock_actual+"' ," +
                                                        "fecha_modificado= '"+oAr.fecha_modificado+"' " +
                                                        "where id_ar= '"+oAr.id_ar+"'";
                }
                MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlcon);
                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta=ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }

        public string Eliminar_ar(int nId_ar)
        {
            string Rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                sqlcon = Conexion.getInstacia().CrearConexion();
                //Eliminación por completo
                //sqlTarea = "delete from tb_articulos where id_ar = '"+nId_ar+"'";
                //Desabilitar elementos
                sqlTarea = "update tb_articulos set Estado = 0 where id_ar ='" + nId_ar + "' ";


                MySqlCommand Comando = new MySqlCommand(sqlTarea, sqlcon);
                sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }

        public DataTable Listado_Um()
        {
            MySqlDataReader Resultado;
            DataTable Table = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Consumo de conectividad
                sqlcon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT descripcion_un, id_um from tb_unidad_medidas";

                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlcon);
                Comando.CommandTimeout = 60;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Listado_Categoria()
        {
            MySqlDataReader Resultado;
            DataTable Table = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Consumo de conectividad
                sqlcon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT descripcion_ca, id_ca from tb_categoria";

                MySqlCommand Comando = new MySqlCommand(sql_tarea, sqlcon);
                Comando.CommandTimeout = 60;
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;

            }
            catch (Exception ex)
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
