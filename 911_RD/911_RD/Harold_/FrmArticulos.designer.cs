
namespace _911_RD.Administracion
{
    partial class FrmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.txt_stock = new _911_RD.ErrorTxtBox();
            this.txt_des = new _911_RD.ErrorTxtBox();
            this.txt_precio = new _911_RD.ErrorTxtBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_categoria = new _911_RD.ErrorTxtBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_unidad = new _911_RD.ErrorTxtBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_codBarra = new System.Windows.Forms.TextBox();
            this.pnl_cod = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itebis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.und = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itb_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_recompra = new _911_RD.ErrorTxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_reorden = new _911_RD.ErrorTxtBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_id_itebis = new _911_RD.ErrorTxtBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_porcentaje_itebis = new _911_RD.ErrorTxtBox();
            this.txt_id_und = new _911_RD.ErrorTxtBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_id_categoria = new _911_RD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(14, 41);
            this.label15.Size = new System.Drawing.Size(0, 19);
            this.label15.Text = "";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(23, 444);
            this.btn_guardar.Size = new System.Drawing.Size(136, 50);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(126, 32);
            this.lbl_titulo.Text = "Articulos";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(168, 444);
            this.btn_limpiar.Size = new System.Drawing.Size(136, 50);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(452, 444);
            this.btn_salir.Size = new System.Drawing.Size(130, 50);
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(165, 19);
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // id_txt
            // 
            this.id_txt.Enabled = true;
            this.id_txt.Location = new System.Drawing.Point(200, 14);
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(48, 29);
            this.id_txt.SoloNumeros = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_buscar.Image = global::_911_RD.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(355, 510);
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(25, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(186, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 157;
            this.txt_nombre.Validar = true;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_puesto_TextChanged);
            // 
            // txt_stock
            // 
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Limpiar = true;
            this.txt_stock.Location = new System.Drawing.Point(265, 59);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(114, 26);
            this.txt_stock.SoloNumeros = false;
            this.txt_stock.TabIndex = 159;
            this.txt_stock.Text = "0";
            this.txt_stock.Validar = true;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
            // 
            // txt_des
            // 
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des.Limpiar = true;
            this.txt_des.Location = new System.Drawing.Point(25, 123);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(186, 26);
            this.txt_des.SoloNumeros = false;
            this.txt_des.TabIndex = 160;
            this.txt_des.Validar = true;
            this.txt_des.TextChanged += new System.EventHandler(this.txt_des_TextChanged);
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Limpiar = true;
            this.txt_precio.Location = new System.Drawing.Point(265, 123);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(114, 26);
            this.txt_precio.SoloNumeros = true;
            this.txt_precio.TabIndex = 161;
            this.txt_precio.Text = "0";
            this.txt_precio.Validar = true;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(265, 325);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(114, 28);
            this.cb_estado.TabIndex = 176;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(26, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 177;
            this.label10.Text = "NOMBRE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 178;
            this.label1.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(265, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 179;
            this.label2.Text = "STOCK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(266, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 180;
            this.label3.Text = "ESTADO";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(33, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 183;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(127, 510);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(262, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 182;
            this.txt_filtro.Validar = false;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            this.txt_filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_filtro_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(265, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 184;
            this.label4.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(26, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 186;
            this.label5.Text = "ID UNIDAD DE MEDIDA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(26, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 189;
            this.label7.Text = "ID CATEGORIA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.ForeColor = System.Drawing.Color.FloralWhite;
            this.errorProvider1.SetIconAlignment(this.btn_generar, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btn_generar.Image = global::_911_RD.Properties.Resources.escaner_de_codigo_de_barras;
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(40, 151);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(181, 33);
            this.btn_generar.TabIndex = 194;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_categoria.Limpiar = true;
            this.txt_categoria.Location = new System.Drawing.Point(65, 196);
            this.txt_categoria.Multiline = true;
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.ReadOnly = true;
            this.txt_categoria.Size = new System.Drawing.Size(146, 27);
            this.txt_categoria.SoloNumeros = false;
            this.txt_categoria.TabIndex = 190;
            this.txt_categoria.Validar = true;
            this.txt_categoria.TextChanged += new System.EventHandler(this.txt_idcategoria_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::_911_RD.Properties.Resources.search1;
            this.pictureBox2.Location = new System.Drawing.Point(177, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 191;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_unidad
            // 
            this.txt_unidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_unidad.Limpiar = true;
            this.txt_unidad.Location = new System.Drawing.Point(63, 258);
            this.txt_unidad.Multiline = true;
            this.txt_unidad.Name = "txt_unidad";
            this.txt_unidad.ReadOnly = true;
            this.txt_unidad.Size = new System.Drawing.Size(148, 27);
            this.txt_unidad.SoloNumeros = false;
            this.txt_unidad.TabIndex = 196;
            this.txt_unidad.Validar = true;
            this.txt_unidad.TextChanged += new System.EventHandler(this.txt_unidad_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_codBarra);
            this.groupBox2.Controls.Add(this.pnl_cod);
            this.groupBox2.Controls.Add(this.btn_generar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(524, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 190);
            this.groupBox2.TabIndex = 198;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CODIGO DE BARRA";
            // 
            // txt_codBarra
            // 
            this.txt_codBarra.Location = new System.Drawing.Point(15, 102);
            this.txt_codBarra.Name = "txt_codBarra";
            this.txt_codBarra.Size = new System.Drawing.Size(237, 27);
            this.txt_codBarra.TabIndex = 0;
            this.txt_codBarra.TextChanged += new System.EventHandler(this.txt_codBarra_TextChanged);
            // 
            // pnl_cod
            // 
            this.pnl_cod.Location = new System.Drawing.Point(15, 26);
            this.pnl_cod.Name = "pnl_cod";
            this.pnl_cod.Size = new System.Drawing.Size(237, 70);
            this.pnl_cod.TabIndex = 195;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_eliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = global::_911_RD.Properties.Resources.limpiar;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(310, 444);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(136, 50);
            this.btn_eliminar.TabIndex = 199;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.nom_art,
            this.des_art,
            this.stock,
            this.pre_art,
            this.reorden,
            this.recompra,
            this.itebis,
            this.id_cat,
            this.estado,
            this.und,
            this.cod_barra,
            this.id_categoria,
            this.ID_uni,
            this.itb_id});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 542);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(911, 203);
            this.dataGridView1.TabIndex = 202;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            // 
            // id_articulo
            // 
            this.id_articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_articulo.FillWeight = 20F;
            this.id_articulo.HeaderText = "ID";
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.ReadOnly = true;
            // 
            // nom_art
            // 
            this.nom_art.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_art.FillWeight = 80F;
            this.nom_art.HeaderText = "NOMBRE";
            this.nom_art.Name = "nom_art";
            this.nom_art.ReadOnly = true;
            // 
            // des_art
            // 
            this.des_art.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.des_art.HeaderText = "DESCRIPCION";
            this.des_art.Name = "des_art";
            this.des_art.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.HeaderText = "STOCK";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // pre_art
            // 
            this.pre_art.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pre_art.HeaderText = "PRECIO";
            this.pre_art.Name = "pre_art";
            this.pre_art.ReadOnly = true;
            // 
            // reorden
            // 
            this.reorden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reorden.HeaderText = "REORDEN";
            this.reorden.Name = "reorden";
            this.reorden.ReadOnly = true;
            // 
            // recompra
            // 
            this.recompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recompra.HeaderText = "RECOMPRA";
            this.recompra.Name = "recompra";
            this.recompra.ReadOnly = true;
            // 
            // itebis
            // 
            this.itebis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itebis.HeaderText = "ITEBIS %";
            this.itebis.Name = "itebis";
            this.itebis.ReadOnly = true;
            this.itebis.Width = 81;
            // 
            // id_cat
            // 
            this.id_cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_cat.HeaderText = "CATEGORIA";
            this.id_cat.Name = "id_cat";
            this.id_cat.ReadOnly = true;
            this.id_cat.Width = 97;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // und
            // 
            this.und.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.und.HeaderText = "UNIDAD";
            this.und.Name = "und";
            this.und.ReadOnly = true;
            // 
            // cod_barra
            // 
            this.cod_barra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cod_barra.HeaderText = "CODIGO DE BARRA";
            this.cod_barra.Name = "cod_barra";
            this.cod_barra.ReadOnly = true;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "Id Cat";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // ID_uni
            // 
            this.ID_uni.HeaderText = "ID_ UNINA";
            this.ID_uni.Name = "ID_uni";
            this.ID_uni.ReadOnly = true;
            this.ID_uni.Visible = false;
            // 
            // itb_id
            // 
            this.itb_id.HeaderText = "itb_id";
            this.itb_id.Name = "itb_id";
            this.itb_id.ReadOnly = true;
            this.itb_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(144, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 203;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_recompra);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_reorden);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_id_itebis);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_porcentaje_itebis);
            this.groupBox1.Controls.Add(this.txt_id_und);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.txt_id_categoria);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txt_categoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_unidad);
            this.groupBox1.Controls.Add(this.txt_des);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(23, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 371);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENARELES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txt_recompra
            // 
            this.txt_recompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_recompra.Limpiar = true;
            this.txt_recompra.Location = new System.Drawing.Point(265, 258);
            this.txt_recompra.Name = "txt_recompra";
            this.txt_recompra.Size = new System.Drawing.Size(114, 26);
            this.txt_recompra.SoloNumeros = true;
            this.txt_recompra.TabIndex = 242;
            this.txt_recompra.Validar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(265, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 16);
            this.label12.TabIndex = 243;
            this.label12.Text = "CANTIDAD RECOMPRA";
            // 
            // txt_reorden
            // 
            this.txt_reorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_reorden.Limpiar = true;
            this.txt_reorden.Location = new System.Drawing.Point(265, 195);
            this.txt_reorden.Name = "txt_reorden";
            this.txt_reorden.Size = new System.Drawing.Size(114, 26);
            this.txt_reorden.SoloNumeros = true;
            this.txt_reorden.TabIndex = 240;
            this.txt_reorden.Validar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(265, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 241;
            this.label11.Text = "REORDEN";
            // 
            // txt_id_itebis
            // 
            this.txt_id_itebis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_itebis.Enabled = false;
            this.txt_id_itebis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_itebis.Limpiar = true;
            this.txt_id_itebis.Location = new System.Drawing.Point(25, 325);
            this.txt_id_itebis.Multiline = true;
            this.txt_id_itebis.Name = "txt_id_itebis";
            this.txt_id_itebis.Size = new System.Drawing.Size(36, 27);
            this.txt_id_itebis.SoloNumeros = false;
            this.txt_id_itebis.TabIndex = 239;
            this.txt_id_itebis.Validar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_911_RD.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(177, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 238;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(26, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 236;
            this.label8.Text = "ITBIS\r\n";
            // 
            // txt_porcentaje_itebis
            // 
            this.txt_porcentaje_itebis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_porcentaje_itebis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_porcentaje_itebis.Limpiar = true;
            this.txt_porcentaje_itebis.Location = new System.Drawing.Point(63, 325);
            this.txt_porcentaje_itebis.Multiline = true;
            this.txt_porcentaje_itebis.Name = "txt_porcentaje_itebis";
            this.txt_porcentaje_itebis.ReadOnly = true;
            this.txt_porcentaje_itebis.Size = new System.Drawing.Size(148, 27);
            this.txt_porcentaje_itebis.SoloNumeros = false;
            this.txt_porcentaje_itebis.TabIndex = 237;
            this.txt_porcentaje_itebis.Validar = true;
            // 
            // txt_id_und
            // 
            this.txt_id_und.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_und.Enabled = false;
            this.txt_id_und.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_und.Limpiar = true;
            this.txt_id_und.Location = new System.Drawing.Point(25, 258);
            this.txt_id_und.Multiline = true;
            this.txt_id_und.Name = "txt_id_und";
            this.txt_id_und.Size = new System.Drawing.Size(36, 27);
            this.txt_id_und.SoloNumeros = false;
            this.txt_id_und.TabIndex = 235;
            this.txt_id_und.Validar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::_911_RD.Properties.Resources.search1;
            this.pictureBox3.Location = new System.Drawing.Point(177, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 234;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txt_id_categoria
            // 
            this.txt_id_categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_categoria.Enabled = false;
            this.txt_id_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_categoria.Limpiar = true;
            this.txt_id_categoria.Location = new System.Drawing.Point(25, 196);
            this.txt_id_categoria.Multiline = true;
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.Size = new System.Drawing.Size(37, 27);
            this.txt_id_categoria.SoloNumeros = false;
            this.txt_id_categoria.TabIndex = 233;
            this.txt_id_categoria.Validar = true;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(935, 757);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Name = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.btn_eliminar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ErrorTxtBox txt_nombre;
        public ErrorTxtBox txt_stock;
        public ErrorTxtBox txt_des;
        public ErrorTxtBox txt_precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public ErrorTxtBox txt_categoria;
        public ErrorTxtBox txt_unidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_codBarra;
        private System.Windows.Forms.Panel pnl_cod;
        private System.Windows.Forms.Button btn_generar;
        public System.Windows.Forms.Button btn_eliminar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ErrorTxtBox txt_id_categoria;
        private ErrorTxtBox txt_id_und;
        private ErrorTxtBox txt_id_itebis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        public ErrorTxtBox txt_porcentaje_itebis;
        public ErrorTxtBox txt_recompra;
        private System.Windows.Forms.Label label12;
        public ErrorTxtBox txt_reorden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn recompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn itebis;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn und;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_uni;
        private System.Windows.Forms.DataGridViewTextBoxColumn itb_id;
    }
}
