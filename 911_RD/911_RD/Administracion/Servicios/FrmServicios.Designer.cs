
namespace _911_RD.Administracion.Servicios
{
    partial class FrmServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_descripcion = new _911_RD.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id_und = new _911_RD.ErrorTxtBox();
            this.btn_und = new System.Windows.Forms.PictureBox();
            this.txt_und = new _911_RD.ErrorTxtBox();
            this.txt_id_tipo_servicio = new _911_RD.ErrorTxtBox();
            this.btn_cat_ser = new System.Windows.Forms.PictureBox();
            this.txt_cat_servicio = new _911_RD.ErrorTxtBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_nom = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new _911_RD.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_und = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.und = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_und)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cat_ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 460);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(152, 32);
            this.lbl_titulo.Text = "SERVICIOS";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 460);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 460);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Size = new System.Drawing.Size(33, 29);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Limpiar = true;
            this.txt_descripcion.Location = new System.Drawing.Point(18, 319);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(346, 26);
            this.txt_descripcion.SoloNumeros = false;
            this.txt_descripcion.TabIndex = 234;
            this.txt_descripcion.Validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 233;
            this.label10.Text = "DESCRIPCION";
            // 
            // txt_id_und
            // 
            this.txt_id_und.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_und.Enabled = false;
            this.txt_id_und.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_und.Limpiar = true;
            this.txt_id_und.Location = new System.Drawing.Point(205, 209);
            this.txt_id_und.Name = "txt_id_und";
            this.txt_id_und.Size = new System.Drawing.Size(49, 26);
            this.txt_id_und.SoloNumeros = true;
            this.txt_id_und.TabIndex = 232;
            this.txt_id_und.Validar = true;
            // 
            // btn_und
            // 
            this.btn_und.BackColor = System.Drawing.Color.LightGreen;
            this.btn_und.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_und.Image = global::_911_RD.Properties.Resources.search;
            this.btn_und.Location = new System.Drawing.Point(168, 209);
            this.btn_und.Name = "btn_und";
            this.btn_und.Size = new System.Drawing.Size(34, 26);
            this.btn_und.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_und.TabIndex = 231;
            this.btn_und.TabStop = false;
            this.btn_und.Click += new System.EventHandler(this.btn_modelo_Click);
            // 
            // txt_und
            // 
            this.txt_und.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_und.Enabled = false;
            this.txt_und.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_und.Limpiar = true;
            this.txt_und.Location = new System.Drawing.Point(15, 209);
            this.txt_und.Name = "txt_und";
            this.txt_und.Size = new System.Drawing.Size(187, 26);
            this.txt_und.SoloNumeros = false;
            this.txt_und.TabIndex = 230;
            this.txt_und.Validar = true;
            // 
            // txt_id_tipo_servicio
            // 
            this.txt_id_tipo_servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_tipo_servicio.Enabled = false;
            this.txt_id_tipo_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_tipo_servicio.Limpiar = true;
            this.txt_id_tipo_servicio.Location = new System.Drawing.Point(205, 155);
            this.txt_id_tipo_servicio.Name = "txt_id_tipo_servicio";
            this.txt_id_tipo_servicio.Size = new System.Drawing.Size(49, 26);
            this.txt_id_tipo_servicio.SoloNumeros = true;
            this.txt_id_tipo_servicio.TabIndex = 229;
            this.txt_id_tipo_servicio.Validar = true;
            // 
            // btn_cat_ser
            // 
            this.btn_cat_ser.BackColor = System.Drawing.Color.LightGreen;
            this.btn_cat_ser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cat_ser.Image = global::_911_RD.Properties.Resources.search;
            this.btn_cat_ser.Location = new System.Drawing.Point(168, 155);
            this.btn_cat_ser.Name = "btn_cat_ser";
            this.btn_cat_ser.Size = new System.Drawing.Size(34, 26);
            this.btn_cat_ser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cat_ser.TabIndex = 228;
            this.btn_cat_ser.TabStop = false;
            this.btn_cat_ser.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // txt_cat_servicio
            // 
            this.txt_cat_servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cat_servicio.Enabled = false;
            this.txt_cat_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cat_servicio.Limpiar = true;
            this.txt_cat_servicio.Location = new System.Drawing.Point(15, 155);
            this.txt_cat_servicio.Name = "txt_cat_servicio";
            this.txt_cat_servicio.Size = new System.Drawing.Size(187, 26);
            this.txt_cat_servicio.SoloNumeros = false;
            this.txt_cat_servicio.TabIndex = 227;
            this.txt_cat_servicio.Validar = true;
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(18, 426);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(136, 28);
            this.cb_estado.TabIndex = 226;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 225;
            this.label1.Text = "UNIDAD DE MEDIDA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(12, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(149, 16);
            this.label22.TabIndex = 224;
            this.label22.Text = "CATEGORIA SERVICIO";
            // 
            // txt_nom
            // 
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nom.Limpiar = true;
            this.txt_nom.Location = new System.Drawing.Point(18, 263);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(184, 26);
            this.txt_nom.SoloNumeros = false;
            this.txt_nom.TabIndex = 223;
            this.txt_nom.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 222;
            this.label2.Text = "NOMBRE DEL SERVICIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 237;
            this.label7.Text = "ESTADO";
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Limpiar = true;
            this.txt_precio.Location = new System.Drawing.Point(18, 373);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 26);
            this.txt_precio.SoloNumeros = true;
            this.txt_precio.TabIndex = 249;
            this.txt_precio.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 248;
            this.label3.Text = "PRECIO";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_precio.Location = new System.Drawing.Point(124, 378);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(113, 16);
            this.lbl_precio.TabIndex = 250;
            this.lbl_precio.Text = "Precio base por ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.id_categoria,
            this.id_und,
            this.id_eme,
            this.alergia,
            this.descripcion,
            this.categoria,
            this.precio,
            this.und,
            this.estado,
            this.Seleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 548);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 242);
            this.dataGridView1.TabIndex = 251;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "id_categoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // id_und
            // 
            this.id_und.HeaderText = "id_und";
            this.id_und.Name = "id_und";
            this.id_und.ReadOnly = true;
            this.id_und.Visible = false;
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 20F;
            this.id_eme.HeaderText = "ID";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // alergia
            // 
            this.alergia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alergia.FillWeight = 70F;
            this.alergia.HeaderText = "NOMBRE SERVICIO";
            this.alergia.Name = "alergia";
            this.alergia.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.FillWeight = 90F;
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria.FillWeight = 65F;
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.FillWeight = 50F;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // und
            // 
            this.und.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.und.FillWeight = 40F;
            this.und.HeaderText = "UNIDAD";
            this.und.Name = "und";
            this.und.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 40F;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Seleccionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Seleccionar.FillWeight = 10F;
            this.Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(11, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 253;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(93, 516);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 252;
            this.txt_filtro.Validar = false;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 802);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_id_und);
            this.Controls.Add(this.btn_und);
            this.Controls.Add(this.txt_und);
            this.Controls.Add(this.txt_id_tipo_servicio);
            this.Controls.Add(this.btn_cat_ser);
            this.Controls.Add(this.txt_cat_servicio);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label2);
            this.Name = "FrmServicios";
            this.Text = "FrmServicios";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_nom, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.txt_cat_servicio, 0);
            this.Controls.SetChildIndex(this.btn_cat_ser, 0);
            this.Controls.SetChildIndex(this.txt_id_tipo_servicio, 0);
            this.Controls.SetChildIndex(this.txt_und, 0);
            this.Controls.SetChildIndex(this.btn_und, 0);
            this.Controls.SetChildIndex(this.txt_id_und, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_precio, 0);
            this.Controls.SetChildIndex(this.lbl_precio, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_und)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cat_ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorTxtBox txt_descripcion;
        private System.Windows.Forms.Label label10;
        private ErrorTxtBox txt_id_und;
        public System.Windows.Forms.PictureBox btn_und;
        private ErrorTxtBox txt_und;
        private ErrorTxtBox txt_id_tipo_servicio;
        public System.Windows.Forms.PictureBox btn_cat_ser;
        private ErrorTxtBox txt_cat_servicio;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private ErrorTxtBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private ErrorTxtBox txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_precio;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_und;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn und;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}