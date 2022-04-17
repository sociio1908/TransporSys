
namespace _911_RD.Administracion
{
    partial class FrmConfiguracionPedido
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
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new _911_RD.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_des = new _911_RD.ErrorTxtBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(8, 271);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(410, 32);
            this.lbl_titulo.Text = "CONFIGURACION DE PEDIDOS";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(153, 271);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(275, 271);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 80);
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.Text = "ID CONFIGURACION";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(15, 99);
            this.id_txt.Size = new System.Drawing.Size(105, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(126, 99);
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(8, 332);
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
            this.txt_filtro.Location = new System.Drawing.Point(90, 327);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 175;
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
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 359);
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
            this.dataGridView1.Size = new System.Drawing.Size(482, 185);
            this.dataGridView1.TabIndex = 174;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 40F;
            this.id_eme.HeaderText = "ID CONFIG";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "DESCRIPCION CONFIGURACION ";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 30F;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 215;
            this.label2.Text = "DESCRIPCION CONFIGURACION ";
            // 
            // txt_des
            // 
            this.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des.Limpiar = true;
            this.txt_des.Location = new System.Drawing.Point(15, 166);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(206, 26);
            this.txt_des.SoloNumeros = false;
            this.txt_des.TabIndex = 214;
            this.txt_des.Validar = true;
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(15, 220);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(139, 28);
            this.cb_estado.TabIndex = 213;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 212;
            this.label7.Text = "ESTADO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmConfiguracionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConfiguracionPedido";
            this.Text = "FrmConfiguracionPedido";
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
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.txt_des, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private ErrorTxtBox txt_filtro;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private ErrorTxtBox txt_des;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}