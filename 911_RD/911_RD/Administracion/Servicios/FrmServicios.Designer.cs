
namespace _911_RD.Administracion.Servicios
{
    partial class FrmServicios
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
            this.txt_error_placa = new System.Windows.Forms.Label();
            this.txt_error_chasis = new System.Windows.Forms.Label();
            this.txt_num_placa = new _911_RD.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id_modelo = new _911_RD.ErrorTxtBox();
            this.btn_modelo = new System.Windows.Forms.PictureBox();
            this.txt_modelo = new _911_RD.ErrorTxtBox();
            this.txt_id_marca = new _911_RD.ErrorTxtBox();
            this.btn_marca = new System.Windows.Forms.PictureBox();
            this.txt_marca = new _911_RD.ErrorTxtBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_num_chasis = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(15, 408);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(152, 32);
            this.lbl_titulo.Text = "SERVICIOS";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(160, 408);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(282, 408);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Size = new System.Drawing.Size(33, 29);
            // 
            // txt_error_placa
            // 
            this.txt_error_placa.AutoSize = true;
            this.txt_error_placa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_placa.ForeColor = System.Drawing.Color.Red;
            this.txt_error_placa.Location = new System.Drawing.Point(188, 325);
            this.txt_error_placa.Name = "txt_error_placa";
            this.txt_error_placa.Size = new System.Drawing.Size(17, 16);
            this.txt_error_placa.TabIndex = 236;
            this.txt_error_placa.Text = "X";
            this.txt_error_placa.Visible = false;
            // 
            // txt_error_chasis
            // 
            this.txt_error_chasis.AutoSize = true;
            this.txt_error_chasis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_error_chasis.ForeColor = System.Drawing.Color.Red;
            this.txt_error_chasis.Location = new System.Drawing.Point(185, 268);
            this.txt_error_chasis.Name = "txt_error_chasis";
            this.txt_error_chasis.Size = new System.Drawing.Size(17, 16);
            this.txt_error_chasis.TabIndex = 235;
            this.txt_error_chasis.Text = "X";
            this.txt_error_chasis.Visible = false;
            // 
            // txt_num_placa
            // 
            this.txt_num_placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_num_placa.Limpiar = true;
            this.txt_num_placa.Location = new System.Drawing.Point(18, 319);
            this.txt_num_placa.Name = "txt_num_placa";
            this.txt_num_placa.Size = new System.Drawing.Size(164, 26);
            this.txt_num_placa.SoloNumeros = false;
            this.txt_num_placa.TabIndex = 234;
            this.txt_num_placa.Validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 233;
            this.label10.Text = "NUMERO DE PLACA";
            // 
            // txt_id_modelo
            // 
            this.txt_id_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_modelo.Enabled = false;
            this.txt_id_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_modelo.Limpiar = true;
            this.txt_id_modelo.Location = new System.Drawing.Point(205, 209);
            this.txt_id_modelo.Name = "txt_id_modelo";
            this.txt_id_modelo.Size = new System.Drawing.Size(49, 26);
            this.txt_id_modelo.SoloNumeros = false;
            this.txt_id_modelo.TabIndex = 232;
            this.txt_id_modelo.Validar = true;
            // 
            // btn_modelo
            // 
            this.btn_modelo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelo.Image = global::_911_RD.Properties.Resources.search;
            this.btn_modelo.Location = new System.Drawing.Point(168, 209);
            this.btn_modelo.Name = "btn_modelo";
            this.btn_modelo.Size = new System.Drawing.Size(34, 26);
            this.btn_modelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_modelo.TabIndex = 231;
            this.btn_modelo.TabStop = false;
            // 
            // txt_modelo
            // 
            this.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelo.Enabled = false;
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_modelo.Limpiar = true;
            this.txt_modelo.Location = new System.Drawing.Point(15, 209);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(187, 26);
            this.txt_modelo.SoloNumeros = false;
            this.txt_modelo.TabIndex = 230;
            this.txt_modelo.Validar = true;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_marca.Enabled = false;
            this.txt_id_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_id_marca.Limpiar = true;
            this.txt_id_marca.Location = new System.Drawing.Point(205, 155);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(49, 26);
            this.txt_id_marca.SoloNumeros = false;
            this.txt_id_marca.TabIndex = 229;
            this.txt_id_marca.Validar = true;
            // 
            // btn_marca
            // 
            this.btn_marca.BackColor = System.Drawing.Color.LightGreen;
            this.btn_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca.Image = global::_911_RD.Properties.Resources.search;
            this.btn_marca.Location = new System.Drawing.Point(168, 155);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(34, 26);
            this.btn_marca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_marca.TabIndex = 228;
            this.btn_marca.TabStop = false;
            // 
            // txt_marca
            // 
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marca.Enabled = false;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_marca.Limpiar = true;
            this.txt_marca.Location = new System.Drawing.Point(15, 155);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(187, 26);
            this.txt_marca.SoloNumeros = false;
            this.txt_marca.TabIndex = 227;
            this.txt_marca.Validar = true;
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(18, 374);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(132, 28);
            this.cb_estado.TabIndex = 226;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 225;
            this.label1.Text = "MODELO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(12, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 16);
            this.label22.TabIndex = 224;
            this.label22.Text = "TIPO SERVICIO";
            // 
            // txt_num_chasis
            // 
            this.txt_num_chasis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num_chasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_num_chasis.Limpiar = true;
            this.txt_num_chasis.Location = new System.Drawing.Point(18, 263);
            this.txt_num_chasis.Name = "txt_num_chasis";
            this.txt_num_chasis.Size = new System.Drawing.Size(164, 26);
            this.txt_num_chasis.SoloNumeros = false;
            this.txt_num_chasis.TabIndex = 223;
            this.txt_num_chasis.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 222;
            this.label2.Text = "NUMERO DE CHASIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 237;
            this.label7.Text = "ESTADO";
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 740);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_error_placa);
            this.Controls.Add(this.txt_error_chasis);
            this.Controls.Add(this.txt_num_placa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_id_modelo);
            this.Controls.Add(this.btn_modelo);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.btn_marca);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_num_chasis);
            this.Controls.Add(this.label2);
            this.Name = "FrmServicios";
            this.Text = "FrmServicios";
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_num_chasis, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.txt_marca, 0);
            this.Controls.SetChildIndex(this.btn_marca, 0);
            this.Controls.SetChildIndex(this.txt_id_marca, 0);
            this.Controls.SetChildIndex(this.txt_modelo, 0);
            this.Controls.SetChildIndex(this.btn_modelo, 0);
            this.Controls.SetChildIndex(this.txt_id_modelo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txt_num_placa, 0);
            this.Controls.SetChildIndex(this.txt_error_chasis, 0);
            this.Controls.SetChildIndex(this.txt_error_placa, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_error_placa;
        private System.Windows.Forms.Label txt_error_chasis;
        private ErrorTxtBox txt_num_placa;
        private System.Windows.Forms.Label label10;
        private ErrorTxtBox txt_id_modelo;
        public System.Windows.Forms.PictureBox btn_modelo;
        private ErrorTxtBox txt_modelo;
        private ErrorTxtBox txt_id_marca;
        public System.Windows.Forms.PictureBox btn_marca;
        private ErrorTxtBox txt_marca;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private ErrorTxtBox txt_num_chasis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}