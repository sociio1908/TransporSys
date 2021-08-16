namespace _911_RD.Administracion
{
    partial class FrmPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cedula = new _911_RD.ErrorTxtBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_apellido = new _911_RD.ErrorTxtBox();
            this.fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new _911_RD.ErrorTxtBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_tipoIdent = new System.Windows.Forms.ComboBox();
            this.lbl_mayor_menor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorTxtBox1 = new _911_RD.ErrorTxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cargo = new _911_RD.ErrorTxtBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorTxtBox2 = new _911_RD.ErrorTxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorTxtBox3 = new _911_RD.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 504);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(152, 32);
            this.lbl_titulo.Text = "PACIENTES";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 504);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 504);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 84);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Location = new System.Drawing.Point(19, 103);
            this.id_txt.Size = new System.Drawing.Size(106, 29);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(131, 103);
            this.btn_buscar.Size = new System.Drawing.Size(40, 29);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 170;
            this.label1.Text = "IDENTIFICACION";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cedula.Limpiar = true;
            this.txt_cedula.Location = new System.Drawing.Point(6, 69);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(170, 26);
            this.txt_cedula.SoloNumeros = true;
            this.txt_cedula.TabIndex = 169;
            this.txt_cedula.Validar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(18, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 178;
            this.label14.Text = "APELLIDO";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_apellido.Limpiar = true;
            this.txt_apellido.Location = new System.Drawing.Point(18, 206);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(205, 26);
            this.txt_apellido.SoloNumeros = false;
            this.txt_apellido.TabIndex = 177;
            this.txt_apellido.Validar = true;
            // 
            // fecha_nac
            // 
            this.fecha_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nac.Location = new System.Drawing.Point(19, 318);
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.Size = new System.Drawing.Size(167, 22);
            this.fecha_nac.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(19, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 175;
            this.label5.Text = "FECHA NACIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 174;
            this.label4.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Limpiar = true;
            this.txt_nombre.Location = new System.Drawing.Point(19, 154);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(205, 26);
            this.txt_nombre.SoloNumeros = false;
            this.txt_nombre.TabIndex = 173;
            this.txt_nombre.Validar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cb_tipoIdent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_cedula);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(16, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 125);
            this.panel1.TabIndex = 179;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 16);
            this.label21.TabIndex = 194;
            this.label21.Text = "TIPO IDENTIFICACION";
            // 
            // cb_tipoIdent
            // 
            this.cb_tipoIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_tipoIdent.FormattingEnabled = true;
            this.cb_tipoIdent.Location = new System.Drawing.Point(3, 19);
            this.cb_tipoIdent.Name = "cb_tipoIdent";
            this.cb_tipoIdent.Size = new System.Drawing.Size(142, 28);
            this.cb_tipoIdent.TabIndex = 193;
            // 
            // lbl_mayor_menor
            // 
            this.lbl_mayor_menor.AutoSize = true;
            this.lbl_mayor_menor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_mayor_menor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_mayor_menor.Location = new System.Drawing.Point(192, 324);
            this.lbl_mayor_menor.Name = "lbl_mayor_menor";
            this.lbl_mayor_menor.Size = new System.Drawing.Size(50, 16);
            this.lbl_mayor_menor.TabIndex = 195;
            this.lbl_mayor_menor.Text = "Mayor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 197;
            this.label2.Text = "Nro. SEGURO";
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox1.Limpiar = true;
            this.errorTxtBox1.Location = new System.Drawing.Point(18, 259);
            this.errorTxtBox1.Name = "errorTxtBox1";
            this.errorTxtBox1.Size = new System.Drawing.Size(205, 26);
            this.errorTxtBox1.SoloNumeros = false;
            this.errorTxtBox1.TabIndex = 196;
            this.errorTxtBox1.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(298, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 207;
            this.label7.Text = "ESTADO";
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(301, 455);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(114, 28);
            this.cb_estado.TabIndex = 206;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(298, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 200;
            this.label11.Text = "ALERGICO A";
            // 
            // txt_cargo
            // 
            this.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cargo.Limpiar = true;
            this.txt_cargo.Location = new System.Drawing.Point(298, 103);
            this.txt_cargo.Multiline = true;
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(242, 77);
            this.txt_cargo.SoloNumeros = false;
            this.txt_cargo.TabIndex = 199;
            this.txt_cargo.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(292, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 198;
            this.label6.Text = "DATOS MEDICOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(298, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 213;
            this.label3.Text = "ESTADO COVID-19";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ACTIVO SINTOMATICO",
            "ACTIVO ASINTOMATICO",
            "INACTIVO"});
            this.comboBox1.Location = new System.Drawing.Point(298, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 214;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBox2.Location = new System.Drawing.Point(298, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(74, 28);
            this.comboBox2.TabIndex = 216;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(298, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 215;
            this.label8.Text = "EPILECIA ?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(298, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 16);
            this.label10.TabIndex = 218;
            this.label10.Text = "HISTORIAL MEDICO RELEVANTE";
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox2.Limpiar = true;
            this.errorTxtBox2.Location = new System.Drawing.Point(301, 308);
            this.errorTxtBox2.Multiline = true;
            this.errorTxtBox2.Name = "errorTxtBox2";
            this.errorTxtBox2.Size = new System.Drawing.Size(239, 45);
            this.errorTxtBox2.SoloNumeros = false;
            this.errorTxtBox2.TabIndex = 217;
            this.errorTxtBox2.Validar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(298, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 16);
            this.label12.TabIndex = 220;
            this.label12.Text = "MEDICAMENTOS EMERGENTES";
            // 
            // errorTxtBox3
            // 
            this.errorTxtBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorTxtBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox3.Limpiar = true;
            this.errorTxtBox3.Location = new System.Drawing.Point(301, 381);
            this.errorTxtBox3.Multiline = true;
            this.errorTxtBox3.Name = "errorTxtBox3";
            this.errorTxtBox3.Size = new System.Drawing.Size(239, 52);
            this.errorTxtBox3.SoloNumeros = false;
            this.errorTxtBox3.TabIndex = 219;
            this.errorTxtBox3.Validar = true;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 566);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.errorTxtBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.errorTxtBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorTxtBox1);
            this.Controls.Add(this.lbl_mayor_menor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.fecha_nac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Name = "FrmPaciente";
            this.Text = "S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.fecha_nac, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lbl_mayor_menor, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_cargo, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cb_estado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.errorTxtBox2, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.errorTxtBox3, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ErrorTxtBox txt_cedula;
        private System.Windows.Forms.Label label14;
        private ErrorTxtBox txt_apellido;
        private System.Windows.Forms.DateTimePicker fecha_nac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cb_tipoIdent;
        private System.Windows.Forms.Label lbl_mayor_menor;
        private System.Windows.Forms.Label label2;
        private ErrorTxtBox errorTxtBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label11;
        private ErrorTxtBox txt_cargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private ErrorTxtBox errorTxtBox2;
        private System.Windows.Forms.Label label12;
        private ErrorTxtBox errorTxtBox3;
    }
}