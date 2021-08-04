
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
            this.bt_agregar_cont = new System.Windows.Forms.Button();
            this.bt_agregar_pais = new System.Windows.Forms.Button();
            this.bt_agregar_ciu = new System.Windows.Forms.Button();
            this.btn_agregar_provincia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 308);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(305, 32);
            this.lbl_titulo.Text = "AGREGAR DIRECCION";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 308);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 308);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Size = new System.Drawing.Size(106, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Size = new System.Drawing.Size(33, 29);
            this.btn_buscar.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(9, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 16);
            this.label22.TabIndex = 192;
            this.label22.Text = "Continente";
            // 
            // cb_continente
            // 
            this.cb_continente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_continente.FormattingEnabled = true;
            this.cb_continente.Location = new System.Drawing.Point(12, 162);
            this.cb_continente.Name = "cb_continente";
            this.cb_continente.Size = new System.Drawing.Size(166, 28);
            this.cb_continente.TabIndex = 191;
            this.cb_continente.SelectedValueChanged += new System.EventHandler(this.cb_continente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 194;
            this.label1.Text = "Pais";
            // 
            // cb_pais
            // 
            this.cb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Location = new System.Drawing.Point(12, 217);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(166, 28);
            this.cb_pais.TabIndex = 193;
            this.cb_pais.SelectedValueChanged += new System.EventHandler(this.cb_pais_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(226, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 196;
            this.label2.Text = "Provincia";
            // 
            // cb_provincia
            // 
            this.cb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_provincia.FormattingEnabled = true;
            this.cb_provincia.Location = new System.Drawing.Point(229, 162);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(156, 28);
            this.cb_provincia.TabIndex = 195;
            this.cb_provincia.SelectedValueChanged += new System.EventHandler(this.cb_provincia_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(229, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 198;
            this.label3.Text = "Ciudad";
            // 
            // cb_ciudad
            // 
            this.cb_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudad.FormattingEnabled = true;
            this.cb_ciudad.Location = new System.Drawing.Point(232, 221);
            this.cb_ciudad.Name = "cb_ciudad";
            this.cb_ciudad.Size = new System.Drawing.Size(153, 28);
            this.cb_ciudad.TabIndex = 197;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 207;
            this.label5.Text = "Descripcion guia";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Limpiar = true;
            this.txt_descripcion.Location = new System.Drawing.Point(15, 273);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(289, 26);
            this.txt_descripcion.SoloNumeros = true;
            this.txt_descripcion.TabIndex = 206;
            this.txt_descripcion.Validar = true;
            // 
            // bt_agregar_cont
            // 
            this.bt_agregar_cont.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_cont.FlatAppearance.BorderSize = 0;
            this.bt_agregar_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_cont.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_cont.Location = new System.Drawing.Point(184, 162);
            this.bt_agregar_cont.Name = "bt_agregar_cont";
            this.bt_agregar_cont.Size = new System.Drawing.Size(29, 28);
            this.bt_agregar_cont.TabIndex = 208;
            this.bt_agregar_cont.Text = "+";
            this.bt_agregar_cont.UseVisualStyleBackColor = false;
            this.bt_agregar_cont.Click += new System.EventHandler(this.bt_agregar_cont_Click);
            // 
            // bt_agregar_pais
            // 
            this.bt_agregar_pais.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar_pais.Enabled = false;
            this.bt_agregar_pais.FlatAppearance.BorderSize = 0;
            this.bt_agregar_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_pais.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_pais.Location = new System.Drawing.Point(184, 219);
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
            this.bt_agregar_ciu.Location = new System.Drawing.Point(392, 219);
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
            this.btn_agregar_provincia.Location = new System.Drawing.Point(392, 162);
            this.btn_agregar_provincia.Name = "btn_agregar_provincia";
            this.btn_agregar_provincia.Size = new System.Drawing.Size(29, 28);
            this.btn_agregar_provincia.TabIndex = 210;
            this.btn_agregar_provincia.Text = "+";
            this.btn_agregar_provincia.UseVisualStyleBackColor = false;
            this.btn_agregar_provincia.Click += new System.EventHandler(this.btn_agregar_provincia_Click);
            // 
            // FrmDireccionNativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 371);
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
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_continente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_provincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ciudad;
        private System.Windows.Forms.Label label5;
        private ErrorTxtBox txt_descripcion;
        private System.Windows.Forms.Button bt_agregar_cont;
        private System.Windows.Forms.Button bt_agregar_pais;
        private System.Windows.Forms.Button bt_agregar_ciu;
        private System.Windows.Forms.Button btn_agregar_provincia;
    }
}