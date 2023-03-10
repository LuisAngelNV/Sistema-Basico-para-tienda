using Sistem_Tienda.Datos;
using Sistem_Tienda.Propiedades;
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

        #region "Mis Variables"
        int nid_ar = 0;
        int nEstadoGuarda = 0;
        #endregion

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

        private void Estado_Tex(bool lEsctado)
        {
            txt_Articulo.ReadOnly = !lEsctado;
            txt_Marca.ReadOnly = !lEsctado;
            txt_Stock.ReadOnly = !lEsctado;
        }

        private void Estado_botones_proceso(bool lEstado)
        {
            btn_lupa_categoria.Enabled = lEstado;
            Btn_lupa_Unidad_De_Medida.Enabled = lEstado;

            Btn_Cancelar.Visible = lEstado;
            Btn_Guardar.Visible = lEstado;

            //Otros detalles.
            txt_Buscar.ReadOnly = lEstado;
            Btn_Buscar.Enabled = !lEstado;
            txt_Buscar.Visible = !lEstado;
            Btn_Buscar.Visible = !lEstado;
            dgv_articulos.Enabled = !lEstado;
            menuStrip1.Enabled = !lEstado;
        }

        private void Estado_Botones_Principales(bool lEstado)
        {
            Menu_Nuevo.Enabled = lEstado;
            Menu_Actualizar.Enabled = lEstado;
            Menu_Eliminar.Enabled = lEstado;
            Menu_Reporte.Enabled = lEstado;
            Menu_Salir.Enabled = lEstado;
        }

        private void Limpia_texto()
        {
            txt_Articulo.Text = "";
            txt_Marca.Text = "";
            Txt_Medida.Text = "";
            txt_Stock.Text = "";
            Txt_Categoria.Text = "";
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_articulos.CurrentRow.Cells["id_ar"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }else {
                this.nid_ar =Convert.ToInt32(dgv_articulos.CurrentRow.Cells["id_ar"].Value);
                txt_Articulo.Text= Convert.ToString(dgv_articulos.CurrentRow.Cells["descripcion_ar"].Value); 
                txt_Marca.Text= Convert.ToString(dgv_articulos.CurrentRow.Cells["marca_ar"].Value);
                Txt_Medida.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_um"].Value);
                Txt_Categoria.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["codigo_ca"].Value);
                txt_Stock.Text = Convert.ToString(dgv_articulos.CurrentRow.Cells["stock_actual"].Value);
            }

        }

        #endregion
        //al inicizalizar el proyecto ejecute
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_Art("%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_Art("%"+ txt_Buscar.Text.Trim()+"%");
            txt_Buscar.Text = "";
        }

        private void Menu_Nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo resgitro
            this.Limpia_texto();
            this.Estado_Tex(true);
            this.Estado_botones_proceso(true);
            this.Estado_Botones_Principales(true);
            txt_Articulo.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpia_texto();
            this.Estado_Tex(false);
            this.Estado_botones_proceso(false);
            this.Estado_Botones_Principales(true);
            txt_Buscar.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            //instanciar p_Articulos
            P_Articulos oAr = new P_Articulos();
            oAr.id_ar = nid_ar;
            oAr.descripcion_ar = txt_Articulo.Text.Trim();
            oAr.marca_ar = txt_Marca.Text.Trim();
            oAr.codigo_um = 1;
            oAr.codigo_ca = 1;
            oAr.stock_actual = Convert.ToDecimal(txt_Stock.Text.Trim());
            oAr.fecha_creado = DateTime.Now.ToString("yyyy-MM-dd");
            oAr.fecha_modificado = DateTime.Now.ToString("yyyy-MM-dd");


            //Instancia de D_Articulos
            D_Articulos Datos = new D_Articulos();
            Rpta = Datos.Guardar_ar(nEstadoGuarda, oAr);
            if (Rpta.Equals("OK"))
            {
                this.Estado_Tex(false);
                this.Estado_botones_proceso(false);
                this.Estado_Botones_Principales(true);
                this.Listado_Art("%");
                nid_ar = 0;

                MessageBox.Show("Los datos han sido guardados correctamente",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show(Rpta,
                                "Aviso del sistema ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void Menu_Actualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; //Actualizar 
            this.Estado_Tex(true);
            this.Estado_botones_proceso(true);
            this.Estado_Botones_Principales(false);
            txt_Articulo.Focus();
        }

        private void dgv_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }
    }
}
