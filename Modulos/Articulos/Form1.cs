using Sistem_Tienda.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Mis Metodos"
       private void Formato_ar()
        {
            dgv_articulos.Columns[0].Width = 80;
            dgv_articulos.Columns[0].HeaderText = "CÓDIGO";
            dgv_articulos.Columns[1].Width = 250;
            dgv_articulos.Columns[1].HeaderText = "ARTÍCULO";
            dgv_articulos.Columns[2].Width = 150;
            dgv_articulos.Columns[2].HeaderText = "MARCA";
            dgv_articulos.Columns[3].Width = 80;
            dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            dgv_articulos.Columns[4].Width = 150;
            dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            dgv_articulos.Columns[5].Width = 80;
            dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            dgv_articulos.Columns[6].Visible = false;
            dgv_articulos.Columns[7].Visible = false;
        }
        private void Listado_Art(string cTexto)
        {
            //Instanciación
            D_Articulos Datos = new D_Articulos();
            dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }

        #endregion
        //al inicizalizar el proyecto ejecute
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_Art("%");
        }
    }
}
