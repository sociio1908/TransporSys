
namespace _911_RD.Administracion
{
    partial class FrmDireccionNativa
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
            this.label22 = new System.Windows.Forms.Label();
            this.cb_continente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ciudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion = new _911_RD.ErrorTxtBox();
            this.bt_agregar_pais = new System.Windows.Forms.Button();
            this.bt_agregar_ciu = new System.Windows.Forms.Button();
            this.btn_agregar_provincia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contienente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_agregar_cont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(8, 44);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(11, 252);
            this.btn_guardar.Size = new System.Drawing.Size(144, 44);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Size = new System.Drawing.Size(237, 25);
            this.lbl_titulo.Text = "AGREGAR DIRECCION";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(164, 252);
            this.btn_limpiar.Size = new System.Drawing.Size(120, 44);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(290, 252);
            this.btn_salir.Size = new System.Drawing.Size(106, 44);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 76);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Location = new System.Drawing.Point(38, 68);
            this.id_txt.Size = new System.Drawing.Size(106, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(150, 68);
            this.btn_buscar.Size = new System.Drawing.Size(33, 29);
            this.btn_buscar.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(8, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 16);
            this.label22.TabIndex = 192;
            this.label22.Text = "Continente";
            // 
            // cb_continente
            // 
            this.cb_continente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_continente.FormattingEnabled = true;
            this.cb_continente.Location = new System.Drawing.Point(11, 119);
            this.cb_continente.Name = "cb_continente";
            this.cb_continente.Size = new System.Drawing.Size(238, 28);
            this.cb_continente.TabIndex = 191;
            this.cb_continente.SelectedValueChanged += new System.EventHandler(this.cb_continente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 194;
            this.label1.Text = "Pais";
            // 
            // cb_pais
            // 
            this.cb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Location = new System.Drawing.Point(11, 169);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(238, 28);
            this.cb_pais.TabIndex = 193;
            this.cb_pais.SelectedValueChanged += new System.EventHandler(this.cb_pais_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(287, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 196;
            this.label2.Text = "Provincia";
            // 
            // cb_provincia
            // 
            this.cb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_provincia.FormattingEnabled = true;
            this.cb_provincia.Location = new System.Drawing.Point(290, 119);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(229, 28);
            this.cb_provincia.TabIndex = 195;
            this.cb_provincia.SelectedValueChanged += new System.EventHandler(this.cb_provincia_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(290, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 198;
            this.label3.Text = "Ciudad";
            // 
            // cb_ciudad
            // 
            this.cb_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudad.FormattingEnabled = true;
            this.cb_ciudad.Location = new System.Drawing.Point(293, 168);
            this.cb_ciudad.Name = "cb_ciudad";
            this.cb_ciudad.Size = new System.Drawing.Size(226, 28);
            this.cb_ciudad.TabIndex = 197;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 207;
            this.label5.Text = "Descripcion guia";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Limpiar = true;
            this.txt_descripcion.Location = new System.Drawing.Point(14, 220);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(370, 26);
            this.txt_descripcion.SoloNumeros = false;
            this.txt_descripcion.TabIndex = 206;
            this.txt_descripcion.Validar = true;
            // 
            // bt_agregar_pais
            // 
            this.bt_agregar_pais.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_pais.Enabled = false;
            this.bt_agregar_pais.FlatAppearance.BorderSize = 0;
            this.bt_agregar_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_pais.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_pais.Location = new System.Drawing.Point(255, 169);
            this.bt_agregar_pais.Name = "bt_agregar_pais";
            this.bt_agregar_pais.Size = new System.Drawing.Size(29, 28);
            this.bt_agregar_pais.TabIndex = 209;
            this.bt_agregar_pais.Text = "+";
            this.bt_agregar_pais.UseVisualStyleBackColor = false;
            this.bt_agregar_pais.Click += new System.EventHandler(this.bt_agregar_pais_Click);
            // 
            // bt_agregar_ciu
            // 
            this.bt_agregar_ciu.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_ciu.Enabled = false;
            this.bt_agregar_ciu.FlatAppearance.BorderSize = 0;
            this.bt_agregar_ciu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_ciu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_ciu.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_ciu.Location = new System.Drawing.Point(525, 166);
            this.bt_agregar_ciu.Name = "bt_agregar_ciu";
            this.bt_agregar_ciu.Size = new System.Drawing.Size(29, 28);
            this.bt_agregar_ciu.TabIndex = 211;
            this.bt_agregar_ciu.Text = "+";
            this.bt_agregar_ciu.UseVisualStyleBackColor = false;
            this.bt_agregar_ciu.Click += new System.EventHandler(this.bt_agregar_ciu_Click);
            // 
            // btn_agregar_provincia
            // 
            this.btn_agregar_provincia.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_agregar_provincia.Enabled = false;
            this.btn_agregar_provincia.FlatAppearance.BorderSize = 0;
            this.btn_agregar_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_provincia.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_provincia.Location = new System.Drawing.Point(526, 116);
            this.btn_agregar_provincia.Name = "btn_agregar_provincia";
            this.btn_agregar_provincia.Size = new System.Drawing.Size(29, 28);
            this.btn_agregar_provincia.TabIndex = 210;
            this.btn_agregar_provincia.Text = "+";
            this.btn_agregar_provincia.UseVisualStyleBackColor = false;
            this.btn_agregar_provincia.Click += new System.EventHandler(this.btn_agregar_provincia_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(14, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 214;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(96, 302);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(300, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 213;
            this.txt_filtro.Validar = false;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
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
            this.descripcion,
            this.id_continente,
            this.contienente,
            this.id_pais,
            this.continente,
            this.id_provincia,
            this.Provincia,
            this.id_ciudad,
            this.ciudad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 334);
            this.dataGridView1.MultiSelect = false;
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
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 184);
            this.dataGridView1.TabIndex = 212;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 20F;
            this.id_eme.HeaderText = "ID";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_continente
            // 
            this.id_continente.HeaderText = "id_continente";
            this.id_continente.Name = "id_continente";
            this.id_continente.ReadOnly = true;
            this.id_continente.Visible = false;
            // 
            // contienente
            // 
            this.contienente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contienente.FillWeight = 50F;
            this.contienente.HeaderText = "CONTINENTE";
            this.contienente.Name = "contienente";
            this.contienente.ReadOnly = true;
            // 
            // id_pais
            // 
            this.id_pais.HeaderText = "id_pais";
            this.id_pais.Name = "id_pais";
            this.id_pais.ReadOnly = true;
            this.id_pais.Visible = false;
            // 
            // continente
            // 
            this.continente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.continente.FillWeight = 80F;
            this.continente.HeaderText = "PAIS";
            this.continente.Name = "continente";
            this.continente.ReadOnly = true;
            // 
            // id_provincia
            // 
            this.id_provincia.HeaderText = "id_provincia";
            this.id_provincia.Name = "id_provincia";
            this.id_provincia.ReadOnly = true;
            this.id_provincia.Visible = false;
            // 
            // Provincia
            // 
            this.Provincia.FillWeight = 80F;
            this.Provincia.HeaderText = "PROVINCIA";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // id_ciudad
            // 
            this.id_ciudad.HeaderText = "id_ciudad";
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            this.id_ciudad.Visible = false;
            // 
            // ciudad
            // 
            this.ciudad.FillWeight = 95F;
            this.ciudad.HeaderText = "CIUDAD";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // bt_agregar_cont
            // 
            this.bt_agregar_cont.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_cont.FlatAppearance.BorderSize = 0;
            this.bt_agregar_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_cont.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_cont.Location = new System.Drawing.Point(255, 120);
            this.bt_agregar_cont.Name = "bt_agregar_cont";
            this.bt_agregar_cont.Size = new System.Drawing.Size(29, 28);
            this.bt_agregar_cont.TabIndex = 208;
            this.bt_agregar_cont.Text = "+";
            this.bt_agregar_cont.UseVisualStyleBackColor = false;
            this.bt_agregar_cont.Click += new System.EventHandler(this.bt_agregar_cont_Click);
            // 
            // FrmDireccionNativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 530);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_agregar_ciu);
            this.Controls.Add(this.btn_agregar_provincia);
            this.Controls.Add(this.bt_agregar_pais);
            this.Controls.Add(this.bt_agregar_cont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_provincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pais);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cb_continente);
            this.Name = "FrmDireccionNativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDireccionNativa";
            this.Load += new System.EventHandler(this.FrmDireccionNativa_Load);
            this.Controls.SetChildIndex(this.cb_continente, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.cb_pais, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cb_provincia, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cb_ciudad, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.bt_agregar_cont, 0);
            this.Controls.SetChildIndex(this.bt_agregar_pais, 0);
            this.Controls.SetChildIndex(this.btn_agregar_provincia, 0);
            this.Controls.SetChildIndex(this.bt_agregar_ciu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_agregar_pais;
        private System.Windows.Forms.Button bt_agregar_ciu;
        private System.Windows.Forms.Button btn_agregar_provincia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox cb_continente;
        public System.Windows.Forms.ComboBox cb_pais;
        public System.Windows.Forms.ComboBox cb_provincia;
        public System.Windows.Forms.ComboBox cb_ciudad;
        public ErrorTxtBox txt_descripcion;
        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn contienente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.Button bt_agregar_cont;
    }
}