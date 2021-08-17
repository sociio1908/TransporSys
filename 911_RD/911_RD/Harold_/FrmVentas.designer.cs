
namespace _911_RD.Administracion
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_porcentaje_itb = new _911_RD.ErrorTxtBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_des = new _911_RD.ErrorTxtBox();
            this.txt_codBarra = new System.Windows.Forms.TextBox();
            this.pnl_cod = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new _911_RD.ErrorTxtBox();
            this.btn_traer = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_impTotal = new _911_RD.ErrorTxtBox();
            this.txt_impuesto = new _911_RD.ErrorTxtBox();
            this.txt_subtotal = new _911_RD.ErrorTxtBox();
            this.txt_descuento = new _911_RD.ErrorTxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_id_cliente = new _911_RD.ErrorTxtBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new _911_RD.ErrorTxtBox();
            this.bt_agregar_cont = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_descuentoEmple = new _911_RD.ErrorTxtBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_limpiar_cantidad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_factura = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_id = new _911_RD.ErrorTxtBox();
            this.txt_numfactura = new _911_RD.ErrorTxtBox();
            this.txt_cantidad = new _911_RD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulos,
            this.articulo,
            this.cantidad,
            this.precio,
            this.itbis,
            this.descuento,
            this.total});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(46, 268);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(791, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Size = new System.Drawing.Size(791, 228);
            this.dataGridView1.TabIndex = 203;
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // id_articulos
            // 
            this.id_articulos.HeaderText = "ID";
            this.id_articulos.Name = "id_articulos";
            this.id_articulos.ReadOnly = true;
            this.id_articulos.Width = 90;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "ARTICULO";
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Width = 180;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 105;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.Width = 110;
            // 
            // itbis
            // 
            this.itbis.HeaderText = "ITBIS %";
            this.itbis.Name = "itbis";
            // 
            // descuento
            // 
            this.descuento.HeaderText = "DESCUENTO %";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_porcentaje_itb);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_des);
            this.groupBox1.Controls.Add(this.txt_codBarra);
            this.groupBox1.Controls.Add(this.pnl_cod);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.btn_traer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(46, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 170);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FACTURACION";
            // 
            // txt_porcentaje_itb
            // 
            this.txt_porcentaje_itb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_porcentaje_itb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_porcentaje_itb.Limpiar = true;
            this.txt_porcentaje_itb.Location = new System.Drawing.Point(344, 47);
            this.txt_porcentaje_itb.Name = "txt_porcentaje_itb";
            this.txt_porcentaje_itb.ReadOnly = true;
            this.txt_porcentaje_itb.Size = new System.Drawing.Size(76, 26);
            this.txt_porcentaje_itb.SoloNumeros = false;
            this.txt_porcentaje_itb.TabIndex = 207;
            this.txt_porcentaje_itb.Validar = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(341, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 16);
            this.label21.TabIndex = 206;
            this.label21.Text = "ITBIS %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(466, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 200;
            this.label5.Text = "CODIGO DE BARRA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 199;
            this.label1.Text = "DESCRIPCION";
            // 
            // txt_des
            // 
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des.Limpiar = true;
            this.txt_des.Location = new System.Drawing.Point(35, 120);
            this.txt_des.Name = "txt_des";
            this.txt_des.ReadOnly = true;
            this.txt_des.Size = new System.Drawing.Size(132, 26);
            this.txt_des.SoloNumeros = false;
            this.txt_des.TabIndex = 198;
            this.txt_des.Validar = true;
            // 
            // txt_codBarra
            // 
            this.txt_codBarra.Location = new System.Drawing.Point(445, 119);
            this.txt_codBarra.Name = "txt_codBarra";
            this.txt_codBarra.Size = new System.Drawing.Size(210, 27);
            this.txt_codBarra.TabIndex = 196;
            this.txt_codBarra.TextChanged += new System.EventHandler(this.txt_codBarra_TextChanged);
            this.txt_codBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codBarra_KeyPress);
            // 
            // pnl_cod
            // 
            this.pnl_cod.Location = new System.Drawing.Point(445, 47);
            this.pnl_cod.Name = "pnl_cod";
            this.pnl_cod.Size = new System.Drawing.Size(210, 70);
            this.pnl_cod.TabIndex = 197;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(32, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 188;
            this.label10.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(35, 47);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(132, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 185;
            this.txt_nombre.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(190, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 189;
            this.label2.Text = "STOCK";
            // 
            // txt_stock
            // 
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Limpiar = true;
            this.txt_stock.Location = new System.Drawing.Point(193, 47);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(114, 26);
            this.txt_stock.SoloNumeros = false;
            this.txt_stock.TabIndex = 186;
            this.txt_stock.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(190, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 190;
            this.label4.Text = "PRECIO";
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_precio.Limpiar = true;
            this.txt_precio.Location = new System.Drawing.Point(193, 121);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.ReadOnly = true;
            this.txt_precio.Size = new System.Drawing.Size(114, 26);
            this.txt_precio.SoloNumeros = false;
            this.txt_precio.TabIndex = 187;
            this.txt_precio.Validar = true;
            // 
            // btn_traer
            // 
            this.btn_traer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_traer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_traer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_traer.FlatAppearance.BorderSize = 0;
            this.btn_traer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_traer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_traer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_traer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traer.Location = new System.Drawing.Point(681, 47);
            this.btn_traer.Name = "btn_traer";
            this.btn_traer.Size = new System.Drawing.Size(92, 83);
            this.btn_traer.TabIndex = 205;
            this.btn_traer.Text = " BUSCAR PRODUCTO";
            this.btn_traer.UseVisualStyleBackColor = false;
            this.btn_traer.Click += new System.EventHandler(this.btn_traer_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_1.Location = new System.Drawing.Point(918, 136);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(62, 60);
            this.btn_1.TabIndex = 208;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_2.Location = new System.Drawing.Point(986, 136);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(62, 60);
            this.btn_2.TabIndex = 209;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_3.Location = new System.Drawing.Point(1054, 136);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(62, 60);
            this.btn_3.TabIndex = 210;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_4.Location = new System.Drawing.Point(918, 202);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(62, 60);
            this.btn_4.TabIndex = 212;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_5.Location = new System.Drawing.Point(986, 202);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(62, 60);
            this.btn_5.TabIndex = 213;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_6.Location = new System.Drawing.Point(1054, 202);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(62, 60);
            this.btn_6.TabIndex = 214;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_7.Location = new System.Drawing.Point(918, 268);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(62, 60);
            this.btn_7.TabIndex = 215;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_8.Location = new System.Drawing.Point(986, 268);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(62, 60);
            this.btn_8.TabIndex = 216;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_9.Location = new System.Drawing.Point(1054, 268);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(62, 60);
            this.btn_9.TabIndex = 217;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_0.Location = new System.Drawing.Point(1122, 136);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(62, 192);
            this.btn_0.TabIndex = 219;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(915, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 200;
            this.label3.Text = "CANTIDAD DE ARTICULOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_impTotal);
            this.groupBox2.Controls.Add(this.txt_impuesto);
            this.groupBox2.Controls.Add(this.txt_subtotal);
            this.groupBox2.Controls.Add(this.txt_descuento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(423, 509);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 141);
            this.groupBox2.TabIndex = 222;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOTAL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(163, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 21);
            this.label14.TabIndex = 206;
            this.label14.Text = "RD$";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(15, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 23);
            this.label13.TabIndex = 205;
            this.label13.Text = "IMPORTE TOTAL:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_impTotal
            // 
            this.txt_impTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txt_impTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_impTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_impTotal.ForeColor = System.Drawing.Color.Red;
            this.txt_impTotal.Limpiar = true;
            this.txt_impTotal.Location = new System.Drawing.Point(208, 90);
            this.txt_impTotal.Multiline = true;
            this.txt_impTotal.Name = "txt_impTotal";
            this.txt_impTotal.ReadOnly = true;
            this.txt_impTotal.Size = new System.Drawing.Size(178, 30);
            this.txt_impTotal.SoloNumeros = true;
            this.txt_impTotal.TabIndex = 204;
            this.txt_impTotal.Text = "0.0";
            this.txt_impTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_impTotal.Validar = false;
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txt_impuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_impuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_impuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_impuesto.Limpiar = true;
            this.txt_impuesto.Location = new System.Drawing.Point(304, 56);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.ReadOnly = true;
            this.txt_impuesto.Size = new System.Drawing.Size(82, 19);
            this.txt_impuesto.SoloNumeros = false;
            this.txt_impuesto.TabIndex = 203;
            this.txt_impuesto.Text = "0.0";
            this.txt_impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_impuesto.Validar = true;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_subtotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_subtotal.Limpiar = true;
            this.txt_subtotal.Location = new System.Drawing.Point(304, 26);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(82, 19);
            this.txt_subtotal.SoloNumeros = false;
            this.txt_subtotal.TabIndex = 202;
            this.txt_subtotal.Text = "0.0";
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_subtotal.Validar = true;
            // 
            // txt_descuento
            // 
            this.txt_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txt_descuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descuento.Limpiar = true;
            this.txt_descuento.Location = new System.Drawing.Point(117, 24);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.ReadOnly = true;
            this.txt_descuento.Size = new System.Drawing.Size(82, 19);
            this.txt_descuento.SoloNumeros = false;
            this.txt_descuento.TabIndex = 201;
            this.txt_descuento.Text = "0.0";
            this.txt_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_descuento.Validar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(279, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 194;
            this.label12.Text = "RD$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(279, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 193;
            this.label11.Text = "RD$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(89, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 192;
            this.label9.Text = "RD$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(205, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 191;
            this.label8.Text = "IMPUESTOS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(205, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 190;
            this.label7.Text = "SUBTOTAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 189;
            this.label6.Text = "DESCUENTOS:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.groupBox3.Controls.Add(this.txt_id_cliente);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_nombre_cliente);
            this.groupBox3.Controls.Add(this.bt_agregar_cont);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txt_descuentoEmple);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(46, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 140);
            this.groupBox3.TabIndex = 223;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENTE";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txt_id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_id_cliente.Limpiar = true;
            this.txt_id_cliente.Location = new System.Drawing.Point(99, 73);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(37, 26);
            this.txt_id_cliente.SoloNumeros = false;
            this.txt_id_cliente.TabIndex = 235;
            this.txt_id_cliente.Validar = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label20.ForeColor = System.Drawing.Color.Snow;
            this.label20.Location = new System.Drawing.Point(8, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 234;
            this.label20.Text = "NOMBRE:";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txt_nombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre_cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_cliente.Limpiar = true;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(142, 73);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(125, 26);
            this.txt_nombre_cliente.SoloNumeros = false;
            this.txt_nombre_cliente.TabIndex = 233;
            this.txt_nombre_cliente.Validar = true;
            // 
            // bt_agregar_cont
            // 
            this.bt_agregar_cont.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_cont.FlatAppearance.BorderSize = 0;
            this.bt_agregar_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_cont.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_cont.Location = new System.Drawing.Point(273, 73);
            this.bt_agregar_cont.Name = "bt_agregar_cont";
            this.bt_agregar_cont.Size = new System.Drawing.Size(34, 26);
            this.bt_agregar_cont.TabIndex = 209;
            this.bt_agregar_cont.Text = "+";
            this.bt_agregar_cont.UseVisualStyleBackColor = false;
            this.bt_agregar_cont.Click += new System.EventHandler(this.bt_agregar_cont_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 205;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_descuentoEmple
            // 
            this.txt_descuentoEmple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txt_descuentoEmple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descuentoEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descuentoEmple.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descuentoEmple.Limpiar = true;
            this.txt_descuentoEmple.Location = new System.Drawing.Point(99, 26);
            this.txt_descuentoEmple.Multiline = true;
            this.txt_descuentoEmple.Name = "txt_descuentoEmple";
            this.txt_descuentoEmple.ReadOnly = true;
            this.txt_descuentoEmple.Size = new System.Drawing.Size(82, 24);
            this.txt_descuentoEmple.SoloNumeros = false;
            this.txt_descuentoEmple.TabIndex = 204;
            this.txt_descuentoEmple.Text = "0.0";
            this.txt_descuentoEmple.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_descuentoEmple.Validar = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(187, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 19);
            this.label18.TabIndex = 203;
            this.label18.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(6, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 17);
            this.label19.TabIndex = 202;
            this.label19.Text = "DESCUENTOS:";
            // 
            // btn_limpiar_cantidad
            // 
            this.btn_limpiar_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_limpiar_cantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar_cantidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_limpiar_cantidad.FlatAppearance.BorderSize = 0;
            this.btn_limpiar_cantidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_limpiar_cantidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_limpiar_cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_cantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpiar_cantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar_cantidad.Location = new System.Drawing.Point(918, 337);
            this.btn_limpiar_cantidad.Name = "btn_limpiar_cantidad";
            this.btn_limpiar_cantidad.Size = new System.Drawing.Size(266, 60);
            this.btn_limpiar_cantidad.TabIndex = 224;
            this.btn_limpiar_cantidad.Text = "LIMPIAR";
            this.btn_limpiar_cantidad.UseVisualStyleBackColor = false;
            this.btn_limpiar_cantidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(49, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 32);
            this.label15.TabIndex = 225;
            this.label15.Text = "VENTAS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(223, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 16);
            this.label16.TabIndex = 201;
            this.label16.Text = "no.Factura";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(437, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 201;
            this.label17.Text = "ID";
            // 
            // btn_factura
            // 
            this.btn_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_factura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_factura.FlatAppearance.BorderSize = 0;
            this.btn_factura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_factura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_factura.Image = global::_911_RD.Properties.Resources.recibo;
            this.btn_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_factura.Location = new System.Drawing.Point(918, 584);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(266, 65);
            this.btn_factura.TabIndex = 227;
            this.btn_factura.Text = "CREAR FACTURA";
            this.btn_factura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Image = global::_911_RD.Properties.Resources.list1;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(918, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(266, 65);
            this.button14.TabIndex = 221;
            this.button14.Text = "AGREGAR PRODUCTO";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_quitar.FlatAppearance.BorderSize = 0;
            this.btn_quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_quitar.Image = global::_911_RD.Properties.Resources.eraser;
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Location = new System.Drawing.Point(918, 499);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(266, 65);
            this.btn_quitar.TabIndex = 228;
            this.btn_quitar.Text = "REMOVER PRODUCTO";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1136, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 251;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_id.Limpiar = true;
            this.txt_id.Location = new System.Drawing.Point(464, 43);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(52, 20);
            this.txt_id.SoloNumeros = false;
            this.txt_id.TabIndex = 226;
            this.txt_id.Validar = false;
            // 
            // txt_numfactura
            // 
            this.txt_numfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txt_numfactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numfactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_numfactura.Limpiar = true;
            this.txt_numfactura.Location = new System.Drawing.Point(306, 44);
            this.txt_numfactura.Multiline = true;
            this.txt_numfactura.Name = "txt_numfactura";
            this.txt_numfactura.ReadOnly = true;
            this.txt_numfactura.Size = new System.Drawing.Size(114, 20);
            this.txt_numfactura.SoloNumeros = false;
            this.txt_numfactura.TabIndex = 201;
            this.txt_numfactura.Validar = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_cantidad.Limpiar = true;
            this.txt_cantidad.Location = new System.Drawing.Point(918, 85);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(266, 45);
            this.txt_cantidad.SoloNumeros = false;
            this.txt_cantidad.TabIndex = 200;
            this.txt_cantidad.Text = "0";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cantidad.Validar = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1200, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_numfactura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_limpiar_cantidad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        public ErrorTxtBox txt_nombre;
        private System.Windows.Forms.Label label2;
        public ErrorTxtBox txt_stock;
        private System.Windows.Forms.Label label4;
        public ErrorTxtBox txt_precio;
        private System.Windows.Forms.TextBox txt_codBarra;
        private System.Windows.Forms.Panel pnl_cod;
        public System.Windows.Forms.Button btn_traer;
        private System.Windows.Forms.Label label1;
        public ErrorTxtBox txt_des;
        public System.Windows.Forms.Button btn_1;
        public System.Windows.Forms.Button btn_2;
        public System.Windows.Forms.Button btn_3;
        public System.Windows.Forms.Button btn_4;
        public System.Windows.Forms.Button btn_5;
        public System.Windows.Forms.Button btn_6;
        public System.Windows.Forms.Button btn_7;
        public System.Windows.Forms.Button btn_8;
        public System.Windows.Forms.Button btn_9;
        public System.Windows.Forms.Button btn_0;
        public ErrorTxtBox txt_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox2;
        public ErrorTxtBox txt_impuesto;
        public ErrorTxtBox txt_subtotal;
        public ErrorTxtBox txt_descuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public ErrorTxtBox txt_impTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btn_limpiar_cantidad;
        private System.Windows.Forms.Label label15;
        public ErrorTxtBox txt_numfactura;
        public ErrorTxtBox txt_id;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button btn_factura;
        public System.Windows.Forms.Button btn_quitar;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public ErrorTxtBox txt_descuentoEmple;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_agregar_cont;
        private ErrorTxtBox txt_id_cliente;
        private System.Windows.Forms.Label label20;
        private ErrorTxtBox txt_nombre_cliente;
        public ErrorTxtBox txt_porcentaje_itb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}