
namespace _911_RD.Administracion
{
    partial class FrmEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_cedula = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_des_puesto = new _911_RD.ErrorTxtBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cargo = new _911_RD.ErrorTxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.btn_Cargo = new System.Windows.Forms.PictureBox();
            this.fecha_con = new System.Windows.Forms.DateTimePicker();
            this.fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLICITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_apellido = new _911_RD.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.txt_salario = new _911_RD.ErrorTxtBox();
            this.p_direccion = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_correo = new _911_RD.ErrorTxtBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_telefono = new _911_RD.ErrorTxtBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.lbl_conductor = new System.Windows.Forms.Label();
            this.p_conductor = new System.Windows.Forms.Panel();
            this.fecha_licencia = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_numlicencia = new _911_RD.ErrorTxtBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_long = new _911_RD.ErrorTxtBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_busc_dir = new System.Windows.Forms.PictureBox();
            this.lbl_estado_dir = new System.Windows.Forms.Label();
            this.txt_lat = new _911_RD.ErrorTxtBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_nacionalidades = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_tipoIdent = new System.Windows.Forms.ComboBox();
            this.txt_id_cargo = new _911_RD.ErrorTxtBox();
            this.cb_puestos = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.p_direccion.SuspendLayout();
            this.p_conductor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_busc_dir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar.Location = new System.Drawing.Point(11, 475);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(156, 32);
            this.lbl_titulo.Text = "EMPLEADO";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpiar.Location = new System.Drawing.Point(156, 475);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_salir.Location = new System.Drawing.Point(278, 475);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Size = new System.Drawing.Size(106, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(123, 99);
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            // 
            // txt_cedula
            // 
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cedula.Limpiar = true;
            this.txt_cedula.Location = new System.Drawing.Point(12, 209);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(170, 26);
            this.txt_cedula.SoloNumeros = true;
            this.txt_cedula.TabIndex = 145;
            this.txt_cedula.Validar = true;
            this.txt_cedula.TextChanged += new System.EventHandler(this.errorTxtBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 148;
            this.label4.Text = "NOMBRE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(12, 263);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(205, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 147;
            this.txt_nombre.Text = "Jerinel";
            this.txt_nombre.Validar = true;
            this.txt_nombre.TextChanged += new System.EventHandler(this.errorTxtBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 150;
            this.label5.Text = "FECHA NACIMIENTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(246, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 151;
            this.label6.Text = "DATOS CONTRATO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(247, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 157;
            this.label8.Text = "FECHA CONTRATO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(247, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 16);
            this.label10.TabIndex = 155;
            this.label10.Text = "DESCRIPCION CARGO";
            // 
            // txt_des_puesto
            // 
            this.txt_des_puesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des_puesto.Enabled = false;
            this.txt_des_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des_puesto.Limpiar = true;
            this.txt_des_puesto.Location = new System.Drawing.Point(247, 155);
            this.txt_des_puesto.Name = "txt_des_puesto";
            this.txt_des_puesto.Size = new System.Drawing.Size(245, 26);
            this.txt_des_puesto.SoloNumeros = false;
            this.txt_des_puesto.TabIndex = 154;
            this.txt_des_puesto.Validar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(247, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 153;
            this.label11.Text = "PUESTO";
            // 
            // txt_cargo
            // 
            this.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cargo.Enabled = false;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cargo.Limpiar = true;
            this.txt_cargo.Location = new System.Drawing.Point(247, 99);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(130, 26);
            this.txt_cargo.SoloNumeros = false;
            this.txt_cargo.TabIndex = 152;
            this.txt_cargo.Validar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(12, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 161;
            this.label12.Text = "SEXO";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cb_sexo
            // 
            this.cb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Location = new System.Drawing.Point(12, 422);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(114, 28);
            this.cb_sexo.TabIndex = 160;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btn_Cargo
            // 
            this.btn_Cargo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cargo.Image = global::_911_RD.Properties.Resources.search;
            this.btn_Cargo.Location = new System.Drawing.Point(345, 99);
            this.btn_Cargo.Name = "btn_Cargo";
            this.btn_Cargo.Size = new System.Drawing.Size(34, 26);
            this.btn_Cargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cargo.TabIndex = 162;
            this.btn_Cargo.TabStop = false;
            this.btn_Cargo.Click += new System.EventHandler(this.btn_Cargo_Click);
            // 
            // fecha_con
            // 
            this.fecha_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_con.Location = new System.Drawing.Point(250, 268);
            this.fecha_con.Name = "fecha_con";
            this.fecha_con.Size = new System.Drawing.Size(167, 22);
            this.fecha_con.TabIndex = 163;
            // 
            // fecha_nac
            // 
            this.fecha_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nac.Location = new System.Drawing.Point(12, 374);
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.Size = new System.Drawing.Size(167, 22);
            this.fecha_nac.TabIndex = 164;
            this.fecha_nac.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(247, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 166;
            this.label7.Text = "ESTADO";
            // 
            // cb_estado
            // 
            this.cb_estado.Enabled = false;
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(250, 369);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(114, 28);
            this.cb_estado.TabIndex = 165;
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
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_eme,
            this.SOLICITUD,
            this.tipo_eme,
            this.cedula,
            this.estado_eme,
            this.sexo,
            this.cargo,
            this.salario,
            this.fecha_contrato,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 564);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 204);
            this.dataGridView1.TabIndex = 167;
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 50F;
            this.id_eme.HeaderText = "ID";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // SOLICITUD
            // 
            this.SOLICITUD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOLICITUD.HeaderText = "NOMBRE";
            this.SOLICITUD.Name = "SOLICITUD";
            this.SOLICITUD.ReadOnly = true;
            // 
            // tipo_eme
            // 
            this.tipo_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_eme.HeaderText = "APELLIDO";
            this.tipo_eme.Name = "tipo_eme";
            this.tipo_eme.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cedula.HeaderText = "CEDULA";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // estado_eme
            // 
            this.estado_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado_eme.HeaderText = "FECHA DE NACIMIENTO";
            this.estado_eme.Name = "estado_eme";
            this.estado_eme.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexo.HeaderText = "SEXO";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargo.HeaderText = "PUESTO";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salario.HeaderText = "SALARIO";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // fecha_contrato
            // 
            this.fecha_contrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_contrato.HeaderText = "FECHA CONTRATO";
            this.fecha_contrato.Name = "fecha_contrato";
            this.fecha_contrato.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 80F;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 168;
            this.label1.Text = "IDENTIFICACION";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(12, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 170;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(94, 531);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 169;
            this.txt_filtro.Validar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(15, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 172;
            this.label14.Text = "APELLIDO";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_apellido.Limpiar = true;
            this.txt_apellido.Location = new System.Drawing.Point(12, 318);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(205, 26);
            this.txt_apellido.SoloNumeros = false;
            this.txt_apellido.TabIndex = 171;
            this.txt_apellido.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(247, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 174;
            this.label16.Text = "SALARIO";
            // 
            // txt_salario
            // 
            this.txt_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_salario.Enabled = false;
            this.txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_salario.Limpiar = true;
            this.txt_salario.Location = new System.Drawing.Point(247, 209);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(130, 26);
            this.txt_salario.SoloNumeros = true;
            this.txt_salario.TabIndex = 173;
            this.txt_salario.Validar = true;
            // 
            // p_direccion
            // 
            this.p_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.p_direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_direccion.Controls.Add(this.label26);
            this.p_direccion.Controls.Add(this.txt_correo);
            this.p_direccion.Controls.Add(this.label23);
            this.p_direccion.Controls.Add(this.txt_telefono);
            this.p_direccion.Location = new System.Drawing.Point(498, 78);
            this.p_direccion.Name = "p_direccion";
            this.p_direccion.Size = new System.Drawing.Size(427, 107);
            this.p_direccion.TabIndex = 177;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(3, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 16);
            this.label26.TabIndex = 197;
            this.label26.Text = "TELEFONO";
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_correo.Limpiar = true;
            this.txt_correo.Location = new System.Drawing.Point(140, 27);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(199, 26);
            this.txt_correo.SoloNumeros = false;
            this.txt_correo.TabIndex = 196;
            this.txt_correo.Validar = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(137, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 16);
            this.label23.TabIndex = 195;
            this.label23.Text = "CORREO";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefono.Limpiar = true;
            this.txt_telefono.Location = new System.Drawing.Point(6, 28);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(128, 26);
            this.txt_telefono.SoloNumeros = true;
            this.txt_telefono.TabIndex = 194;
            this.txt_telefono.Validar = true;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_contacto.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_contacto.Location = new System.Drawing.Point(494, 56);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(105, 19);
            this.lbl_contacto.TabIndex = 178;
            this.lbl_contacto.Text = "CONTACTOS";
            // 
            // lbl_conductor
            // 
            this.lbl_conductor.AutoSize = true;
            this.lbl_conductor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_conductor.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_conductor.Location = new System.Drawing.Point(494, 377);
            this.lbl_conductor.Name = "lbl_conductor";
            this.lbl_conductor.Size = new System.Drawing.Size(108, 19);
            this.lbl_conductor.TabIndex = 180;
            this.lbl_conductor.Text = "CONDUCTOR";
            this.lbl_conductor.Visible = false;
            // 
            // p_conductor
            // 
            this.p_conductor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.p_conductor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_conductor.Controls.Add(this.fecha_licencia);
            this.p_conductor.Controls.Add(this.label28);
            this.p_conductor.Controls.Add(this.label27);
            this.p_conductor.Controls.Add(this.txt_numlicencia);
            this.p_conductor.Location = new System.Drawing.Point(498, 399);
            this.p_conductor.Name = "p_conductor";
            this.p_conductor.Size = new System.Drawing.Size(427, 107);
            this.p_conductor.TabIndex = 179;
            this.p_conductor.Visible = false;
            // 
            // fecha_licencia
            // 
            this.fecha_licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_licencia.Location = new System.Drawing.Point(158, 30);
            this.fecha_licencia.Name = "fecha_licencia";
            this.fecha_licencia.Size = new System.Drawing.Size(167, 22);
            this.fecha_licencia.TabIndex = 191;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label28.Location = new System.Drawing.Point(158, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(164, 16);
            this.label28.TabIndex = 203;
            this.label28.Text = "FECHA DE VENCIMIENTO";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.Location = new System.Drawing.Point(3, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 16);
            this.label27.TabIndex = 201;
            this.label27.Text = "NUMERO DE LICENCIA";
            // 
            // txt_numlicencia
            // 
            this.txt_numlicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numlicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numlicencia.Limpiar = true;
            this.txt_numlicencia.Location = new System.Drawing.Point(6, 30);
            this.txt_numlicencia.Name = "txt_numlicencia";
            this.txt_numlicencia.Size = new System.Drawing.Size(146, 26);
            this.txt_numlicencia.SoloNumeros = true;
            this.txt_numlicencia.TabIndex = 198;
            this.txt_numlicencia.Validar = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Firebrick;
            this.label18.Location = new System.Drawing.Point(494, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 19);
            this.label18.TabIndex = 182;
            this.label18.Text = "DIRECCION";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txt_long);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btn_busc_dir);
            this.panel1.Controls.Add(this.lbl_estado_dir);
            this.panel1.Controls.Add(this.txt_lat);
            this.panel1.Location = new System.Drawing.Point(498, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 127);
            this.panel1.TabIndex = 181;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(3, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 197;
            this.label20.Text = "LONGITUD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(3, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 16);
            this.label19.TabIndex = 196;
            this.label19.Text = "LATITUD";
            // 
            // txt_long
            // 
            this.txt_long.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_long.Enabled = false;
            this.txt_long.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_long.Limpiar = true;
            this.txt_long.Location = new System.Drawing.Point(82, 69);
            this.txt_long.Name = "txt_long";
            this.txt_long.Size = new System.Drawing.Size(173, 26);
            this.txt_long.SoloNumeros = false;
            this.txt_long.TabIndex = 195;
            this.txt_long.Validar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 16);
            this.label17.TabIndex = 194;
            this.label17.Text = "BUSCAR DIRECCION";
            // 
            // btn_busc_dir
            // 
            this.btn_busc_dir.BackColor = System.Drawing.Color.LightGreen;
            this.btn_busc_dir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busc_dir.Image = global::_911_RD.Properties.Resources.search;
            this.btn_busc_dir.Location = new System.Drawing.Point(145, 3);
            this.btn_busc_dir.Name = "btn_busc_dir";
            this.btn_busc_dir.Size = new System.Drawing.Size(34, 26);
            this.btn_busc_dir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_busc_dir.TabIndex = 191;
            this.btn_busc_dir.TabStop = false;
            this.btn_busc_dir.Click += new System.EventHandler(this.btn_busc_dir_Click);
            // 
            // lbl_estado_dir
            // 
            this.lbl_estado_dir.AutoSize = true;
            this.lbl_estado_dir.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado_dir.ForeColor = System.Drawing.Color.Red;
            this.lbl_estado_dir.Location = new System.Drawing.Point(127, 98);
            this.lbl_estado_dir.Name = "lbl_estado_dir";
            this.lbl_estado_dir.Size = new System.Drawing.Size(128, 15);
            this.lbl_estado_dir.TabIndex = 193;
            this.lbl_estado_dir.Text = "DIRECCION SIN CARGAR";
            // 
            // txt_lat
            // 
            this.txt_lat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lat.Enabled = false;
            this.txt_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_lat.Limpiar = true;
            this.txt_lat.Location = new System.Drawing.Point(82, 37);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(173, 26);
            this.txt_lat.SoloNumeros = false;
            this.txt_lat.TabIndex = 191;
            this.txt_lat.Validar = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(247, 301);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 16);
            this.label22.TabIndex = 190;
            this.label22.Text = "NACIONALIDAD";
            // 
            // cb_nacionalidades
            // 
            this.cb_nacionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nacionalidades.FormattingEnabled = true;
            this.cb_nacionalidades.Location = new System.Drawing.Point(250, 320);
            this.cb_nacionalidades.Name = "cb_nacionalidades";
            this.cb_nacionalidades.Size = new System.Drawing.Size(167, 28);
            this.cb_nacionalidades.TabIndex = 189;
            this.cb_nacionalidades.SelectedIndexChanged += new System.EventHandler(this.cb_nacionalidades_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(9, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 16);
            this.label21.TabIndex = 192;
            this.label21.Text = "TIPO IDENTIFICACION";
            // 
            // cb_tipoIdent
            // 
            this.cb_tipoIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_tipoIdent.FormattingEnabled = true;
            this.cb_tipoIdent.Location = new System.Drawing.Point(12, 155);
            this.cb_tipoIdent.Name = "cb_tipoIdent";
            this.cb_tipoIdent.Size = new System.Drawing.Size(142, 28);
            this.cb_tipoIdent.TabIndex = 191;
            // 
            // txt_id_cargo
            // 
            this.txt_id_cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_cargo.Enabled = false;
            this.txt_id_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_cargo.Limpiar = true;
            this.txt_id_cargo.Location = new System.Drawing.Point(385, 99);
            this.txt_id_cargo.Name = "txt_id_cargo";
            this.txt_id_cargo.Size = new System.Drawing.Size(49, 26);
            this.txt_id_cargo.SoloNumeros = false;
            this.txt_id_cargo.TabIndex = 193;
            this.txt_id_cargo.Validar = true;
            // 
            // cb_puestos
            // 
            this.cb_puestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_puestos.FormattingEnabled = true;
            this.cb_puestos.Items.AddRange(new object[] {
            "TODOS"});
            this.cb_puestos.Location = new System.Drawing.Point(438, 529);
            this.cb_puestos.Name = "cb_puestos";
            this.cb_puestos.Size = new System.Drawing.Size(188, 24);
            this.cb_puestos.TabIndex = 194;
            this.cb_puestos.SelectedIndexChanged += new System.EventHandler(this.cb_puestos_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(310, 536);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 16);
            this.label24.TabIndex = 195;
            this.label24.Text = "CARGAR PUESTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_911_RD.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(270, 531);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 198;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cb_puestos);
            this.Controls.Add(this.txt_id_cargo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cb_tipoIdent);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cb_nacionalidades);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_conductor);
            this.Controls.Add(this.p_conductor);
            this.Controls.Add(this.lbl_contacto);
            this.Controls.Add(this.p_direccion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.fecha_nac);
            this.Controls.Add(this.fecha_con);
            this.Controls.Add(this.btn_Cargo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_des_puesto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_cedula);
            this.Name = "FrmEmpleado";
            this.Text = "W";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.Controls.SetChildIndex(this.txt_cedula, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_cargo, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txt_des_puesto, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cb_sexo, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.btn_Cargo, 0);
            this.Controls.SetChildIndex(this.fecha_con, 0);
            this.Controls.SetChildIndex(this.fecha_nac, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txt_salario, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.p_direccion, 0);
            this.Controls.SetChildIndex(this.lbl_contacto, 0);
            this.Controls.SetChildIndex(this.p_conductor, 0);
            this.Controls.SetChildIndex(this.lbl_conductor, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.cb_nacionalidades, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.cb_tipoIdent, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.txt_id_cargo, 0);
            this.Controls.SetChildIndex(this.cb_puestos, 0);
            this.Controls.SetChildIndex(this.label24, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.p_direccion.ResumeLayout(false);
            this.p_direccion.PerformLayout();
            this.p_conductor.ResumeLayout(false);
            this.p_conductor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_busc_dir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox errorTxtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox txt_cedula;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private ErrorTxtBox txt_des_puesto;
        private System.Windows.Forms.Label label11;
        private ErrorTxtBox txt_cargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_sexo;
        public System.Windows.Forms.PictureBox btn_Cargo;
        private System.Windows.Forms.DateTimePicker fecha_con;
        private System.Windows.Forms.DateTimePicker fecha_nac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        private System.Windows.Forms.Label label14;
        private ErrorTxtBox txt_apellido;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label16;
        private ErrorTxtBox txt_salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLICITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Panel p_direccion;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.Label lbl_conductor;
        private System.Windows.Forms.Panel p_conductor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_nacionalidades;
        private System.Windows.Forms.Label lbl_estado_dir;
        private System.Windows.Forms.Label label23;
        private ErrorTxtBox txt_telefono;
        private System.Windows.Forms.Label label26;
        private ErrorTxtBox txt_correo;
        private System.Windows.Forms.Label label27;
        private ErrorTxtBox txt_numlicencia;
        private System.Windows.Forms.DateTimePicker fecha_licencia;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.PictureBox btn_busc_dir;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        public ErrorTxtBox txt_lat;
        public ErrorTxtBox txt_long;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cb_tipoIdent;
        private ErrorTxtBox txt_id_cargo;
        private System.Windows.Forms.ComboBox cb_puestos;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}