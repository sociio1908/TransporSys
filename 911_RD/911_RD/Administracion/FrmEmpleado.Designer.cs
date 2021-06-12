
namespace _911_RD.Administracion
{
    partial class FrmEmpleado
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
            this.errorTxtBox1 = new _911_RD.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorTxtBox2 = new _911_RD.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorTxtBox3 = new _911_RD.ErrorTxtBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 733);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.Text = "EMPLEADO";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 733);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(279, 733);
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox1.Limpiar = false;
            this.errorTxtBox1.Location = new System.Drawing.Point(12, 158);
            this.errorTxtBox1.Name = "errorTxtBox1";
            this.errorTxtBox1.Size = new System.Drawing.Size(170, 26);
            this.errorTxtBox1.TabIndex = 143;
            this.errorTxtBox1.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 144;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 146;
            this.label3.Text = "NOMBRE";
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox2.Limpiar = false;
            this.errorTxtBox2.Location = new System.Drawing.Point(12, 214);
            this.errorTxtBox2.Name = "errorTxtBox2";
            this.errorTxtBox2.Size = new System.Drawing.Size(170, 26);
            this.errorTxtBox2.TabIndex = 145;
            this.errorTxtBox2.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 148;
            this.label4.Text = "APELLIDO";
            // 
            // errorTxtBox3
            // 
            this.errorTxtBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorTxtBox3.Limpiar = false;
            this.errorTxtBox3.Location = new System.Drawing.Point(12, 271);
            this.errorTxtBox3.Name = "errorTxtBox3";
            this.errorTxtBox3.Size = new System.Drawing.Size(170, 26);
            this.errorTxtBox3.TabIndex = 147;
            this.errorTxtBox3.Validar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.comboBox1.Location = new System.Drawing.Point(12, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 28);
            this.comboBox1.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 150;
            this.label5.Text = "SEXO";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 810);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorTxtBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorTxtBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorTxtBox1);
            this.Name = "FrmEmpleado";
            this.Text = "W";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_buscar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.btn_salir, 0);
            this.Controls.SetChildIndex(this.id_txt, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.errorTxtBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.errorTxtBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox errorTxtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox errorTxtBox2;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox errorTxtBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}