
namespace _911_RD.Administracion.Vehiculo
{
    partial class FrmVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_gps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso_sis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_num_chasis = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_fabricacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num_gps = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gasto_combustible = new _911_RD.ErrorTxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_id_marca = new _911_RD.ErrorTxtBox();
            this.btn_marca = new System.Windows.Forms.PictureBox();
            this.txt_marca = new _911_RD.ErrorTxtBox();
            this.txt_id_modelo = new _911_RD.ErrorTxtBox();
            this.btn_modelo = new System.Windows.Forms.PictureBox();
            this.txt_modelo = new _911_RD.ErrorTxtBox();
            this.txt_id_combustible = new _911_RD.ErrorTxtBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_combustible = new _911_RD.ErrorTxtBox();
            this.txt_num_placa = new _911_RD.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_error_chasis = new System.Windows.Forms.Label();
            this.txt_error_placa = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_error_gps = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 465);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(162, 32);
            this.lbl_titulo.Text = "VEHICULOS";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 465);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 465);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(10, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 176;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(92, 521);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 175;
            this.txt_filtro.Validar = false;
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
            this.id_eme,
            this.cargo,
            this.descripcion,
            this.salario,
            this.estado,
            this.num_gps,
            this.fecha_fab,
            this.combustible,
            this.rendimiento,
            this.Fecha_Ingreso_sis,
            this.estatus,
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 553);
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
            this.dataGridView1.Size = new System.Drawing.Size(1145, 265);
            this.dataGridView1.TabIndex = 174;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 15F;
            this.id_eme.HeaderText = "ID";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargo.FillWeight = 40F;
            this.cargo.HeaderText = "MARCA";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.FillWeight = 60F;
            this.descripcion.HeaderText = "MODELO";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salario.FillWeight = 40F;
            this.salario.HeaderText = "CHASIS";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 40F;
            this.estado.HeaderText = "PLACA";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // num_gps
            // 
            this.num_gps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_gps.FillWeight = 30F;
            this.num_gps.HeaderText = "GPS";
            this.num_gps.Name = "num_gps";
            this.num_gps.ReadOnly = true;
            // 
            // fecha_fab
            // 
            this.fecha_fab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_fab.FillWeight = 30F;
            this.fecha_fab.HeaderText = "FABRICADO";
            this.fecha_fab.Name = "fecha_fab";
            this.fecha_fab.ReadOnly = true;
            // 
            // combustible
            // 
            this.combustible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.combustible.FillWeight = 40F;
            this.combustible.HeaderText = "COMBUSTIBLE";
            this.combustible.Name = "combustible";
            this.combustible.ReadOnly = true;
            // 
            // rendimiento
            // 
            this.rendimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rendimiento.FillWeight = 40F;
            this.rendimiento.HeaderText = "RENDIMIENTO K/GL";
            this.rendimiento.Name = "rendimiento";
            this.rendimiento.ReadOnly = true;
            // 
            // Fecha_Ingreso_sis
            // 
            this.Fecha_Ingreso_sis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Ingreso_sis.FillWeight = 40F;
            this.Fecha_Ingreso_sis.HeaderText = "INGRESADO";
            this.Fecha_Ingreso_sis.Name = "Fecha_Ingreso_sis";
            this.Fecha_Ingreso_sis.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.FillWeight = 25F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
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
            this.Seleccionar.FillWeight = 20F;
            this.Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Editar";
            // 
            // txt_num_chasis
            // 
            this.txt_num_chasis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_chasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_num_chasis.Limpiar = true;
            this.txt_num_chasis.Location = new System.Drawing.Point(15, 274);
            this.txt_num_chasis.Name = "txt_num_chasis";
            this.txt_num_chasis.Size = new System.Drawing.Size(164, 26);
            this.txt_num_chasis.SoloNumeros = false;
            this.txt_num_chasis.TabIndex = 185;
            this.txt_num_chasis.Validar = true;
            this.txt_num_chasis.TextChanged += new System.EventHandler(this.txt_num_chasis_TextChanged);
            this.txt_num_chasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_chasis_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 184;
            this.label2.Text = "NUMERO DE CHASIS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(9, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 16);
            this.label22.TabIndex = 192;
            this.label22.Text = "MARCA";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 194;
            this.label1.Text = "MODELO";
            // 
            // fecha_fabricacion
            // 
            this.fecha_fabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fabricacion.Location = new System.Drawing.Point(13, 389);
            this.fecha_fabricacion.Name = "fecha_fabricacion";
            this.fecha_fabricacion.Size = new System.Drawing.Size(207, 22);
            this.fecha_fabricacion.TabIndex = 196;
            this.fecha_fabricacion.ValueChanged += new System.EventHandler(this.fecha_fabricacion_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(10, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 195;
            this.label8.Text = "AÑO DE FABRICACIÓN";
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_ingreso.Location = new System.Drawing.Point(279, 99);
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Size = new System.Drawing.Size(207, 22);
            this.fecha_ingreso.TabIndex = 198;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(276, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 16);
            this.label3.TabIndex = 197;
            this.label3.Text = "FECHA INGRESO EN LA EMPRESA";
            // 
            // txt_num_gps
            // 
            this.txt_num_gps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_num_gps.Limpiar = true;
            this.txt_num_gps.Location = new System.Drawing.Point(279, 158);
            this.txt_num_gps.Name = "txt_num_gps";
            this.txt_num_gps.Size = new System.Drawing.Size(164, 26);
            this.txt_num_gps.SoloNumeros = false;
            this.txt_num_gps.TabIndex = 200;
            this.txt_num_gps.Validar = true;
            this.txt_num_gps.TextChanged += new System.EventHandler(this.txt_num_gps_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(276, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 199;
            this.label4.Text = "NUMERO DE GPS";
            // 
            // txt_gasto_combustible
            // 
            this.txt_gasto_combustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gasto_combustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_gasto_combustible.Limpiar = true;
            this.txt_gasto_combustible.Location = new System.Drawing.Point(279, 274);
            this.txt_gasto_combustible.Name = "txt_gasto_combustible";
            this.txt_gasto_combustible.Size = new System.Drawing.Size(164, 26);
            this.txt_gasto_combustible.SoloNumeros = false;
            this.txt_gasto_combustible.TabIndex = 202;
            this.txt_gasto_combustible.Validar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(280, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 201;
            this.label5.Text = "RENDIMIENTO K/GL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(276, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 204;
            this.label6.Text = "COMBUSTIBLE";
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(279, 334);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(132, 28);
            this.cb_estado.TabIndex = 207;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_marca.Enabled = false;
            this.txt_id_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_marca.Limpiar = true;
            this.txt_id_marca.Location = new System.Drawing.Point(202, 158);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(49, 26);
            this.txt_id_marca.SoloNumeros = false;
            this.txt_id_marca.TabIndex = 211;
            this.txt_id_marca.Validar = true;
            this.txt_id_marca.TextChanged += new System.EventHandler(this.txt_id_marca_TextChanged);
            // 
            // btn_marca
            // 
            this.btn_marca.BackColor = System.Drawing.Color.LightGreen;
            this.btn_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca.Image = global::_911_RD.Properties.Resources.search;
            this.btn_marca.Location = new System.Drawing.Point(165, 158);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(34, 26);
            this.btn_marca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_marca.TabIndex = 210;
            this.btn_marca.TabStop = false;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // txt_marca
            // 
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marca.Enabled = false;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_marca.Limpiar = true;
            this.txt_marca.Location = new System.Drawing.Point(12, 158);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(187, 26);
            this.txt_marca.SoloNumeros = false;
            this.txt_marca.TabIndex = 208;
            this.txt_marca.Validar = true;
            this.txt_marca.TextChanged += new System.EventHandler(this.txt_marca_TextChanged);
            // 
            // txt_id_modelo
            // 
            this.txt_id_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_modelo.Enabled = false;
            this.txt_id_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_modelo.Limpiar = true;
            this.txt_id_modelo.Location = new System.Drawing.Point(202, 216);
            this.txt_id_modelo.Name = "txt_id_modelo";
            this.txt_id_modelo.Size = new System.Drawing.Size(49, 26);
            this.txt_id_modelo.SoloNumeros = false;
            this.txt_id_modelo.TabIndex = 214;
            this.txt_id_modelo.Validar = true;
            // 
            // btn_modelo
            // 
            this.btn_modelo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelo.Image = global::_911_RD.Properties.Resources.search;
            this.btn_modelo.Location = new System.Drawing.Point(165, 216);
            this.btn_modelo.Name = "btn_modelo";
            this.btn_modelo.Size = new System.Drawing.Size(34, 26);
            this.btn_modelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_modelo.TabIndex = 213;
            this.btn_modelo.TabStop = false;
            this.btn_modelo.Click += new System.EventHandler(this.btn_modelo_Click);
            // 
            // txt_modelo
            // 
            this.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelo.Enabled = false;
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modelo.Limpiar = true;
            this.txt_modelo.Location = new System.Drawing.Point(12, 216);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(187, 26);
            this.txt_modelo.SoloNumeros = false;
            this.txt_modelo.TabIndex = 212;
            this.txt_modelo.Validar = true;
            // 
            // txt_id_combustible
            // 
            this.txt_id_combustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_combustible.Enabled = false;
            this.txt_id_combustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_combustible.Limpiar = true;
            this.txt_id_combustible.Location = new System.Drawing.Point(474, 216);
            this.txt_id_combustible.Name = "txt_id_combustible";
            this.txt_id_combustible.Size = new System.Drawing.Size(49, 26);
            this.txt_id_combustible.SoloNumeros = false;
            this.txt_id_combustible.TabIndex = 217;
            this.txt_id_combustible.Validar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_911_RD.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(434, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 216;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_combustible
            // 
            this.txt_combustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_combustible.Enabled = false;
            this.txt_combustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_combustible.Limpiar = true;
            this.txt_combustible.Location = new System.Drawing.Point(279, 216);
            this.txt_combustible.Name = "txt_combustible";
            this.txt_combustible.Size = new System.Drawing.Size(189, 26);
            this.txt_combustible.SoloNumeros = false;
            this.txt_combustible.TabIndex = 215;
            this.txt_combustible.Validar = true;
            // 
            // txt_num_placa
            // 
            this.txt_num_placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_num_placa.Limpiar = true;
            this.txt_num_placa.Location = new System.Drawing.Point(15, 334);
            this.txt_num_placa.Name = "txt_num_placa";
            this.txt_num_placa.Size = new System.Drawing.Size(164, 26);
            this.txt_num_placa.SoloNumeros = false;
            this.txt_num_placa.TabIndex = 219;
            this.txt_num_placa.Validar = true;
            this.txt_num_placa.TextChanged += new System.EventHandler(this.txt_num_placa_TextChanged);
            this.txt_num_placa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_placa_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(12, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 218;
            this.label10.Text = "NUMERO DE PLACA";
            // 
            // txt_error_chasis
            // 
            this.txt_error_chasis.AutoSize = true;
            this.txt_error_chasis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_chasis.ForeColor = System.Drawing.Color.Red;
            this.txt_error_chasis.Location = new System.Drawing.Point(182, 279);
            this.txt_error_chasis.Name = "txt_error_chasis";
            this.txt_error_chasis.Size = new System.Drawing.Size(17, 16);
            this.txt_error_chasis.TabIndex = 220;
            this.txt_error_chasis.Text = "X";
            this.txt_error_chasis.Visible = false;
            // 
            // txt_error_placa
            // 
            this.txt_error_placa.AutoSize = true;
            this.txt_error_placa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_placa.ForeColor = System.Drawing.Color.Red;
            this.txt_error_placa.Location = new System.Drawing.Point(185, 340);
            this.txt_error_placa.Name = "txt_error_placa";
            this.txt_error_placa.Size = new System.Drawing.Size(17, 16);
            this.txt_error_placa.TabIndex = 221;
            this.txt_error_placa.Text = "X";
            this.txt_error_placa.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_error_gps
            // 
            this.txt_error_gps.AutoSize = true;
            this.txt_error_gps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_gps.ForeColor = System.Drawing.Color.Red;
            this.txt_error_gps.Location = new System.Drawing.Point(449, 163);
            this.txt_error_gps.Name = "txt_error_gps";
            this.txt_error_gps.Size = new System.Drawing.Size(17, 16);
            this.txt_error_gps.TabIndex = 222;
            this.txt_error_gps.Text = "X";
            this.txt_error_gps.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(276, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 206;
            this.label7.Text = "ESTADO";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1169, 830);
            this.Controls.Add(this.txt_error_gps);
            this.Controls.Add(this.txt_error_placa);
            this.Controls.Add(this.txt_error_chasis);
            this.Controls.Add(this.txt_num_placa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_id_combustible);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_combustible);
            this.Controls.Add(this.txt_id_modelo);
            this.Controls.Add(this.btn_modelo);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.btn_marca);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gasto_combustible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_num_gps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha_ingreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_fabricacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_num_chasis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVehiculos";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_num_chasis, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.fecha_fabricacion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.fecha_ingreso, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_num_gps, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_gasto_combustible, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.txt_marca, 0);
            this.Controls.SetChildIndex(this.btn_marca, 0);
            this.Controls.SetChildIndex(this.txt_id_marca, 0);
            this.Controls.SetChildIndex(this.txt_modelo, 0);
            this.Controls.SetChildIndex(this.btn_modelo, 0);
            this.Controls.SetChildIndex(this.txt_id_modelo, 0);
            this.Controls.SetChildIndex(this.txt_combustible, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txt_id_combustible, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txt_num_placa, 0);
            this.Controls.SetChildIndex(this.txt_error_chasis, 0);
            this.Controls.SetChildIndex(this.txt_error_placa, 0);
            this.Controls.SetChildIndex(this.txt_error_gps, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        public System.Windows.Forms.DataGridView dataGridView1;
        private ErrorTxtBox txt_num_chasis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_fabricacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha_ingreso;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox txt_num_gps;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox txt_gasto_combustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_estado;
        private ErrorTxtBox txt_id_marca;
        public System.Windows.Forms.PictureBox btn_marca;
        private ErrorTxtBox txt_marca;
        private ErrorTxtBox txt_id_modelo;
        public System.Windows.Forms.PictureBox btn_modelo;
        private ErrorTxtBox txt_modelo;
        private ErrorTxtBox txt_id_combustible;
        public System.Windows.Forms.PictureBox pictureBox1;
        private ErrorTxtBox txt_combustible;
        private ErrorTxtBox txt_num_placa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_error_chasis;
        private System.Windows.Forms.Label txt_error_placa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txt_error_gps;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_gps;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fab;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso_sis;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label label7;
    }
}
