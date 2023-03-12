using Sistem_Tienda.Datos;
using Sistem_Tienda.Modulos.Reporte_Articulos;
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
        int nid_um = 0;
        int nid_Ca = 0;

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
            txt_Stock.Text = "0";
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
                this.nid_um = Convert.ToInt32(dgv_articulos.CurrentRow.Cells["codigo_um"].Value);
                this.nid_Ca = Convert.ToInt32(dgv_articulos.CurrentRow.Cells["codigo_ca"].Value);
            }

        }

        #endregion

        #region "Métodos para medidas y categorias"

        private void Formato_UM()
        {
            Dgv_Um.Columns[0].Width = 200;
            Dgv_Um.Columns[0].HeaderText = "MEDIDAS";
            Dgv_Um.Columns[1].Visible = false;
           
        }
        private void Listado_UM()
        {
            //Instanciación
            D_Articulos Datos = new D_Articulos();
            Dgv_Um.DataSource = Datos.Listado_Um();
            this.Formato_UM();
        }

        private void Formato_Categorias()
        {
            Dgv_Categoria.Columns[0].Width = 200;
            Dgv_Categoria.Columns[0].HeaderText = "MEDIDAS";
            Dgv_Categoria.Columns[1].Visible = false;

        }
        private void Listado_Categorias()
        {
            //Instanciación
            D_Articulos Datos = new D_Articulos();
            Dgv_Categoria.DataSource = Datos.Listado_Categoria();
            this.Formato_Categorias();
        }

        private void Selecciona_item_um()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Um.CurrentRow.Cells["id_um"].Value)))
            {
                MessageBox.Show("Selecciona un elemento de la lista",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nid_um = Convert.ToInt32(Dgv_Um.CurrentRow.Cells["id_um"].Value);
                Txt_Medida.Text = Convert.ToString(Dgv_Um.CurrentRow.Cells["descripcion_un"].Value);
        
            }

        }

        private void Selecciona_item_categoria()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Categoria.CurrentRow.Cells["id_ca"].Value)))
            {
                MessageBox.Show("Selecciona un elemento de la lista",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nid_Ca = Convert.ToInt32(Dgv_Categoria.CurrentRow.Cells["id_ca"].Value);
                Txt_Categoria.Text = Convert.ToString(Dgv_Categoria.CurrentRow.Cells["descripcion_ca"].Value);

            }

        }

        #endregion
        //al inicizalizar el proyecto ejecute
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listado_Art("%");
            this.Listado_UM();
            this.Listado_Categorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_Art("%"+ txt_Buscar.Text.Trim()+"%");
            txt_Buscar.Text = "";
        }

        private void Menu_Nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo resgitro
            this.Estado_Tex(true);
            this.Limpia_texto();
            this.Estado_botones_proceso(true);
            this.Estado_Botones_Principales(true);
            txt_Articulo.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            nid_ar = 0;
            nEstadoGuarda = 0;
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
            oAr.codigo_um = this.nid_um;
            oAr.codigo_ca = this.nid_Ca;
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
                nEstadoGuarda = 0;
                nid_Ca = 0;
                nid_um = 0;

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

        private void Menu_Eliminar_Click(object sender, EventArgs e)
        {
            if (nid_ar > 0)
            {
                string Rpta = "";
                D_Articulos Datos = new D_Articulos();
                Rpta = Datos.Eliminar_ar(nid_ar);
                
                    if (Rpta.Equals("OK"))
                    {
                        this.Limpia_texto();
                    this.Listado_Art("%");
                        nid_ar = 0;
                    nEstadoGuarda = 0;
                        MessageBox.Show("Registro Eliminado Correctamenete",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
            }
            else{
                    MessageBox.Show("No se tiene seleccionado ningun elemento",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }

        }

        private void Menu_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Articulos oRpt = new Frm_Reporte_Articulos();
            oRpt.ShowDialog();
        }

        private void Btn_lupa_Unidad_De_Medida_Click(object sender, EventArgs e)
        {
            Pnl_Um.Location = Txt_Medida.Location;
            Pnl_Um.Visible = true;
        }

        private void btn_lupa_categoria_Click(object sender, EventArgs e)
        {
            Pnl_Categoria.Location = Txt_Categoria.Location;
            Pnl_Categoria.Visible = true;
        }

        private void Btn_Retorno_um_Click(object sender, EventArgs e)
        {
            Pnl_Um.Visible = false;
        }

        private void Btn_Regresar_Categoria_Click(object sender, EventArgs e)
        {
            Pnl_Categoria.Visible = false;
        }

        private void Dgv_Um_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_um();
            Pnl_Um.Visible = false;
        }

        private void Dgv_Categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_categoria();
            Pnl_Categoria.Visible = false;
        }
    }
}
