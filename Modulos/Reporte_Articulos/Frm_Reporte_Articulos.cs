using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// New Libreries
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using Sistem_Tienda.DBCONNECTION;

namespace Sistem_Tienda.Modulos.Reporte_Articulos
{
    public partial class Frm_Reporte_Articulos : Form
    {
        public Frm_Reporte_Articulos()
        {
            InitializeComponent();
        }
        #region "Mis Metodos"
        private void Listado()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstacia().CrearConexion();
                string sql_tarea = "SELECT a.id_ar, a.descripcion_ar, a.marca_ar, b.descripcion_un, c.descripcion_ca, a.stock_actual " +
                                    "FROM tb_articulos a " +
                                    "INNER JOIN tb_unidad_medidas b ON a.codigo_um=b.id_um " +
                                    "INNER JOIN tb_categoria c ON a.codigo_ca=c.id_ca " +
                                    "where  a.Estado=1 " +
                                    "order by a.id_ar;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql_tarea, sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Sistem_Tienda.Admin_Reportes.Reporte_Articulos.rdlc";
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                throw ex;
            }
            finally
            {
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

            }
        }
        #endregion

        private void Frm_Reporte_Articulos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport(;
            this.Listado();
        }
    }
}
