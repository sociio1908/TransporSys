
namespace _911_RD
{
    partial class FrmPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_traer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_suplidor = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_id_suplidor = new _911_RD.ErrorTxtBox();
            this.txt_nombre_suplidor = new _911_RD.ErrorTxtBox();
            this.txt_numfactura = new _911_RD.ErrorTxtBox();
            this.txt_impTotal = new _911_RD.ErrorTxtBox();
            this.txt_impuesto = new _911_RD.ErrorTxtBox();
            this.txt_subtotal = new _911_RD.ErrorTxtBox();
            this.txt_descuento = new _911_RD.ErrorTxtBox();
            this.txt_id = new _911_RD.ErrorTxtBox();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.txt_stock = new _911_RD.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorTxtBox1 = new _911_RD.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorTxtBox2 = new _911_RD.ErrorTxtBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_suplidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(978, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 277;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(29, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 255;
            this.label17.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(202, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 256;
            this.label16.Text = "# PEDIDO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 32);
            this.label15.TabIndex = 273;
            this.label15.Text = "PEDIDOS";
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
            this.groupBox2.Location = new System.Drawing.Point(338, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 140);
            this.groupBox2.TabIndex = 270;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.errorTxtBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.errorTxtBox1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.btn_traer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 170);
            this.groupBox1.TabIndex = 258;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARTICULOS ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(72, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 188;
            this.label10.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 189;
            this.label2.Text = "STOCK ACTUAL";
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
            this.btn_traer.Location = new System.Drawing.Point(152, 90);
            this.btn_traer.Name = "btn_traer";
            this.btn_traer.Size = new System.Drawing.Size(115, 59);
            this.btn_traer.TabIndex = 205;
            this.btn_traer.Text = " BUSCAR PRODUCTO";
            this.btn_traer.UseVisualStyleBackColor = false;
            this.btn_traer.Click += new System.EventHandler(this.btn_traer_Click);
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(9, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 291);
            this.dataGridView1.TabIndex = 257;
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
            this.btn_quitar.Location = new System.Drawing.Point(764, 529);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(266, 65);
            this.btn_quitar.TabIndex = 276;
            this.btn_quitar.Text = "REMOVER ARTICULO";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitar.UseVisualStyleBackColor = false;
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
            this.btn_factura.Location = new System.Drawing.Point(764, 604);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(266, 65);
            this.btn_factura.TabIndex = 275;
            this.btn_factura.Text = "REALIZAR PEDIDO";
            this.btn_factura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_factura.UseVisualStyleBackColor = false;
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
            this.button14.Location = new System.Drawing.Point(764, 458);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(272, 65);
            this.button14.TabIndex = 269;
            this.button14.Text = "AGREGAR ARTICULO";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_id_suplidor);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_nombre_suplidor);
            this.groupBox3.Controls.Add(this.btn_suplidor);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(12, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 140);
            this.groupBox3.TabIndex = 278;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SUPLIDOR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label18.ForeColor = System.Drawing.Color.Snow;
            this.label18.Location = new System.Drawing.Point(6, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 236;
            this.label18.Text = "NOMBRE:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label20.ForeColor = System.Drawing.Color.Snow;
            this.label20.Location = new System.Drawing.Point(6, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 17);
            this.label20.TabIndex = 234;
            this.label20.Text = "ID:";
            // 
            // btn_suplidor
            // 
            this.btn_suplidor.BackColor = System.Drawing.Color.LightGreen;
            this.btn_suplidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suplidor.Image = ((System.Drawing.Image)(resources.GetObject("btn_suplidor.Image")));
            this.btn_suplidor.Location = new System.Drawing.Point(116, 23);
            this.btn_suplidor.Name = "btn_suplidor";
            this.btn_suplidor.Size = new System.Drawing.Size(34, 27);
            this.btn_suplidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_suplidor.TabIndex = 205;
            this.btn_suplidor.TabStop = false;
            this.btn_suplidor.Click += new System.EventHandler(this.btn_suplidor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_id_suplidor
            // 
            this.txt_id_suplidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txt_id_suplidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_suplidor.Enabled = false;
            this.txt_id_suplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_suplidor.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_id_suplidor.Limpiar = true;
            this.txt_id_suplidor.Location = new System.Drawing.Point(73, 23);
            this.txt_id_suplidor.Name = "txt_id_suplidor";
            this.txt_id_suplidor.Size = new System.Drawing.Size(37, 24);
            this.txt_id_suplidor.SoloNumeros = false;
            this.txt_id_suplidor.TabIndex = 235;
            this.txt_id_suplidor.Validar = true;
            // 
            // txt_nombre_suplidor
            // 
            this.txt_nombre_suplidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txt_nombre_suplidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_suplidor.Enabled = false;
            this.txt_nombre_suplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre_suplidor.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_suplidor.Limpiar = true;
            this.txt_nombre_suplidor.Location = new System.Drawing.Point(73, 61);
            this.txt_nombre_suplidor.Name = "txt_nombre_suplidor";
            this.txt_nombre_suplidor.Size = new System.Drawing.Size(231, 26);
            this.txt_nombre_suplidor.SoloNumeros = false;
            this.txt_nombre_suplidor.TabIndex = 233;
            this.txt_nombre_suplidor.Validar = true;
            // 
            // txt_numfactura
            // 
            this.txt_numfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txt_numfactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numfactura.Enabled = false;
            this.txt_numfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numfactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_numfactura.Limpiar = true;
            this.txt_numfactura.Location = new System.Drawing.Point(275, 19);
            this.txt_numfactura.Multiline = true;
            this.txt_numfactura.Name = "txt_numfactura";
            this.txt_numfactura.ReadOnly = true;
            this.txt_numfactura.Size = new System.Drawing.Size(114, 20);
            this.txt_numfactura.SoloNumeros = false;
            this.txt_numfactura.TabIndex = 254;
            this.txt_numfactura.Validar = true;
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
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id.Limpiar = true;
            this.txt_id.Location = new System.Drawing.Point(32, 58);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(37, 26);
            this.txt_id.SoloNumeros = false;
            this.txt_id.TabIndex = 256;
            this.txt_id.Validar = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(75, 58);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(192, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 185;
            this.txt_nombre.Validar = true;
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Limpiar = true;
            this.txt_stock.Location = new System.Drawing.Point(32, 121);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(114, 26);
            this.txt_stock.SoloNumeros = false;
            this.txt_stock.TabIndex = 186;
            this.txt_stock.Validar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(326, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 258;
            this.label1.Text = "CANTIDAD A PEDIR";
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox1.Limpiar = true;
            this.errorTxtBox1.Location = new System.Drawing.Point(329, 121);
            this.errorTxtBox1.Name = "errorTxtBox1";
            this.errorTxtBox1.ReadOnly = true;
            this.errorTxtBox1.Size = new System.Drawing.Size(144, 26);
            this.errorTxtBox1.SoloNumeros = false;
            this.errorTxtBox1.TabIndex = 257;
            this.errorTxtBox1.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(493, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 260;
            this.label3.Text = "COSTO";
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox2.Limpiar = true;
            this.errorTxtBox2.Location = new System.Drawing.Point(496, 121);
            this.errorTxtBox2.Name = "errorTxtBox2";
            this.errorTxtBox2.ReadOnly = true;
            this.errorTxtBox2.Size = new System.Drawing.Size(144, 26);
            this.errorTxtBox2.SoloNumeros = false;
            this.errorTxtBox2.TabIndex = 259;
            this.errorTxtBox2.Validar = true;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_numfactura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedidos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_suplidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btn_quitar;
        public System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public ErrorTxtBox txt_numfactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public ErrorTxtBox txt_impTotal;
        public ErrorTxtBox txt_impuesto;
        public ErrorTxtBox txt_subtotal;
        public ErrorTxtBox txt_descuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        public ErrorTxtBox txt_nombre;
        private System.Windows.Forms.Label label2;
        public ErrorTxtBox txt_stock;
        public System.Windows.Forms.Button btn_traer;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public ErrorTxtBox txt_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private ErrorTxtBox txt_id_suplidor;
        private System.Windows.Forms.Label label20;
        private ErrorTxtBox txt_nombre_suplidor;
        private System.Windows.Forms.PictureBox btn_suplidor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        public ErrorTxtBox errorTxtBox1;
        private System.Windows.Forms.Label label3;
        public ErrorTxtBox errorTxtBox2;
    }
}