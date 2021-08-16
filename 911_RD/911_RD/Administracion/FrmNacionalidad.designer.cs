
namespace _911_RD.Administracion
{
    partial class FrmNacionalidad
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
            this.id_continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contienente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_nacionalidad = new _911_RD.ErrorTxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_agregar_pais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 249);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(225, 32);
            this.lbl_titulo.Text = "NACIONALIDAD";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 249);
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 249);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Size = new System.Drawing.Size(74, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(92, 99);
            this.btn_buscar.Size = new System.Drawing.Size(34, 29);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(10, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 196;
            this.label13.Text = "BUSQUEDA";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_filtro.Limpiar = false;
            this.txt_filtro.Location = new System.Drawing.Point(92, 305);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(170, 26);
            this.txt_filtro.SoloNumeros = false;
            this.txt_filtro.TabIndex = 195;
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
            this.id_continente,
            this.contienente,
            this.continente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
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
            this.dataGridView1.Size = new System.Drawing.Size(417, 185);
            this.dataGridView1.TabIndex = 194;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_eme
            // 
            this.id_eme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_eme.FillWeight = 20F;
            this.id_eme.HeaderText = "ID";
            this.id_eme.Name = "id_eme";
            this.id_eme.ReadOnly = true;
            // 
            // id_continente
            // 
            this.id_continente.HeaderText = "id_pais";
            this.id_continente.Name = "id_continente";
            this.id_continente.ReadOnly = true;
            this.id_continente.Visible = false;
            // 
            // contienente
            // 
            this.contienente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contienente.HeaderText = "NACIONALIDAD";
            this.contienente.Name = "contienente";
            this.contienente.ReadOnly = true;
            // 
            // continente
            // 
            this.continente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.continente.HeaderText = "PAIS";
            this.continente.Name = "continente";
            this.continente.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nacionalidad.Limpiar = true;
            this.txt_nacionalidad.Location = new System.Drawing.Point(12, 217);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(193, 26);
            this.txt_nacionalidad.SoloNumeros = false;
            this.txt_nacionalidad.TabIndex = 203;
            this.txt_nacionalidad.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 202;
            this.label7.Text = "NACIONALIDAD";
            // 
            // cb_pais
            // 
            this.cb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Location = new System.Drawing.Point(12, 160);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(164, 28);
            this.cb_pais.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 204;
            this.label1.Text = "PAIS";
            // 
            // bt_agregar_pais
            // 
            this.bt_agregar_pais.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_pais.FlatAppearance.BorderSize = 0;
            this.bt_agregar_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_pais.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_pais.Location = new System.Drawing.Point(185, 160);
            this.bt_agregar_pais.Name = "bt_agregar_pais";
            this.bt_agregar_pais.Size = new System.Drawing.Size(29, 28);
            this.bt_agregar_pais.TabIndex = 210;
            this.bt_agregar_pais.Text = "+";
            this.bt_agregar_pais.UseVisualStyleBackColor = false;
            this.bt_agregar_pais.Click += new System.EventHandler(this.bt_agregar_pais_Click);
            // 
            // FrmNacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 534);
            this.Controls.Add(this.bt_agregar_pais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_pais);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmNacionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNacionalidad";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_filtro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cb_pais, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txt_nacionalidad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bt_agregar_pais, 0);
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private ErrorTxtBox txt_nacionalidad;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_eme;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_continente;
        private System.Windows.Forms.DataGridViewTextBoxColumn contienente;
        private System.Windows.Forms.DataGridViewTextBoxColumn continente;
        private System.Windows.Forms.Button bt_agregar_pais;
    }
}