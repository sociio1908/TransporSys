
namespace _911_RD.Administracion.Configuracion
{
    partial class FrmEmpresa
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
            this.txt_rnc = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.txt_lema = new _911_RD.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_web = new _911_RD.ErrorTxtBox();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 401);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(308, 32);
            this.lbl_titulo.Text = "DATOS DE LA EMPRESA";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(269, 401);
            this.btn_limpiar.Visible = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(157, 401);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            // 
            // txt_rnc
            // 
            this.txt_rnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_rnc.Limpiar = true;
            this.txt_rnc.Location = new System.Drawing.Point(12, 201);
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(144, 26);
            this.txt_rnc.SoloNumeros = false;
            this.txt_rnc.TabIndex = 187;
            this.txt_rnc.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 186;
            this.label2.Text = "RNC";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl.Location = new System.Drawing.Point(12, 133);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 16);
            this.lbl.TabIndex = 185;
            this.lbl.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(12, 152);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(243, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 184;
            this.txt_nombre.Validar = true;
            // 
            // txt_lema
            // 
            this.txt_lema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_lema.Limpiar = true;
            this.txt_lema.Location = new System.Drawing.Point(15, 300);
            this.txt_lema.Multiline = true;
            this.txt_lema.Name = "txt_lema";
            this.txt_lema.Size = new System.Drawing.Size(288, 52);
            this.txt_lema.SoloNumeros = false;
            this.txt_lema.TabIndex = 191;
            this.txt_lema.Validar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 190;
            this.label1.Text = "LEMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 189;
            this.label3.Text = "PAGINA WEB";
            // 
            // txt_web
            // 
            this.txt_web.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_web.Limpiar = true;
            this.txt_web.Location = new System.Drawing.Point(14, 249);
            this.txt_web.Name = "txt_web";
            this.txt_web.Size = new System.Drawing.Size(243, 26);
            this.txt_web.SoloNumeros = false;
            this.txt_web.TabIndex = 188;
            this.txt_web.Validar = true;
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
            this.tabla_direccion.Location = new System.Drawing.Point(325, 256);
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
            this.tabla_direccion.Size = new System.Drawing.Size(456, 85);
            this.tabla_direccion.TabIndex = 258;
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
            this.btn_direccion.Location = new System.Drawing.Point(388, 223);
            this.btn_direccion.Name = "btn_direccion";
            this.btn_direccion.Size = new System.Drawing.Size(32, 26);
            this.btn_direccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_direccion.TabIndex = 254;
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
            this.tabla_correo.Location = new System.Drawing.Point(562, 132);
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
            this.tabla_correo.TabIndex = 256;
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
            this.txt_id_direccion.Location = new System.Drawing.Point(325, 223);
            this.txt_id_direccion.Name = "txt_id_direccion";
            this.txt_id_direccion.Size = new System.Drawing.Size(95, 26);
            this.txt_id_direccion.SoloNumeros = false;
            this.txt_id_direccion.TabIndex = 257;
            this.txt_id_direccion.Validar = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(322, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 253;
            this.label17.Text = "DIRECCIONES";
            // 
            // btn_correo
            // 
            this.btn_correo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_correo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_correo.Image = global::_911_RD.Properties.Resources.search;
            this.btn_correo.Location = new System.Drawing.Point(607, 100);
            this.btn_correo.Name = "btn_correo";
            this.btn_correo.Size = new System.Drawing.Size(34, 26);
            this.btn_correo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_correo.TabIndex = 255;
            this.btn_correo.TabStop = false;
            this.btn_correo.Click += new System.EventHandler(this.btn_correo_Click);
            // 
            // btn_telefono
            // 
            this.btn_telefono.BackColor = System.Drawing.Color.LightGreen;
            this.btn_telefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telefono.Image = global::_911_RD.Properties.Resources.search;
            this.btn_telefono.Location = new System.Drawing.Point(369, 100);
            this.btn_telefono.Name = "btn_telefono";
            this.btn_telefono.Size = new System.Drawing.Size(34, 26);
            this.btn_telefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_telefono.TabIndex = 251;
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
            this.tabla_tel.Location = new System.Drawing.Point(325, 132);
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
            this.tabla_tel.TabIndex = 252;
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
            this.label26.Location = new System.Drawing.Point(322, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 16);
            this.label26.TabIndex = 250;
            this.label26.Text = "TELEFONOS";
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_correo.Limpiar = true;
            this.txt_correo.Location = new System.Drawing.Point(562, 100);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(79, 26);
            this.txt_correo.SoloNumeros = false;
            this.txt_correo.TabIndex = 249;
            this.txt_correo.Validar = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(559, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 248;
            this.label23.Text = "CORREOS";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefono.Limpiar = true;
            this.txt_telefono.Location = new System.Drawing.Point(325, 100);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(46, 26);
            this.txt_telefono.SoloNumeros = true;
            this.txt_telefono.TabIndex = 247;
            this.txt_telefono.Validar = false;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_contacto.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_contacto.Location = new System.Drawing.Point(321, 56);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(105, 19);
            this.lbl_contacto.TabIndex = 246;
            this.lbl_contacto.Text = "CONTACTOS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(322, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 16);
            this.label4.TabIndex = 260;
            this.label4.Text = "ORDENES AUTOMATICAS - (Prioridad)";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CALIDAD",
            "PRECIO",
            "TIEMPO ENTREGA"});
            this.comboBox1.Location = new System.Drawing.Point(325, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 261;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.txt_lema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_web);
            this.Controls.Add(this.txt_rnc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt_nombre);
            this.MaximumSize = new System.Drawing.Size(794, 478);
            this.MinimumSize = new System.Drawing.Size(794, 478);
            this.Name = "FrmEmpresa";
            this.Text = "FrmEmpresa";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_rnc, 0);
            this.Controls.SetChildIndex(this.txt_web, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_lema, 0);
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
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox txt_rnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private ErrorTxtBox txt_nombre;
        private ErrorTxtBox txt_lema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox txt_web;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}