
namespace Sistem_Tienda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Articulo = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.Txt_Medida = new System.Windows.Forms.TextBox();
            this.Medida = new System.Windows.Forms.Label();
            this.Btn_lupa_Unidad_De_Medida = new System.Windows.Forms.Button();
            this.btn_lupa_categoria = new System.Windows.Forms.Button();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Actualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Um = new System.Windows.Forms.Panel();
            this.Btn_Retorno_um = new System.Windows.Forms.Button();
            this.Dgv_Um = new System.Windows.Forms.DataGridView();
            this.Pnl_Categoria = new System.Windows.Forms.Panel();
            this.Btn_Regresar_Categoria = new System.Windows.Forms.Button();
            this.Dgv_Categoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Pnl_Um.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Um)).BeginInit();
            this.Pnl_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AllowUserToAddRows = false;
            this.dgv_articulos.AllowUserToDeleteRows = false;
            this.dgv_articulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_articulos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_articulos.ColumnHeadersHeight = 35;
            this.dgv_articulos.Location = new System.Drawing.Point(14, 220);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.Size = new System.Drawing.Size(827, 161);
            this.dgv_articulos.TabIndex = 0;
            this.dgv_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulo:";
            // 
            // txt_Articulo
            // 
            this.txt_Articulo.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Articulo.Location = new System.Drawing.Point(93, 41);
            this.txt_Articulo.Name = "txt_Articulo";
            this.txt_Articulo.ReadOnly = true;
            this.txt_Articulo.Size = new System.Drawing.Size(295, 25);
            this.txt_Articulo.TabIndex = 2;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Marca.Location = new System.Drawing.Point(508, 41);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.ReadOnly = true;
            this.txt_Marca.Size = new System.Drawing.Size(309, 25);
            this.txt_Marca.TabIndex = 4;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(429, 44);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(62, 22);
            this.Marca.TabIndex = 3;
            this.Marca.Text = "Marca: ";
            // 
            // Txt_Medida
            // 
            this.Txt_Medida.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Medida.Location = new System.Drawing.Point(93, 92);
            this.Txt_Medida.Name = "Txt_Medida";
            this.Txt_Medida.ReadOnly = true;
            this.Txt_Medida.Size = new System.Drawing.Size(252, 25);
            this.Txt_Medida.TabIndex = 6;
            // 
            // Medida
            // 
            this.Medida.AutoSize = true;
            this.Medida.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medida.Location = new System.Drawing.Point(14, 93);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(73, 22);
            this.Medida.TabIndex = 5;
            this.Medida.Text = "Medida: ";
            // 
            // Btn_lupa_Unidad_De_Medida
            // 
            this.Btn_lupa_Unidad_De_Medida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_lupa_Unidad_De_Medida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lupa_Unidad_De_Medida.Location = new System.Drawing.Point(351, 93);
            this.Btn_lupa_Unidad_De_Medida.Name = "Btn_lupa_Unidad_De_Medida";
            this.Btn_lupa_Unidad_De_Medida.Size = new System.Drawing.Size(37, 24);
            this.Btn_lupa_Unidad_De_Medida.TabIndex = 7;
            this.Btn_lupa_Unidad_De_Medida.Text = "...";
            this.Btn_lupa_Unidad_De_Medida.UseVisualStyleBackColor = true;
            this.Btn_lupa_Unidad_De_Medida.Click += new System.EventHandler(this.Btn_lupa_Unidad_De_Medida_Click);
            // 
            // btn_lupa_categoria
            // 
            this.btn_lupa_categoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.btn_lupa_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lupa_categoria.Location = new System.Drawing.Point(763, 95);
            this.btn_lupa_categoria.Name = "btn_lupa_categoria";
            this.btn_lupa_categoria.Size = new System.Drawing.Size(32, 24);
            this.btn_lupa_categoria.TabIndex = 10;
            this.btn_lupa_categoria.Text = "...";
            this.btn_lupa_categoria.UseVisualStyleBackColor = true;
            this.btn_lupa_categoria.Click += new System.EventHandler(this.btn_lupa_categoria_Click);
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Categoria.Location = new System.Drawing.Point(508, 94);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.ReadOnly = true;
            this.Txt_Categoria.Size = new System.Drawing.Size(249, 25);
            this.Txt_Categoria.TabIndex = 9;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(403, 97);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(88, 22);
            this.Categoria.TabIndex = 8;
            this.Categoria.Text = "Categoria: ";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.Location = new System.Drawing.Point(122, 142);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.ReadOnly = true;
            this.txt_Stock.Size = new System.Drawing.Size(266, 25);
            this.txt_Stock.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock Actual:";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancelar.ImageKey = "expediente.png";
            this.Btn_Cancelar.ImageList = this.imageList1;
            this.Btn_Cancelar.Location = new System.Drawing.Point(459, 145);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "limpieza.png");
            this.imageList1.Images.SetKeyName(1, "expediente.png");
            this.imageList1.Images.SetKeyName(2, "save_3621.png");
            this.imageList1.Images.SetKeyName(3, "regreso.png");
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.ImageKey = "save_3621.png";
            this.Btn_Guardar.ImageList = this.imageList1;
            this.Btn_Guardar.Location = new System.Drawing.Point(565, 145);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 34);
            this.Btn_Guardar.TabIndex = 14;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Visible = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Nuevo,
            this.Menu_Actualizar,
            this.Menu_Eliminar,
            this.Menu_Reporte,
            this.Menu_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 30);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Nuevo
            // 
            this.Menu_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Nuevo.Image")));
            this.Menu_Nuevo.Name = "Menu_Nuevo";
            this.Menu_Nuevo.Size = new System.Drawing.Size(85, 26);
            this.Menu_Nuevo.Text = "Nuevo";
            this.Menu_Nuevo.Click += new System.EventHandler(this.Menu_Nuevo_Click);
            // 
            // Menu_Actualizar
            // 
            this.Menu_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Actualizar.Image")));
            this.Menu_Actualizar.Name = "Menu_Actualizar";
            this.Menu_Actualizar.Size = new System.Drawing.Size(110, 26);
            this.Menu_Actualizar.Text = "Actualizar";
            this.Menu_Actualizar.Click += new System.EventHandler(this.Menu_Actualizar_Click);
            // 
            // Menu_Eliminar
            // 
            this.Menu_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Eliminar.Image")));
            this.Menu_Eliminar.Name = "Menu_Eliminar";
            this.Menu_Eliminar.Size = new System.Drawing.Size(101, 26);
            this.Menu_Eliminar.Text = "Eliminar";
            this.Menu_Eliminar.Click += new System.EventHandler(this.Menu_Eliminar_Click);
            // 
            // Menu_Reporte
            // 
            this.Menu_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Reporte.Image")));
            this.Menu_Reporte.Name = "Menu_Reporte";
            this.Menu_Reporte.Size = new System.Drawing.Size(95, 26);
            this.Menu_Reporte.Text = "Reporte";
            this.Menu_Reporte.Click += new System.EventHandler(this.Menu_Reporte_Click);
            // 
            // Menu_Salir
            // 
            this.Menu_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Salir.Image")));
            this.Menu_Salir.Name = "Menu_Salir";
            this.Menu_Salir.Size = new System.Drawing.Size(71, 26);
            this.Menu_Salir.Text = "Salir";
            this.Menu_Salir.Click += new System.EventHandler(this.Menu_Salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Location = new System.Drawing.Point(351, 190);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(37, 24);
            this.Btn_Buscar.TabIndex = 18;
            this.Btn_Buscar.Text = "button1";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(93, 189);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(252, 25);
            this.txt_Buscar.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar";
            // 
            // Pnl_Um
            // 
            this.Pnl_Um.Controls.Add(this.Btn_Retorno_um);
            this.Pnl_Um.Controls.Add(this.Dgv_Um);
            this.Pnl_Um.Location = new System.Drawing.Point(158, 173);
            this.Pnl_Um.Name = "Pnl_Um";
            this.Pnl_Um.Size = new System.Drawing.Size(246, 239);
            this.Pnl_Um.TabIndex = 19;
            this.Pnl_Um.Visible = false;
            // 
            // Btn_Retorno_um
            // 
            this.Btn_Retorno_um.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(81)))));
            this.Btn_Retorno_um.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_Retorno_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retorno_um.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retorno_um.ForeColor = System.Drawing.Color.White;
            this.Btn_Retorno_um.ImageKey = "regreso.png";
            this.Btn_Retorno_um.ImageList = this.imageList1;
            this.Btn_Retorno_um.Location = new System.Drawing.Point(72, 201);
            this.Btn_Retorno_um.Name = "Btn_Retorno_um";
            this.Btn_Retorno_um.Size = new System.Drawing.Size(100, 35);
            this.Btn_Retorno_um.TabIndex = 21;
            this.Btn_Retorno_um.Text = "Regresar";
            this.Btn_Retorno_um.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Retorno_um.UseVisualStyleBackColor = false;
            this.Btn_Retorno_um.Click += new System.EventHandler(this.Btn_Retorno_um_Click);
            // 
            // Dgv_Um
            // 
            this.Dgv_Um.AllowUserToAddRows = false;
            this.Dgv_Um.AllowUserToDeleteRows = false;
            this.Dgv_Um.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Um.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Um.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgv_Um.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Um.ColumnHeadersHeight = 35;
            this.Dgv_Um.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Um.Name = "Dgv_Um";
            this.Dgv_Um.ReadOnly = true;
            this.Dgv_Um.Size = new System.Drawing.Size(240, 201);
            this.Dgv_Um.TabIndex = 20;
            this.Dgv_Um.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Um_CellDoubleClick);
            // 
            // Pnl_Categoria
            // 
            this.Pnl_Categoria.Controls.Add(this.Btn_Regresar_Categoria);
            this.Pnl_Categoria.Controls.Add(this.Dgv_Categoria);
            this.Pnl_Categoria.Location = new System.Drawing.Point(508, 190);
            this.Pnl_Categoria.Name = "Pnl_Categoria";
            this.Pnl_Categoria.Size = new System.Drawing.Size(246, 239);
            this.Pnl_Categoria.TabIndex = 22;
            this.Pnl_Categoria.Visible = false;
            // 
            // Btn_Regresar_Categoria
            // 
            this.Btn_Regresar_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(121)))), ((int)(((byte)(81)))));
            this.Btn_Regresar_Categoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.Btn_Regresar_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar_Categoria.Font = new System.Drawing.Font("Roboto Serif 20pt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar_Categoria.ForeColor = System.Drawing.Color.White;
            this.Btn_Regresar_Categoria.ImageKey = "regreso.png";
            this.Btn_Regresar_Categoria.ImageList = this.imageList1;
            this.Btn_Regresar_Categoria.Location = new System.Drawing.Point(72, 201);
            this.Btn_Regresar_Categoria.Name = "Btn_Regresar_Categoria";
            this.Btn_Regresar_Categoria.Size = new System.Drawing.Size(100, 35);
            this.Btn_Regresar_Categoria.TabIndex = 21;
            this.Btn_Regresar_Categoria.Text = "Regresar";
            this.Btn_Regresar_Categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Regresar_Categoria.UseVisualStyleBackColor = false;
            this.Btn_Regresar_Categoria.Click += new System.EventHandler(this.Btn_Regresar_Categoria_Click);
            // 
            // Dgv_Categoria
            // 
            this.Dgv_Categoria.AllowUserToAddRows = false;
            this.Dgv_Categoria.AllowUserToDeleteRows = false;
            this.Dgv_Categoria.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Categoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Categoria.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgv_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Categoria.ColumnHeadersHeight = 35;
            this.Dgv_Categoria.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Categoria.Name = "Dgv_Categoria";
            this.Dgv_Categoria.ReadOnly = true;
            this.Dgv_Categoria.Size = new System.Drawing.Size(240, 201);
            this.Dgv_Categoria.TabIndex = 20;
            this.Dgv_Categoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Categoria_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 393);
            this.Controls.Add(this.Pnl_Categoria);
            this.Controls.Add(this.Pnl_Um);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_lupa_categoria);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Btn_lupa_Unidad_De_Medida);
            this.Controls.Add(this.Txt_Medida);
            this.Controls.Add(this.Medida);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.txt_Articulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(867, 432);
            this.MinimumSize = new System.Drawing.Size(867, 432);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_Um.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Um)).EndInit();
            this.Pnl_Categoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Articulo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox Txt_Medida;
        private System.Windows.Forms.Label Medida;
        private System.Windows.Forms.Button Btn_lupa_Unidad_De_Medida;
        private System.Windows.Forms.Button btn_lupa_categoria;
        private System.Windows.Forms.TextBox Txt_Categoria;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Actualizar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Reporte;
        private System.Windows.Forms.ToolStripMenuItem Menu_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_Um;
        private System.Windows.Forms.Button Btn_Retorno_um;
        private System.Windows.Forms.DataGridView Dgv_Um;
        private System.Windows.Forms.Panel Pnl_Categoria;
        private System.Windows.Forms.Button Btn_Regresar_Categoria;
        private System.Windows.Forms.DataGridView Dgv_Categoria;
    }
}

