
namespace _911_RD.Administracion.Transporte
{
    partial class FrmTransporte
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_addDr = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id_desde = new _911_RD.ErrorTxtBox();
            this.txt_desde = new _911_RD.ErrorTxtBox();
            this.txt_id_hasta = new _911_RD.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_emp = new _911_RD.ErrorTxtBox();
            this.btn_und = new System.Windows.Forms.PictureBox();
            this.txt_emp = new _911_RD.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_tra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_vehiculo = new _911_RD.ErrorTxtBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_transporte = new _911_RD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addDr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_und)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_salir.BackColor = System.Drawing.Color.Firebrick;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = global::_911_RD.Properties.Resources.cancel32x32;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(314, 594);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 50);
            this.btn_salir.TabIndex = 147;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Image = global::_911_RD.Properties.Resources.limpiar;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(192, 594);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 50);
            this.btn_limpiar.TabIndex = 146;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(7, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 19);
            this.label15.TabIndex = 145;
            this.label15.Text = "DATOS GENERALES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(7, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 144;
            this.label9.Text = "DESDE";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_guardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::_911_RD.Properties.Resources.save_32x32;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(10, 594);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(176, 50);
            this.btn_guardar.TabIndex = 143;
            this.btn_guardar.Text = "SELECCIONAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(531, 32);
            this.lbl_titulo.TabIndex = 142;
            this.lbl_titulo.Text = "ASIGNAR DIRECCIONES DE TRANSPORTE";
            // 
            // btn_addDr
            // 
            this.btn_addDr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDr.Image = global::_911_RD.Properties.Resources.list2;
            this.btn_addDr.Location = new System.Drawing.Point(426, 345);
            this.btn_addDr.Name = "btn_addDr";
            this.btn_addDr.Size = new System.Drawing.Size(35, 29);
            this.btn_addDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addDr.TabIndex = 163;
            this.btn_addDr.TabStop = false;
            this.btn_addDr.Click += new System.EventHandler(this.btn_Cargo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(10, 380);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 208);
            this.dataGridView1.TabIndex = 168;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 80F;
            this.dataGridViewTextBoxColumn7.HeaderText = "ciudad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.FillWeight = 60F;
            this.dataGridViewTextBoxColumn8.HeaderText = "pais";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // txt_id_desde
            // 
            this.txt_id_desde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_desde.Enabled = false;
            this.txt_id_desde.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_desde.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_id_desde.Limpiar = true;
            this.txt_id_desde.Location = new System.Drawing.Point(60, 295);
            this.txt_id_desde.Name = "txt_id_desde";
            this.txt_id_desde.Size = new System.Drawing.Size(51, 21);
            this.txt_id_desde.SoloNumeros = false;
            this.txt_id_desde.TabIndex = 165;
            this.txt_id_desde.Validar = true;
            // 
            // txt_desde
            // 
            this.txt_desde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_desde.Limpiar = true;
            this.txt_desde.Location = new System.Drawing.Point(10, 345);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(410, 29);
            this.txt_desde.SoloNumeros = false;
            this.txt_desde.TabIndex = 148;
            this.txt_desde.Validar = true;
            this.txt_desde.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // txt_id_hasta
            // 
            this.txt_id_hasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_hasta.Enabled = false;
            this.txt_id_hasta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_hasta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_id_hasta.Limpiar = true;
            this.txt_id_hasta.Location = new System.Drawing.Point(170, 294);
            this.txt_id_hasta.Name = "txt_id_hasta";
            this.txt_id_hasta.Size = new System.Drawing.Size(51, 21);
            this.txt_id_hasta.SoloNumeros = false;
            this.txt_id_hasta.TabIndex = 170;
            this.txt_id_hasta.Validar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(117, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 169;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 171;
            this.label2.Text = "FILTRE LA DIRECCION AQUI";
            // 
            // txt_id_emp
            // 
            this.txt_id_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_emp.Enabled = false;
            this.txt_id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_emp.Limpiar = true;
            this.txt_id_emp.Location = new System.Drawing.Point(202, 170);
            this.txt_id_emp.Name = "txt_id_emp";
            this.txt_id_emp.Size = new System.Drawing.Size(49, 26);
            this.txt_id_emp.SoloNumeros = true;
            this.txt_id_emp.TabIndex = 236;
            this.txt_id_emp.Validar = true;
            // 
            // btn_und
            // 
            this.btn_und.BackColor = System.Drawing.Color.LightGreen;
            this.btn_und.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_und.Image = global::_911_RD.Properties.Resources.search;
            this.btn_und.Location = new System.Drawing.Point(165, 170);
            this.btn_und.Name = "btn_und";
            this.btn_und.Size = new System.Drawing.Size(34, 26);
            this.btn_und.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_und.TabIndex = 235;
            this.btn_und.TabStop = false;
            this.btn_und.Click += new System.EventHandler(this.btn_und_Click);
            // 
            // txt_emp
            // 
            this.txt_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emp.Enabled = false;
            this.txt_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_emp.Limpiar = true;
            this.txt_emp.Location = new System.Drawing.Point(12, 170);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(187, 26);
            this.txt_emp.SoloNumeros = false;
            this.txt_emp.TabIndex = 234;
            this.txt_emp.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 233;
            this.label3.Text = "CONDUCTOR";
            // 
            // fecha_tra
            // 
            this.fecha_tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_tra.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fecha_tra.Location = new System.Drawing.Point(15, 114);
            this.fecha_tra.Name = "fecha_tra";
            this.fecha_tra.Size = new System.Drawing.Size(134, 22);
            this.fecha_tra.TabIndex = 240;
            this.fecha_tra.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 239;
            this.label4.Text = "FECHA Y HORA";
            // 
            // txt_id_vehiculo
            // 
            this.txt_id_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_vehiculo.Enabled = false;
            this.txt_id_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_vehiculo.Limpiar = true;
            this.txt_id_vehiculo.Location = new System.Drawing.Point(18, 235);
            this.txt_id_vehiculo.Name = "txt_id_vehiculo";
            this.txt_id_vehiculo.Size = new System.Drawing.Size(74, 26);
            this.txt_id_vehiculo.SoloNumeros = true;
            this.txt_id_vehiculo.TabIndex = 244;
            this.txt_id_vehiculo.Validar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_911_RD.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(98, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 243;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 241;
            this.label5.Text = "ID VEHICULO";
            // 
            // txt_id_transporte
            // 
            this.txt_id_transporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_transporte.Enabled = false;
            this.txt_id_transporte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_transporte.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_id_transporte.Limpiar = true;
            this.txt_id_transporte.Location = new System.Drawing.Point(15, 74);
            this.txt_id_transporte.Name = "txt_id_transporte";
            this.txt_id_transporte.Size = new System.Drawing.Size(51, 21);
            this.txt_id_transporte.SoloNumeros = false;
            this.txt_id_transporte.TabIndex = 245;
            this.txt_id_transporte.Validar = false;
            this.txt_id_transporte.Visible = false;
            this.txt_id_transporte.TextChanged += new System.EventHandler(this.txt_id_transporte_TextChanged);
            // 
            // FrmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 656);
            this.Controls.Add(this.txt_id_transporte);
            this.Controls.Add(this.txt_id_vehiculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_tra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_emp);
            this.Controls.Add(this.btn_und);
            this.Controls.Add(this.txt_emp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_hasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_id_desde);
            this.Controls.Add(this.btn_addDr);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransporte";
            ((System.ComponentModel.ISupportInitialize)(this.btn_addDr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_und)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Label lbl_titulo;
        public ErrorTxtBox txt_desde;
        public System.Windows.Forms.PictureBox btn_addDr;
        public ErrorTxtBox txt_id_desde;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public ErrorTxtBox txt_id_hasta;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox btn_und;
        private ErrorTxtBox txt_emp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public ErrorTxtBox txt_id_emp;
        public System.Windows.Forms.DateTimePicker fecha_tra;
        public ErrorTxtBox txt_id_vehiculo;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        public ErrorTxtBox txt_id_transporte;
    }
}