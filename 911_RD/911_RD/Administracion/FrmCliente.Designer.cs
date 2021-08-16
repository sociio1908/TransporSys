
namespace _911_RD
{
    partial class FrmCliente
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
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.txt_error_cedula = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TipoCliente = new System.Windows.Forms.PictureBox();
            this.txt_tipo_cliente = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.txt_cedula = new _911_RD.ErrorTxtBox();
            this.txt_id_tipo_cliente = new _911_RD.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabla_direccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_direccion = new System.Windows.Forms.PictureBox();
            this.tabla_correo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id_direccion = new _911_RD.ErrorTxtBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_correo = new System.Windows.Forms.PictureBox();
            this.btn_telefono = new System.Windows.Forms.PictureBox();
            this.tabla_tel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_correo = new _911_RD.ErrorTxtBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_telefono = new _911_RD.ErrorTxtBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_ter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLICITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipoIdent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TipoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 366);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(115, 32);
            this.lbl_titulo.Text = "CLIENTE";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 366);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 366);
            // 
            // id_txt
            // 
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(123, 99);
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(259, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 185;
            this.label7.Text = "ESTADO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.Enabled = false;
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(322, 329);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(104, 28);
            this.cb_estado.TabIndex = 184;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(19, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 190;
            this.label13.Text = "BUSQUEDA";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(101, 422);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 189;
            this.txt_filtro.Validar = false;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // txt_error_cedula
            // 
            this.txt_error_cedula.AutoSize = true;
            this.txt_error_cedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_cedula.ForeColor = System.Drawing.Color.Red;
            this.txt_error_cedula.Location = new System.Drawing.Point(191, 271);
            this.txt_error_cedula.Name = "txt_error_cedula";
            this.txt_error_cedula.Size = new System.Drawing.Size(17, 16);
            this.txt_error_cedula.TabIndex = 231;
            this.txt_error_cedula.Text = "X";
            this.txt_error_cedula.Visible = false;
            this.txt_error_cedula.Click += new System.EventHandler(this.txt_error_cedula_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(12, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 16);
            this.label21.TabIndex = 230;
            this.label21.Text = "TIPO DE CLIENTE";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 228;
            this.label1.Text = "RNC/CEDULA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_TipoCliente
            // 
            this.btn_TipoCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btn_TipoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TipoCliente.Image = global::_911_RD.Properties.Resources.search;
            this.btn_TipoCliente.Location = new System.Drawing.Point(108, 163);
            this.btn_TipoCliente.Name = "btn_TipoCliente";
            this.btn_TipoCliente.Size = new System.Drawing.Size(34, 26);
            this.btn_TipoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TipoCliente.TabIndex = 227;
            this.btn_TipoCliente.TabStop = false;
            this.btn_TipoCliente.Click += new System.EventHandler(this.btn_TipoCliente_Click);
            // 
            // txt_tipo_cliente
            // 
            this.txt_tipo_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo_cliente.Enabled = false;
            this.txt_tipo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_tipo_cliente.Limpiar = true;
            this.txt_tipo_cliente.Location = new System.Drawing.Point(12, 163);
            this.txt_tipo_cliente.Name = "txt_tipo_cliente";
            this.txt_tipo_cliente.Size = new System.Drawing.Size(130, 26);
            this.txt_tipo_cliente.SoloNumeros = false;
            this.txt_tipo_cliente.TabIndex = 225;
            this.txt_tipo_cliente.Validar = true;
            this.txt_tipo_cliente.TextChanged += new System.EventHandler(this.txt_tipo_cliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 224;
            this.label4.Text = "NOMBRE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(15, 320);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(170, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 223;
            this.txt_nombre.Validar = true;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_cedula
            // 
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cedula.Limpiar = true;
            this.txt_cedula.Location = new System.Drawing.Point(15, 266);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(170, 26);
            this.txt_cedula.SoloNumeros = false;
            this.txt_cedula.TabIndex = 222;
            this.txt_cedula.Validar = true;
            this.txt_cedula.TextChanged += new System.EventHandler(this.txt_cedula_TextChanged);
            // 
            // txt_id_tipo_cliente
            // 
            this.txt_id_tipo_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_tipo_cliente.Enabled = false;
            this.txt_id_tipo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_tipo_cliente.Limpiar = true;
            this.txt_id_tipo_cliente.Location = new System.Drawing.Point(148, 163);
            this.txt_id_tipo_cliente.Name = "txt_id_tipo_cliente";
            this.txt_id_tipo_cliente.Size = new System.Drawing.Size(37, 26);
            this.txt_id_tipo_cliente.SoloNumeros = false;
            this.txt_id_tipo_cliente.TabIndex = 232;
            this.txt_id_tipo_cliente.Validar = true;
            this.txt_id_tipo_cliente.TextChanged += new System.EventHandler(this.txt_id_tipo_cliente_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabla_direccion
            // 
            this.tabla_direccion.AllowUserToAddRows = false;
            this.tabla_direccion.AllowUserToDeleteRows = false;
            this.tabla_direccion.AllowUserToResizeRows = false;
            this.tabla_direccion.BackgroundColor = System.Drawing.Color.White;
            this.tabla_direccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_direccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla_direccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_direccion.ColumnHeadersVisible = false;
            this.tabla_direccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabla_direccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabla_direccion.EnableHeadersVisualStyles = false;
            this.tabla_direccion.GridColor = System.Drawing.Color.White;
            this.tabla_direccion.Location = new System.Drawing.Point(259, 247);
            this.tabla_direccion.MultiSelect = false;
            this.tabla_direccion.Name = "tabla_direccion";
            this.tabla_direccion.ReadOnly = true;
            this.tabla_direccion.RowHeadersVisible = false;
            this.tabla_direccion.RowHeadersWidth = 15;
            this.tabla_direccion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tabla_direccion.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_direccion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_direccion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabla_direccion.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_direccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_direccion.Size = new System.Drawing.Size(456, 72);
            this.tabla_direccion.TabIndex = 245;
            this.tabla_direccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_direccion_CellContentClick);
            this.tabla_direccion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_direccion_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btn_direccion
            // 
            this.btn_direccion.BackColor = System.Drawing.Color.LightGreen;
            this.btn_direccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_direccion.Image = global::_911_RD.Properties.Resources.search;
            this.btn_direccion.Location = new System.Drawing.Point(322, 214);
            this.btn_direccion.Name = "btn_direccion";
            this.btn_direccion.Size = new System.Drawing.Size(32, 26);
            this.btn_direccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_direccion.TabIndex = 241;
            this.btn_direccion.TabStop = false;
            this.btn_direccion.Click += new System.EventHandler(this.btn_direccion_Click);
            // 
            // tabla_correo
            // 
            this.tabla_correo.AllowUserToAddRows = false;
            this.tabla_correo.AllowUserToDeleteRows = false;
            this.tabla_correo.AllowUserToResizeRows = false;
            this.tabla_correo.BackgroundColor = System.Drawing.Color.White;
            this.tabla_correo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_correo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla_correo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_correo.ColumnHeadersVisible = false;
            this.tabla_correo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tabla_correo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabla_correo.EnableHeadersVisualStyles = false;
            this.tabla_correo.GridColor = System.Drawing.Color.White;
            this.tabla_correo.Location = new System.Drawing.Point(496, 123);
            this.tabla_correo.MultiSelect = false;
            this.tabla_correo.Name = "tabla_correo";
            this.tabla_correo.ReadOnly = true;
            this.tabla_correo.RowHeadersVisible = false;
            this.tabla_correo.RowHeadersWidth = 15;
            this.tabla_correo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tabla_correo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_correo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_correo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabla_correo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_correo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_correo.Size = new System.Drawing.Size(219, 66);
            this.tabla_correo.TabIndex = 243;
            this.tabla_correo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_correo_CellContentClick);
            this.tabla_correo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_correo_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "correo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txt_id_direccion
            // 
            this.txt_id_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_direccion.Enabled = false;
            this.txt_id_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_direccion.Limpiar = true;
            this.txt_id_direccion.Location = new System.Drawing.Point(259, 214);
            this.txt_id_direccion.Name = "txt_id_direccion";
            this.txt_id_direccion.Size = new System.Drawing.Size(95, 26);
            this.txt_id_direccion.SoloNumeros = false;
            this.txt_id_direccion.TabIndex = 244;
            this.txt_id_direccion.Validar = false;
            this.txt_id_direccion.TextChanged += new System.EventHandler(this.txt_id_direccion_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(256, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 240;
            this.label17.Text = "DIRECCIONES";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btn_correo
            // 
            this.btn_correo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_correo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_correo.Image = global::_911_RD.Properties.Resources.search;
            this.btn_correo.Location = new System.Drawing.Point(541, 91);
            this.btn_correo.Name = "btn_correo";
            this.btn_correo.Size = new System.Drawing.Size(34, 26);
            this.btn_correo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_correo.TabIndex = 242;
            this.btn_correo.TabStop = false;
            this.btn_correo.Click += new System.EventHandler(this.btn_correo_Click);
            // 
            // btn_telefono
            // 
            this.btn_telefono.BackColor = System.Drawing.Color.LightGreen;
            this.btn_telefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telefono.Image = global::_911_RD.Properties.Resources.search;
            this.btn_telefono.Location = new System.Drawing.Point(303, 91);
            this.btn_telefono.Name = "btn_telefono";
            this.btn_telefono.Size = new System.Drawing.Size(34, 26);
            this.btn_telefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_telefono.TabIndex = 238;
            this.btn_telefono.TabStop = false;
            this.btn_telefono.Click += new System.EventHandler(this.btn_telefono_Click);
            // 
            // tabla_tel
            // 
            this.tabla_tel.AllowUserToAddRows = false;
            this.tabla_tel.AllowUserToDeleteRows = false;
            this.tabla_tel.AllowUserToResizeRows = false;
            this.tabla_tel.BackgroundColor = System.Drawing.Color.White;
            this.tabla_tel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_tel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_tel.ColumnHeadersVisible = false;
            this.tabla_tel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tabla_tel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabla_tel.EnableHeadersVisualStyles = false;
            this.tabla_tel.GridColor = System.Drawing.Color.White;
            this.tabla_tel.Location = new System.Drawing.Point(259, 123);
            this.tabla_tel.MultiSelect = false;
            this.tabla_tel.Name = "tabla_tel";
            this.tabla_tel.ReadOnly = true;
            this.tabla_tel.RowHeadersVisible = false;
            this.tabla_tel.RowHeadersWidth = 15;
            this.tabla_tel.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tabla_tel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla_tel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_tel.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabla_tel.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_tel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_tel.Size = new System.Drawing.Size(231, 66);
            this.tabla_tel.TabIndex = 239;
            this.tabla_tel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_tel_CellContentClick);
            this.tabla_tel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_tel_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(256, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 16);
            this.label26.TabIndex = 237;
            this.label26.Text = "TELEFONOS";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_correo.Limpiar = true;
            this.txt_correo.Location = new System.Drawing.Point(496, 91);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(79, 26);
            this.txt_correo.SoloNumeros = false;
            this.txt_correo.TabIndex = 236;
            this.txt_correo.Validar = false;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(493, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 235;
            this.label23.Text = "CORREOS";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefono.Limpiar = true;
            this.txt_telefono.Location = new System.Drawing.Point(259, 91);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(46, 26);
            this.txt_telefono.SoloNumeros = true;
            this.txt_telefono.TabIndex = 234;
            this.txt_telefono.Validar = false;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_contacto.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_contacto.Location = new System.Drawing.Point(255, 47);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(105, 19);
            this.lbl_contacto.TabIndex = 233;
            this.lbl_contacto.Text = "CONTACTOS";
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
            this.id_ter,
            this.id_pue,
            this.id_tipo_identificacion,
            this.id_eme,
            this.SOLICITUD,
            this.cedula,
            this.tipo_eme,
            this.estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 459);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 204);
            this.dataGridView1.TabIndex = 246;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_ter
            // 
            this.id_ter.HeaderText = "id_tercero";
            this.id_ter.Name = "id_ter";
            this.id_ter.ReadOnly = true;
            this.id_ter.Visible = false;
            // 
            // id_pue
            // 
            this.id_pue.HeaderText = "id_tipo_cliente";
            this.id_pue.Name = "id_pue";
            this.id_pue.ReadOnly = true;
            this.id_pue.Visible = false;
            // 
            // id_tipo_identificacion
            // 
            this.id_tipo_identificacion.HeaderText = "id_tipo_identificacion";
            this.id_tipo_identificacion.Name = "id_tipo_identificacion";
            this.id_tipo_identificacion.ReadOnly = true;
            this.id_tipo_identificacion.Visible = false;
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.id_eme.DefaultCellStyle = dataGridViewCellStyle2;
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
            // cedula
            // 
            this.cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cedula.HeaderText = "CEDULA";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // tipo_eme
            // 
            this.tipo_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_eme.HeaderText = "TIPO CLIENTE";
            this.tipo_eme.Name = "tipo_eme";
            this.tipo_eme.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 80F;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 248;
            this.label2.Text = "TIPO IDENTIFICACION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_tipoIdent
            // 
            this.cb_tipoIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_tipoIdent.FormattingEnabled = true;
            this.cb_tipoIdent.Location = new System.Drawing.Point(15, 217);
            this.cb_tipoIdent.Name = "cb_tipoIdent";
            this.cb_tipoIdent.Size = new System.Drawing.Size(142, 28);
            this.cb_tipoIdent.TabIndex = 247;
            this.cb_tipoIdent.SelectedIndexChanged += new System.EventHandler(this.cb_tipoIdent_SelectedIndexChanged);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tipoIdent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabla_direccion);
            this.Controls.Add(this.btn_direccion);
            this.Controls.Add(this.tabla_correo);
            this.Controls.Add(this.txt_id_direccion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_correo);
            this.Controls.Add(this.btn_telefono);
            this.Controls.Add(this.tabla_tel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_contacto);
            this.Controls.Add(this.txt_id_tipo_cliente);
            this.Controls.Add(this.txt_error_cedula);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TipoCliente);
            this.Controls.Add(this.txt_tipo_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_estado);
            this.Name = "FrmCliente";
            this.Text = "CLIENTES";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txt_cedula, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_tipo_cliente, 0);
            this.Controls.SetChildIndex(this.btn_TipoCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.txt_error_cedula, 0);
            this.Controls.SetChildIndex(this.txt_id_tipo_cliente, 0);
            this.Controls.SetChildIndex(this.lbl_contacto, 0);
            this.Controls.SetChildIndex(this.txt_telefono, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.txt_correo, 0);
            this.Controls.SetChildIndex(this.label26, 0);
            this.Controls.SetChildIndex(this.tabla_tel, 0);
            this.Controls.SetChildIndex(this.btn_telefono, 0);
            this.Controls.SetChildIndex(this.btn_correo, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txt_id_direccion, 0);
            this.Controls.SetChildIndex(this.tabla_correo, 0);
            this.Controls.SetChildIndex(this.btn_direccion, 0);
            this.Controls.SetChildIndex(this.tabla_direccion, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.cb_tipoIdent, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TipoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        private System.Windows.Forms.Label txt_error_cedula;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox btn_TipoCliente;
        private ErrorTxtBox txt_tipo_cliente;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox txt_nombre;
        private ErrorTxtBox txt_cedula;
        private ErrorTxtBox txt_id_tipo_cliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView tabla_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.PictureBox btn_direccion;
        public System.Windows.Forms.DataGridView tabla_correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ErrorTxtBox txt_id_direccion;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.PictureBox btn_correo;
        public System.Windows.Forms.PictureBox btn_telefono;
        public System.Windows.Forms.DataGridView tabla_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label26;
        private ErrorTxtBox txt_correo;
        private System.Windows.Forms.Label label23;
        private ErrorTxtBox txt_telefono;
        private System.Windows.Forms.Label lbl_contacto;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipoIdent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pue;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLICITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}